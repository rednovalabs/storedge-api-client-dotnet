using System;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using storedge_NET_SDK.Storedge.Api.Requests;
using storedge_NET_SDK.Storedge.Api.Responses;
using storedge_NET_SDK.Storedge.Api.Types;

namespace storedge_NET_SDK.Storedge.Api
{
    public class StoredgeClient
    {
        private readonly RestClient _consumer;
        
        public StoredgeClient(string baseUrl, string apiKey, string apiSecret)
        {
            //Create oauth consumer
            _consumer = new RestClient(baseUrl)
            {
                Authenticator = OAuth1Authenticator.ForProtectedResource(apiKey, apiSecret, null, null)
            };
        }

        //GET
        protected string Get(RestRequest request)
        {
            var response = "";
                
            //Try toexecute request
            try
            {
                response = _consumer.Execute(request).Content;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error executing request: " + error.Message);
            }

            return response;
        }

        //POST, PATCH, PUT
        protected string Forward(RestRequest request, object json)
        {
            var response = "";
            var jsonData = JsonConvert.SerializeObject(json);
            
            request.AddParameter("application/json; charset=utf-8", jsonData, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            //Try to execute request
            try
            {
                response = _consumer.Execute(request).Content;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error executing request: " + error.Message);
            }
            
            return response;
        }
        
        //DELETE
        protected string Delete(RestRequest request)
        {
            var response = "";
            
            //Try to execute request
            try
            {
                response = _consumer.Execute(request).Content;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error executing request: " + error.Message);
            }

            return response;
        }

        protected void Load(RestRequest request, Options options)
        {
            if (options == null) return;
            if (options.IsEmpty()) return;
            foreach (var pair in options.GetOptions())
            {
                request.AddQueryParameter(pair.Key, pair.Value);
            }
        }

        //Units
        public UnitResponse GetAllUnits(string facilityId, Options options)
        {
            var request = new RestRequest(facilityId + "/units", Method.GET);
            Load(request, options);
            var response = Get(request);
            
            return JsonConvert.DeserializeObject<UnitResponse>(response);
        }
        
        public SpecificUnitResponse GetSpecificUnits(string facilityId, string unitId, Options options)
        {
            var request = new RestRequest(facilityId + "/units/" + unitId, Method.GET);
            Load(request, options);
            var response = Get(request);
            
            return JsonConvert.DeserializeObject<SpecificUnitResponse>(response);
        }
        
        public UnitResponse GetAvailableUnits(string facilityId, Options options)
        {
            var request = new RestRequest(facilityId + "/units/available", Method.GET);
            Load(request, options);
            var response = Get(request);
            
            return JsonConvert.DeserializeObject<UnitResponse>(response);
        }
        
        //Tenants
        public SpecificTenantResponse SignUpTenant(string facilityId, string tenantId, Tenant tenantData, Options options)
        {
            var request = new RestRequest(facilityId + "/tenants/" + tenantId + "/sign_up", Method.POST);
            Load(request, options);
            var tenant = new JsonObject{{"tenant", tenantData}};
            var response = Forward(request, tenant);

            return JsonConvert.DeserializeObject<SpecificTenantResponse>(response);
        }

        public SpecificTenantResponse ChangeTenantPassword(string facilityId, string tenantId, Tenant tenantData, Options options)
        {
            var request = new RestRequest(facilityId + "/tenants/" + tenantId + "/change_password", Method.PUT);
            Load(request, options);
            var tenant = new JsonObject{{"tenant", tenantData}};
            var response = Forward(request, tenant);

            return JsonConvert.DeserializeObject<SpecificTenantResponse>(response);
        }

        public SpecificTenantResponse UpdateTenant(string facilityId, string tenantId, Tenant tenantData, Options options)
        {
            var request = new RestRequest(facilityId + "/tenants/" + tenantId, Method.PATCH);
            Load(request, options);
            var tenant = new JsonObject{{"tenant", tenantData}};
            var response = Forward(request, tenant);
            
            return JsonConvert.DeserializeObject<SpecificTenantResponse>(response);
        }

        //Leads
        public SpecificLeadResponse DeleteLead(string facilityId, string leadId, Parameters param)
        {
            var request = new RestRequest(facilityId + "/leads/" + leadId, Method.DELETE);
            request.AddQueryParameter("lead[close_reason_id]", param.GetSpecific("close_reason_id", 0));
            if (param.HasKey("notes_attributes"))
            {
                foreach (var note in param.Get("notes_attributes"))
                {
                    request.AddQueryParameter("lead[notes_attributes][][note]", note);
                }
            }
            var response = Delete(request);

            return JsonConvert.DeserializeObject<SpecificLeadResponse>(response);
        }

    }
}