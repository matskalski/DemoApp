using System;
using System.Collections.Generic;

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
            var dateFrom = DateFrom.DateTime;
            var dateTo = DateTo.DateTime;
            var local = LocalLabel.Text;

            var list = new List<Model>();

            list.Add(new Model
            {
                Id = 1,
                Name = "n"
            });

            list.Add(new Model
            {
                Id = 2,
                Name = "nn"
            });


            RaportGrid.DataSource = list;

            var tt = 1;
        }
    }

    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
