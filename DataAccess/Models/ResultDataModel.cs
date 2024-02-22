using System.Collections.Generic;

namespace DataAccess.Models
{
    public class ResultDataModel
    {
        public List<ExportDataDto> Data { get; set; }
        public int RowsCount { get; set; }
    }
}
