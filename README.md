# Storedge .NET(c#) SDK
.NET SDK for storedge API using [Newtonsoft](https://github.com/JamesNK/Newtonsoft.Json), [RestSharp](https://github.com/restsharp/RestSharp), and [Microsoft.CSharp](https://www.nuget.org/packages/Microsoft.CSharp/)

## API Documentation

### Building an SDK Client

```
string BaseUrl = "[INSERT]"
string ApiKey  = "[INSERT]";
string ApiSecret = "[INSERT]";

var client = new StoredgeClient(BaseUrl, ApiKey, ApiSecret);
//Note: as of current verion of sdk, user must validate if returned data exists and is not null
```

### Sending Requests
```
//Get requests
//Create options to pass with get request
var options = new Options();

//Set custom option (Premade option for per_page exists, this is just for example)
options.SetOption("per_page", "5");

//Use premade option
options.SetPageNum(2);

//Call request (will return type UnitResponse)
//Note: all requests will return an object that contains the request response body data and an object that contains the meta response data
//In this case there will be an object units (a list of units) and a meta object (contains request information  such as pagination etc.)
var units = client.GetAllUnits(FacilityId, options);

//Write to console
Console.WriteLine("Units (Page " + units.meta.pagination.current_page + "/" + units.meta.pagination.total_pages+ "):");
foreach (var unit in units.units)
{
    Console.WriteLine(" * {0}", unit.name);
}

//You do not need to have options
var specificUnit = client.GetSpecificUnits(FacilityId, UnitId, null);
Console.WriteLine("\nSpecific unit #" + specificUnit.unit.name);
Console.WriteLine(" * Request Method: " + specificUnit.meta.request_method);

var availableUnits = client.GetAvailableUnits(FacilityId, null);
Console.WriteLine("\nAvailable Units:");
foreach (var unit in availableUnits.units)
{
    Console.WriteLine(" * {0}", unit.name);
}

//Post request
//Create tenant data to be sent in body of request
var tenant = new Tenant {username = "awesome_o_5000", password = "supersecretpassword"};
//Create new options
var tenantOptions = new Options();
tenantOptions.SetSparseFields("fields[tenant]", "account_number,first_name");

//Call request
var newTenant = client.SignUpTenant(FacilityId, TenantId, tenant, tenantOptions);
Console.WriteLine("\n" + newTenant.tenant.first_name + " signed up!");
Console.WriteLine(" * Account Number: " + newTenant.tenant.account_number);

//Put request
//Create tenant data to be sent in body of request
var oldTenant = new Tenant {current_password = "supersecretpassword", new_password = "super_new_password"};
//Reuse tenantOptions
tenantOptions.Clear();
tenantOptions.SetSparseFields("fields[tenant]", "first_name");

//Call request
var updatedTenant = client.ChangeTenantPassword(FacilityId, TenantId, oldTenant, tenantOptions);
Console.WriteLine("\n" + updatedTenant.tenant.first_name + " has changed their password!");

//Patch request
//Create tenant data to be sent in body of request
var phoneNums = new PhoneNumber[] { new PhoneNumber{number = "5656663476"}};
var mailingAddress = new MailingAddress{address1 = "Ikea St", city = "Ikealand", state = "KS", postal = "82245-5456"};
var oldTenant2 = new Tenant {first_name = "Kelvin", last_name = "Benjamin", phone_numbers_attributes = phoneNums, mailing_address_attributes = mailingAddress};

//Call request
var updatedTenant2 = client.UpdateTenant(FacilityId, TenantId, oldTenant2, tenantOptions);
Console.WriteLine("\nUpdate tenant request status code: " + updatedTenant2.meta.status_code);

//Delete request
//Create parameters to send with delete request
var param = new Parameters();
var notes = new List<string>{"A++ would rent again!"};
var closeReason = new List<string>{"[ID]"};
param.SetParameter("notes_attributes", notes);
param.SetParameter("close_reason_id", closeReason);

//Call request
var deletedLead = client.DeleteLead(FacilityId, LeadId, param);
```

### Console Output
```
Units (Page 2/5):
 * 202
 * 300
 * 301
 * 302
 * 400

Specific unit #100
 * Request Method: GET

Available Units:
 * 200
 * 201
 * 400
 * 500
 * 502

Kelvin signed up!
 * Account Number: [NUMBER]

Kelvin has changed their password!

Update tenant request status code: 200
```
