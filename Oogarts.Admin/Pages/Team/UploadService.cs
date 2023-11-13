using Azure;
using Oogarts.Admin.Extensions;
using Oogarts.Shared.Job;
using Oogarts.Shared.Staffs;
using System;
using System.Net.Http.Json;
using System.Reflection.Metadata;

namespace Oogarts.Admin.Pages.Team
{
    public class UploadService
    {
        private readonly HttpClient client;
        private const string endpoint = "/SampleData";
        public UploadService(HttpClient client)
        {
               this.client = client;
        }

        public async Task<Stream> GetFile(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{endpoint}/GetFile?path={path}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStreamAsync();
                }
                else
                {
                    // Handle the error or return null, as needed
                    return null;
                }
            }
        }

    

    }
}
