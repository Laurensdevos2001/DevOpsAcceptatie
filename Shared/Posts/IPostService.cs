
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Posts
{
    public interface IPostService
    {
        Task<PostDto.Detail> GetDetailAsync(int postId);
        Task<PostResult.Index> GetIndexAsync(PostRequest.Index request);
        Task<int> CreateAsync(PostDto.Mutate model);
        Task EditAsync(int postId, PostDto.Mutate model);
        Task RemoveAsync(int postId);
        Task<byte[]> GetFileAsync(string? image);
    }
}
