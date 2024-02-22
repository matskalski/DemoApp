using DataAccess.Models;
using DataAccess.Services;
using DevExpress.XtraEditors;
using System;

namespace DemoApp
{
    public partial class RaportForm : XtraForm
    {
        private readonly DataService _dataService;
        private int _currentPage = 1;
        private int _maxPagesCount = 1;
        private ExportsFilterData _filters = new ExportsFilterData();

        public RaportForm()
        {
            _dataService = new DataService();
            InitializeComponent();

            PageLabel.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localsDataSet.Locals' table. You can move, or remove it, as needed.
            this.localsTableAdapter.Fill(this.localsDataSet.Locals);
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            _currentPage = 1;

            var dateFrom = DateFrom.DateTime;
            var dateTo = DateTo.DateTime;

            var result = await _dataService.GetExportsHistoryData(_filters);
            _maxPagesCount = (int)Math.Ceiling((double)(result.RowsCount / 100M));

            RaportGrid.DataSource = result.Data;
            UpdatePageLabel();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (_currentPage == 1)
            {
                return;
            }

            _currentPage--;
            UpdatePageLabel();

            if (_currentPage == 1)
            {
                PrevButton.Enabled = false;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _currentPage++;
            UpdatePageLabel();
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

        private void UpdatePageLabel()
        {
            PageLabel.Text = $"Strona {_currentPage}/{_maxPagesCount}";
        }
    }
}
