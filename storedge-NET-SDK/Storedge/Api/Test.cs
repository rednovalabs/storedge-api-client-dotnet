﻿using System;
using System.Collections.Generic;
using storedge_NET_SDK.Storedge.Api.Helpers;
using storedge_NET_SDK.Storedge.Api.Requests;
using storedge_NET_SDK.Storedge.Api.Types;

namespace storedge_NET_SDK.Storedge.Api
{
    public class Test
    {
        private const string BaseUrl = "https://api.storedgefms.com/v1/";
        private const string ApiKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        private const string ApiSecret = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        
        private const string FacilityId = "6b1b0fd0-293c-0135-3eed-10ddb1b10572";
        private const string TenantId = "7b99d61b-dad3-4b2c-8fb4-98f5b8dc68da";
        private const string UnitId = "9eed08a0-293c-0135-3eed-10ddb1b10572";
        private const string LeadId = "16a4a566-c3da-42d0-a73e-fbedc4dfdb33";
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Started\n");
            
            //Get requests
            var client = new StoredgeClient(BaseUrl, ApiKey, ApiSecret);

            //Create options to pass with get request
            var options = new Options();
            //Set custom option (Premade option for per_page exists)
            options.SetOption("per_page", "5");
            //Use premade option
            options.SetPageNum(2);
            var units = client.GetAllUnits(FacilityId, options);
            
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
            var closeReason = new List<string>{"1589a50b-f300-493e-ba95-70416baf216c"};
            param.SetParameter("notes_attributes", notes);
            param.SetParameter("close_reason_id", closeReason);
            
            //Call request
            var deletedLead = client.DeleteLead(FacilityId, LeadId, param);

            Console.WriteLine("\nDone!");
        }
    }
}