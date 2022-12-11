namespace JoyaClara.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Rings", Description="All Rings}"},
                new Category{CategoryId=2, CategoryName="Necklace", Description="All Necklaces"},
                new Category{CategoryId=3, CategoryName="Earings", Description="All Earings"}
            };
    }
}
