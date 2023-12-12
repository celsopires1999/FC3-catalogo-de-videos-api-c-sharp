using FC.Codeflix.Catalog.Domain.Repositories;
using FC.Codeflix.Catalog.UnitTests.Common;
using Moq;
using DomainEntity = FC.Codeflix.Catalog.Domain.Entity;

namespace FC.Codeflix.Catalog.UnitTests.Application.UseCases.Category.Common;

public class CategoryUseCaseFixture : BaseFixture
{
    public Mock<ICategoryRepository> GetMockRepository()
    => new();

    public string GetValidaName()
        => Faker.Commerce.Categories(1)[0];

    public string GetValidDescription()
        => Faker.Commerce.ProductDescription();

    public DomainEntity.Category GetValidCategory()
        => new(Guid.NewGuid(),
            GetValidaName(),
            GetValidDescription(),
            DateTime.Now,
            GetRandomBoolean());
}

[CollectionDefinition(nameof(CategoryUseCaseFixture))]
public class CategoryUseCaseFixtureCollection
    : ICollectionFixture<CategoryUseCaseFixture>
{ }
