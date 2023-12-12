using FC.Codeflix.Catalog.Application.Common;
using FC.Codeflix.Catalog.Application.UseCases.Category.Common;
using FC.Codeflix.Catalog.Domain.Repositories;

namespace FC.Codeflix.Catalog.Application.UseCases.Category.SearchCategory;

public class SearchCategory : ISearchCategory
{
    private readonly ICategoryRepository _repository;

    public SearchCategory(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<SearchListOutput<CategoryModelOutput>> Handle(
        SearchCategoryInput request, CancellationToken cancellationToken)
    {
        var searchInput = request.ToSearchInput();
        var searchOutput = await _repository.SearchAsync(searchInput, cancellationToken);
        return new SearchListOutput<CategoryModelOutput>(
            searchOutput.CurrentPage,
            searchOutput.PerPage,
            searchOutput.Total,
            searchOutput.Items.Select(CategoryModelOutput.FromCategory).ToList()
        );
    }
}
