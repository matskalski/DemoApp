﻿using DataAccess.Models;
using DataAccess.Services;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Threading.Tasks;

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
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadLocals();
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!AreFiltersValid())
            {
                return;
            }

            _currentPage = 1;
            var result = await SetRaportGridData();
            _maxPagesCount = (int)Math.Ceiling((double)(result / 100M));

            UpdatePageLabel();
        }

        private bool AreFiltersValid()
        {
            var dateFrom = DateFrom.DateTime;
            var dateTo = DateTo.DateTime;

            var areDatesValid = dateFrom <= dateTo;

            if (!areDatesValid)
            {
                ValidationMessage.Text = "Data od jest późniejsza niż data do";
                RaportGrid.DataSource = null;
            }
            else
            {
                ValidationMessage.Text = null;
            }

            return areDatesValid;
        }

        private async void PrevButton_Click(object sender, EventArgs e)
        {
            if (_currentPage == 1)
            {
                return;
            }

            _currentPage--;
            await SetRaportGridData();
            UpdatePageLabel();
        }

        private async void NextButton_Click(object sender, EventArgs e)
        {
            if (_currentPage == _maxPagesCount)
            {
                return;
            }

            _currentPage++;
            await SetRaportGridData();
            UpdatePageLabel();
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

        private async Task<int> SetRaportGridData()
        {
            var result = await _dataService.GetExportsHistoryData(_filters, _currentPage);
            RaportGrid.DataSource = result.Data;

            return result.RowsCount;
        }

        private void LocalSelectBox_EditValueChanged(object sender, EventArgs e)
        {
            var value = (sender as LookUpEdit).Text;
            _filters.Local = value;
        }

        private async Task LoadLocals()
        {
            var locals = await _dataService.GetLocalsList();
            locals.Add(null);

            LocalSelectBox.Properties.DataSource = locals.OrderBy(o => o);
            LocalSelectBox.Properties.NullText = null;
        }

        private async void FirstPageButton_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            await SetRaportGridData();
            UpdatePageLabel();
        }

        private async void LastPageButton_Click(object sender, EventArgs e)
        {
            _currentPage = _maxPagesCount;
            await SetRaportGridData();
            UpdatePageLabel();
        }
    }
}
