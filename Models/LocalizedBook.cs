using System.Text;

namespace FileCabnet.Models
{
    public class LocalizedBook : BookBase
    {
        public string OriginalPublisher { get; set; }

        public string CountryOfLocalization { get; set; }

        public string LocalPublisher { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"OriginalPublisher - {OriginalPublisher}");
            sb.AppendLine($"CountryOfLocalization - {CountryOfLocalization}");
            sb.AppendLine($"LocalPublisher - {LocalPublisher}");
            return base.ToString() + sb;
        }
    }
}