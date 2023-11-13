using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Oogarts.Domain.Staffs;
using Oogarts.Shared.Staffs;
using Oogarts.Shared.Posts;

namespace Oogarts.Admin.Pages.Posts
{
    public partial class Posts
    {
        private IEnumerable<PostDto.Index>? posts;
        private GridItemsProvider<PostDto.Index>? postsProvider;
        private string? searchTerm;

        [Inject] public IPostService PostService { get; set; } = default!;

        [Parameter, SupplyParameterFromQuery] public string? Search { get; set; }

        protected override async Task OnInitializedAsync()
        {
            postsProvider = async req =>
            {
                PostRequest.Index request = new()
                {
                    Page = req.StartIndex + 1,
                    PageSize = (int)(req.Count ?? 10),
                    Search = Search,
                    SortByAscending = req.SortByAscending ? req.SortByAscending : false,
                    SortByColumn = req.SortByColumn?.Title ?? "Id"

                };
                var response = await PostService.GetIndexAsync(request);
                return GridItemsProviderResult.From(
                                       items: response.Posts!.ToList(),
                                                          totalItemCount: response.TotalAmount);

            };
        }

        private void SearchTermChanged(ChangeEventArgs args)
        {
            searchTerm = args.Value?.ToString();
            FilterCustomers();
        }

        private void FilterCustomers()
        {
            Dictionary<string, object?> parameters = new();

            parameters.Add(nameof(searchTerm), searchTerm);

            var uri = NavigationManager.GetUriWithQueryParameters(parameters);

            NavigationManager.NavigateTo(uri);
        }

        private async Task RemovePostsAsync(int Id)
        {
            await PostService.RemoveAsync(Id);
            posts = posts?.Where(x => x.Id != Id).ToList();
        }
    }
}
