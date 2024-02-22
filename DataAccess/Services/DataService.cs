using Dapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
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

        public async Task<List<ExportDataDto>> GetExportsHistoryData(ExportsFilterData filters)
        {
            var queryTemplate = PrepareQuery(filters);
            var data = (await GetExportsData(queryTemplate)).ToList();

            return data.Select(s => s.AsDto()).ToList();
        }

        private async Task<IEnumerable<ExportDataModel>> GetExportsData(SqlBuilder.Template queryTemplate)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoApp.Properties.Settings.DemoAppDbConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                return await db.QueryAsync<ExportDataModel>(queryTemplate.RawSql, queryTemplate.Parameters);
            }
        }

        private SqlBuilder.Template PrepareQuery(ExportsFilterData filters)
        {
            var builder = new SqlBuilder();

            var builderTemplate = builder.AddTemplate(_baseQuery);

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
