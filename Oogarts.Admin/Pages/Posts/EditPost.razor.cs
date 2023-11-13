using Microsoft.AspNetCore.Components;
using Microsoft.IdentityModel.Tokens;
using Oogarts.Shared.Account;
using Oogarts.Shared.Posts;

namespace Oogarts.Admin.Pages.Posts
{
    public partial class EditPost
    {
        private PostDto.Mutate post = new();

        [Inject] public IPostService PostService { get; set; } = default!;

        [Parameter] public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PostDto.Detail detail = await PostService.GetDetailAsync(Id);
            post = new PostDto.Mutate
            {
                AuthorId = detail.Author.Id,
                Content = detail.Content,
                Title = detail.Title,
                Introduction = detail.Introduction,
                Image = detail.Image
            };
            if (detail.Image.IsNullOrEmpty())
            {
                base64 = "/stockPost.jpg";
            }
            else
            {
                Byte[] a = await PostService.GetFileAsync(detail.Image);

                // convert byte[] to Base64 String

                base64 = "data:image/png;base64," + Convert.ToBase64String(a);

            }
        }

        private async Task EditPostAsync()
        {
            try
            {
                await PostService.EditAsync(Id, post);
                NavigationManager.NavigateTo("/blog");
            }
            catch (Exception ex)
            {
                await this.ToastObj.ShowAsync();
            }
        }

    }
}
