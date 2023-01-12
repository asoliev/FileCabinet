using System.Text;

namespace FileCabnet.Models
{
    public class Book : BookBase
    {
        public string Publisher { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Publisher - {Publisher}");
            return base.ToString() + sb;
        }
    }
}