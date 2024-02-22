using System;

namespace DataAccess.Models
{
    public class ExportDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Local { get; set; }
    }
}
