using System.Text;

namespace FileCabnet.Models
{
    public class LocalizedBook : Document
    {
        public string ISBN { get; set; }

        public string[] Authors { get; set; }

        public int NumberOfPages { get; set; }

        public string OriginalPublisher { get; set; }

        public string CountryOfLocalization { get; set; }

        public string LocalPublisher { get; set; }

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
            sb.AppendLine($"OriginalPublisher - {OriginalPublisher}");
            sb.AppendLine($"CountryOfLocalization - {CountryOfLocalization}");
            sb.AppendLine($"LocalPublisher - {LocalPublisher}");
            return base.ToString() + sb;
        }
    }
}