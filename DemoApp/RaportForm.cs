using System;

namespace DemoApp
{
    public partial class RaportForm : DevExpress.XtraEditors.XtraForm
    {
        public RaportForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localsDataSet.Locals' table. You can move, or remove it, as needed.
            this.localsTableAdapter.Fill(this.localsDataSet.Locals);

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var t = DateFrom.DateTime;
            var t2 = DateTo.DateTime;
            var local = LocalLabel.Text;

            var tt = 1;
        }
    }
}
