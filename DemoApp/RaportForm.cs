using DataAccess;
using System;
using System.Linq;

namespace DemoApp
{
    public partial class RaportForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly Class1 class1;
        public RaportForm()
        {
            class1 = new Class1();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localsDataSet.Locals' table. You can move, or remove it, as needed.
            this.localsTableAdapter.Fill(this.localsDataSet.Locals);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var dateFrom = DateFrom.DateTime;
            var dateTo = DateTo.DateTime;
            var local = LocalLabel.Text;

            var data = class1.Get().ToList();

            RaportGrid.DataSource = data;

            var tt = 1;
        }
    }
}
