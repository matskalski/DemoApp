namespace DemoApp
{
    partial class RaportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.localsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localsDataSet = new DemoApp.LocalsDataSet();
            this.localsTableAdapter = new DemoApp.LocalsDataSetTableAdapters.LocalsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(24, 12);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Local", "Local", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.localsBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "Local";
            this.lookUpEdit1.Properties.NullText = "Select local";
            this.lookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit1.TabIndex = 0;
            // 
            // localsBindingSource
            // 
            this.localsBindingSource.DataMember = "Locals";
            this.localsBindingSource.DataSource = this.localsDataSet;
            // 
            // localsDataSet
            // 
            this.localsDataSet.DataSetName = "LocalsDataSet";
            this.localsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localsTableAdapter
            // 
            this.localsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 502);
            this.Controls.Add(this.lookUpEdit1);
            this.Name = "Form1";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private LocalsDataSet localsDataSet;
        private System.Windows.Forms.BindingSource localsBindingSource;
        private LocalsDataSetTableAdapters.LocalsTableAdapter localsTableAdapter;
    }
}

