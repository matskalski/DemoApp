using DataAccess.Models;
using DataAccess.Services;
using DevExpress.XtraEditors;
using System;
using System.Linq;

namespace DemoApp
{
    public partial class RaportForm : XtraForm
    {
        private readonly DataService _dataService;
        private int _displayedPage = 0;
        private ExportsFilterData _filters = new ExportsFilterData();

        public RaportForm()
        {
            _dataService = new DataService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localsDataSet.Locals' table. You can move, or remove it, as needed.
            this.localsTableAdapter.Fill(this.localsDataSet.Locals);
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            _displayedPage = 0;

            var dateFrom = DateFrom.DateTime;
            var dateTo = DateTo.DateTime;

            var data = await _dataService.GetExportsHistoryData(_filters);

            RaportGrid.DataSource = data.ToList();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (_displayedPage == 0)
            {
                return;
            }

            _displayedPage--;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _displayedPage++;
        }

        private void LocalSelect_EditValueChanged(object sender, EventArgs e)
        {
            var value = (sender as LookUpEdit).Text;
            _filters.Local = value;
        }

        private void DateFrom_EditValueChanged(object sender, EventArgs e)
        {
            var value = (sender as DateEdit).Text;
            _filters.DateFrom = value;
        }

        private void DateTo_EditValueChanged(object sender, EventArgs e)
        {
            var value = (sender as DateEdit).Text;
            _filters.DateTo = value;
        }
    }
}
