using FileCabnet.Models;

namespace FileCabinetApp
{
    public static class TestData
    {
        public static Patent Patent = new Patent
        {
            Id = 1,
            Title = "Patent",
            DatePublished = DateTime.Now,
            ExpirationDate = DateTime.Now + TimeSpan.FromDays(10),
            Authors = new[] { "name1", "name2" },
            UniqueId = Guid.NewGuid()
        };

        public static Book Book = new Book
        {
            Id = 2,
            Title = "Book",
            DatePublished = DateTime.Now,
            Authors = new[] { "name1", "name2" },
            ISBN = "ISBN-2023-0000",
            Publisher = "publisher1",
            NumberOfPages = 100
        };

        public static LocalizedBook LocalizedBook = new LocalizedBook
        {
            Id = 3,
            Title = "LocalizedBook",
            DatePublished = DateTime.Now,
            Authors = new[] { "name1", "name2" },
            ISBN = "ISBN-1111-2222",
            OriginalPublisher = "OriginalPublisher",
            CountryOfLocalization = "UZ",
            LocalPublisher = "bypulisher1",
            NumberOfPages = 150
        };

        public static Magazine Magazine = new Magazine
        {
            Id = 4,
            Title = "Magazine",
            DatePublished = DateTime.Now,
            Publisher = "Publisher",
            ReleaseNumber = 123
        };
    }
}