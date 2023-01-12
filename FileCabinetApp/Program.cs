using FileCabinet;
using FileCabinetApp;
using FileCabnet.Models;

var repo = new DocumentRepository();
repo.Write(new List<BaseDocument>
{
    TestData.Patent,
    TestData.Book,
    TestData.LocalizedBook,
    TestData.Magazine,
});
for (int i = 1; i <= DocumentRepository.GetDocumentTypes().Count(); i++)
{
    var byId = repo.GetById(i);
    Console.WriteLine(byId.GetType());
    Console.WriteLine(byId);
}
Console.ReadKey();