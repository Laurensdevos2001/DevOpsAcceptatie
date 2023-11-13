using Oogarts.Admin.Extensions;
using Oogarts.Domain.Staffs;
using Oogarts.Shared.Common;
using Oogarts.Shared.Staffs;
using Oogarts.Shared.Posts;
using System.Net.Http.Json;

namespace Oogarts.Admin.Pages.Posts
{
    public class PostService : IPostService
    {


        private readonly HttpClient client;
        private const string endpoint = "/Post";
        public PostService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<int> CreateAsync(PostDto.Mutate model)
        {
            var response = await client.PostAsJsonAsync(endpoint, model);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task EditAsync(int postId, PostDto.Mutate model)
        {
            await client.PutAsJsonAsync($"{endpoint}/{postId}", model);
        }

        public async Task<PostDto.Detail> GetDetailAsync(int postId)
        {
            var response = await client.GetFromJsonAsync<PostDto.Detail>($"{endpoint}/{postId}");
            return response!;
        }

        public async Task<PostResult.Index> GetIndexAsync(Request.Index request)
        {
            var response = await client.GetFromJsonAsync<PostResult.Index>($"{endpoint}?{request.AsQueryString()}");
            return response!;
        }

        public async Task RemoveAsync(int postId)
        {
            await client.DeleteAsync($"{endpoint}/{postId}");
        }

        public async Task<Byte[]> GetFileAsync(string fileName)
        {
            // Construct the endpoint to retrieve the file
            var fileEndpoint = $"/Files{fileName}";

            // Send an HTTP GET request to retrieve the file
            var response = await client.GetAsync(fileEndpoint);

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Return the file content as a base64-encoded string
                return await response.Content.ReadAsByteArrayAsync();
            }
            else
            {
                // Handle the case when the file retrieval was not successful
                return null; // or throw an exception, log an error, etc.
            }
        }
    }
}
