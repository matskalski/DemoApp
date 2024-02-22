using Dapper;
using DataAccess.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
ORDER BY id
OFFSET {_site} ROWS
FETCH NEXT 100 ROWS ONLY";

        public async Task<List<ExportDataDto>> GetExportsHistoryData(ExportsFilterData filters)
        {
            var data = (await GetExportsData(_baseQuery)).ToList();

            return data.Select(s => s.AsDto()).ToList();
        }

        private async Task<IEnumerable<ExportDataModel>> GetExportsData(string query)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoApp.Properties.Settings.DemoAppDbConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                return await db.QueryAsync<ExportDataModel>(query);
            }
        }

        private string PrepareQuery()
        {
            return null;
        }
    }
}
