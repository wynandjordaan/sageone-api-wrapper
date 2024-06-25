﻿using System;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class SupplierReturnRequest: RequestBase, ISupplierReturnRequest
    {
        public SupplierReturnRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public SupplierReturn Get(int id)
        {
            var response = _client.Execute<SupplierReturn>(new RestRequest(string.Format("SupplierReturn/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PagingResponse<SupplierReturn> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0)
        {
            var url = string.Format("SupplierReturn/Get?companyid={0}&includeDetail={1}&includeSupplierDetails={2}&apikey={3}", _companyId, includeDetail.ToString().ToLower(), includeSupplierDetails.ToString().ToLower(), _apiKey);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("SupplierReturn/Get?includeDetail={0}&includeSupplierDetails={1}?apikey={2}&companyid={3}&$filter={4}", includeDetail, includeSupplierDetails, _apiKey, _companyId, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<SupplierReturn>>(response);
        }

        public SupplierReturn Save(SupplierReturn @return)
        {
            var url = string.Format("SupplierReturn/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(@return);
            var response = _client.Execute<SupplierReturn>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public async Task<SupplierReturn> SaveAsync(SupplierReturn @return)
        {
            var url = string.Format("SupplierReturn/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(@return);
            var response = await _client.ExecuteTaskAsync<SupplierReturn>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public SupplierReturn Calculate(SupplierReturn @return)
        {
            var url = string.Format("SupplierReturn/Calculate?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(@return);
            var response = _client.Execute<SupplierReturn>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public bool Email(EmailRequest email)
        {
            var url = string.Format("SupplierReturn/Email?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(email);
            var response = _client.Execute<EmailRequest>(request);
            return response.ResponseStatus == ResponseStatus.Completed;
        }
    }
}