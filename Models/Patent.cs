using System.Text;

namespace FileCabnet.Models
{
    public class Patent : BaseDocument
    {
        public string[] Authors { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Guid UniqueId { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Authors: ");
            foreach (var author in Authors)
            {
                sb.AppendLine($"\t{author}");
            }
            sb.AppendLine($"ExpirationDate - {ExpirationDate}");
            sb.AppendLine($"UniqueId - {UniqueId}");
            return base.ToString() + sb;
        }
    }
}