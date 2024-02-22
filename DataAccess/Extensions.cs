using DataAccess.Models;

namespace DataAccess
{
    internal static class Extensions
    {
        public static ExportDataDto AsDto(this ExportDataModel model)
        {
            return new ExportDataDto
            {
                Name = model.Name,
                Date = model.Date.Date.ToString("yyyy-MM-dd"),
                Time = model.Date.ToString("HH:mm"),
                User = model.UserName,
                Local = model.Local
            };
        }
    }
}
