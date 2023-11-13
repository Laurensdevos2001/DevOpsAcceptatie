using Microsoft.AspNetCore.Components;
using Oogarts.Shared.Posts;

namespace Oogarts.Admin.Pages.Posts
{
    public partial class CreatePost
    {
        private PostDto.Mutate post = new();

        [Parameter] public EventCallback OnPostCreated { get; set; }
        [Inject] public IPostService PostService { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            post.Title = "";
            post.Content = "";
            post.AuthorId = 0;
            post.Introduction = "";
            post.Image = "/stockPost.jpg";
            base64 = "/stockPost.jpg";
            StateHasChanged();
        }

        private async Task CreatePostAsync()
        {
            try
            {
                Console.WriteLine(post);
                await PostService.CreateAsync(post);
                await OnPostCreated.InvokeAsync();
                NavigationManager.NavigateTo("/blog");
            }catch (Exception ex)
            {
                await this.ToastObj.ShowAsync();
            }

        }
    }
}
