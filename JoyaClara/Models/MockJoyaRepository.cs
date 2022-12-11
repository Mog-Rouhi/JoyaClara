using System.IO.Pipelines;

namespace JoyaClara.Models
{
    public class MockJoyaRepository : IJoyaRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Joya> AllJoyas =>
            new List<Joya>
            {
                new Joya {JoyaId = 1, Name="Solitaire Ring", Price=750, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus posuere tincidunt faucibus. Sed aliquet et ligula at ornare. Ut posuere quam at vulputate pharetra. Integer rutrum, ante ut suscipit fermentum, mi massa tempor sem, non facilisis nunc quam et ex. Proin vitae pellentesque magna. Curabitur purus est, luctus et lectus ultricies, egestas volutpat dolor. Vivamus sollicitudin ex eu posuere viverra. Aliquam pellentesque aliquet mauris, et elementum ligula condimentum id. Cras fringilla, massa quis scelerisque molestie, quam nibh lobortis mauris, quis placerat dolor enim non mi. Morbi finibus vulputate risus nec auctor. Ut a metus maximus, pellentesque leo nec, luctus lorem.\r\n\r\n", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="", InStock=true, IsJoyaOfTheWeek=false, ImageThumbnailUrl=""},
                new Joya {JoyaId = 2, Name="Topaz Necklace", Price=1000, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus posuere tincidunt faucibus. Sed aliquet et ligula at ornare. Ut posuere quam at vulputate pharetra. Integer rutrum, ante ut suscipit fermentum, mi massa tempor sem, non facilisis nunc quam et ex. Proin vitae pellentesque magna. Curabitur purus est, luctus et lectus ultricies, egestas volutpat dolor. Vivamus sollicitudin ex eu posuere viverra. Aliquam pellentesque aliquet mauris, et elementum ligula condimentum id. Cras fringilla, massa quis scelerisque molestie, quam nibh lobortis mauris, quis placerat dolor enim non mi. Morbi finibus vulputate risus nec auctor. Ut a metus maximus, pellentesque leo nec, luctus lorem.\r\n\r\n", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="", InStock=true, IsJoyaOfTheWeek=false, ImageThumbnailUrl=""},
                new Joya {JoyaId = 3, Name="Marquise Earrings", Price=350, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus posuere tincidunt faucibus. Sed aliquet et ligula at ornare. Ut posuere quam at vulputate pharetra. Integer rutrum, ante ut suscipit fermentum, mi massa tempor sem, non facilisis nunc quam et ex. Proin vitae pellentesque magna. Curabitur purus est, luctus et lectus ultricies, egestas volutpat dolor. Vivamus sollicitudin ex eu posuere viverra. Aliquam pellentesque aliquet mauris, et elementum ligula condimentum id. Cras fringilla, massa quis scelerisque molestie, quam nibh lobortis mauris, quis placerat dolor enim non mi. Morbi finibus vulputate risus nec auctor. Ut a metus maximus, pellentesque leo nec, luctus lorem.\r\n\r\n", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="", InStock=true, IsJoyaOfTheWeek=true, ImageThumbnailUrl=""},
                new Joya {JoyaId = 4, Name="Pavé Diamond Ring", Price=850, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus posuere tincidunt faucibus. Sed aliquet et ligula at ornare. Ut posuere quam at vulputate pharetra. Integer rutrum, ante ut suscipit fermentum, mi massa tempor sem, non facilisis nunc quam et ex. Proin vitae pellentesque magna. Curabitur purus est, luctus et lectus ultricies, egestas volutpat dolor. Vivamus sollicitudin ex eu posuere viverra. Aliquam pellentesque aliquet mauris, et elementum ligula condimentum id. Cras fringilla, massa quis scelerisque molestie, quam nibh lobortis mauris, quis placerat dolor enim non mi. Morbi finibus vulputate risus nec auctor. Ut a metus maximus, pellentesque leo nec, luctus lorem.\r\n\r\n", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="", InStock=true, IsJoyaOfTheWeek=true, ImageThumbnailUrl=""}
            };
    }
        public IEnumerable<Joya> JoyasOfTheWeek
        {
            get
            {
                return AllJoyas.Where(p => p.IsJoyaOfTheWeek);
            }
        }

        public Joya? GetJoyaById(int joyaId) => AllJoyas.FirstOrDefault(p => p.JoyaId == joyaId);

        public IEnumerable<Joya> SearchJoyas(string searchQuery)
        {
            throw new NotImplementedException();
        }
}
