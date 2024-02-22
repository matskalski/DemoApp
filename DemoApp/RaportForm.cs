using DataAccess.Services;
using System;
using System.Linq;

namespace DemoApp
{
    public partial class RaportForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataService dataService;
        public RaportForm()
        {
            dataService = new DataService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localsDataSet.Locals' table. You can move, or remove it, as needed.
            this.localsTableAdapter.Fill(this.localsDataSet.Locals);
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            var dateFrom = DateFrom.DateTime;
            var dateTo = DateTo.DateTime;
            var local = LocalLabel.Text;

            var data = await dataService.GetExportsHistoryData();

            RaportGrid.DataSource = data.ToList();
        }
    }
}
