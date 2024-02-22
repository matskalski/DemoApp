using System.ComponentModel;

namespace DataAccess.Models
{
    public class ExportDataDto
    {
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Data")]
        public string Date { get; set; }
        [DisplayName("Godzina")]
        public string Time { get; set; }
        [DisplayName("Użytkownik")]
        public string User { get; set; }
        [DisplayName("Lokal")]
        public string Local { get; set; }
    }
}
