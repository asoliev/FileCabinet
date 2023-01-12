using System.Text;

namespace FileCabnet.Models
{
    public abstract class BookBase : BaseDocument
    {
        public string ISBN { get; set; }

        public string[] Authors { get; set; }

        public int NumberOfPages { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"ISBN - {ISBN}");
            sb.AppendLine("Authors: ");
            foreach (var author in Authors)
            {
                sb.AppendLine($"\t{author}");
            }
            sb.AppendLine($"NumberOfPages - {NumberOfPages}");
            return base.ToString() + sb;
        }
    }
}