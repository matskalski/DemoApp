using Dapper;
using DataAccess.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class DataService
    {
        private static int _site = 0;
        private string _baseQuery =
 $@"SELECT [Id] 
,[Name] 
,[Date] 
,[UserName] 
,[Local]  
FROM [dbo].[ExportsHistory]
/**where**/
ORDER BY id
OFFSET {_site} ROWS
FETCH NEXT 100 ROWS ONLY";

        private string _rowsCountQuery =
$@"SELECT COUNT(1)
FROM [dbo].[ExportsHistory]
/**where**/";

        public async Task<ResultDataModel> GetExportsHistoryData(ExportsFilterData filters)
        {
            var dataQueryTemplate = PrepareQuery(filters, _baseQuery);
            var rowsCountQuery = PrepareQuery(filters, _rowsCountQuery);
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoApp.Properties.Settings.DemoAppDbConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                var data = await db.QueryAsync<ExportDataModel>(dataQueryTemplate.RawSql, dataQueryTemplate.Parameters);
                var count = await db.QueryAsync<int>(rowsCountQuery.RawSql, rowsCountQuery.Parameters);

                return new ResultDataModel
                {
                    Data = data.Select(s => s.AsDto()).ToList(),
                    RowsCount = count.First()
                };
            }
        }

        private SqlBuilder.Template PrepareQuery(ExportsFilterData filters, string query)
        {
            var builder = new SqlBuilder();
            var builderTemplate = builder.AddTemplate(query);

            if (!string.IsNullOrEmpty(filters.DateFrom))
            {
                var dateFrom = ChangeDateFormat(filters.DateFrom);
                builder.Where("Date >= @dateFrom", new { dateFrom = dateFrom });
            }

            if (!string.IsNullOrEmpty(filters.DateTo))
            {
                var dateTo = ChangeDateFormat(filters.DateTo);
                builder.Where("Date <= @dateTo", new { dateTo = dateTo });
            }

            if (!string.IsNullOrEmpty(filters.Local))
            {
                builder.Where("Local = @local", new { local = filters.Local });
            }

            return builderTemplate;
        }

        private string ChangeDateFormat(string date)
        {
            return DateTime
                    .ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture)
                    .ToString("yyyy-MM-dd");
        }
    }
}
