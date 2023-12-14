using FC.Codeflix.Catalog.Application.UseCases.Category.SaveCategory;
using FC.Codeflix.Catalog.UnitTests.Application.UseCases.Category.Common;

namespace FC.Codeflix.Catalog.UnitTests.Application.UseCases.Category.SaveCategory;
public class SaveCategoryTestFixture : CategoryUseCaseFixture
{
    public SaveCategoryInput GetValidInput()
        => new(Guid.NewGuid(),
            GetValidaName(),
            GetValidDescription(),
            DateTime.Now,
            GetRandomBoolean());

    public SaveCategoryInput GetInvalidInput()
    => new(Guid.NewGuid(),
        null,
        GetValidDescription(),
        DateTime.Now,
        GetRandomBoolean());
}

[CollectionDefinition(nameof(SaveCategoryTestFixture))]
public class SaveCategoryTestFixtureCollection
    : ICollectionFixture<SaveCategoryTestFixture>
{ }
