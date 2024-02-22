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
        private int site = 0;

        public async Task<List<ExportDataDto>> GetExportsHistoryData()
        {
            var data = (await GetExportsData()).ToList();

            return data.Select(s => s.AsDto()).ToList();
        }

        private async Task<IEnumerable<ExportDataModel>> GetExportsData()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoApp.Properties.Settings.DemoAppDbConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                return await db.QueryAsync<ExportDataModel>("SELECT [Id] ,[Name] ,[Date] ,[UserName] ,[Local]  FROM [DemoAppDb].[dbo].[ExportsHistory]");
            }
        }
    }
}
