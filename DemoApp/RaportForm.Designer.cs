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
            this.localsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateFrom = new DevExpress.XtraEditors.DateEdit();
            this.DateTo = new DevExpress.XtraEditors.DateEdit();
            this.ConfirmButton = new DevExpress.XtraEditors.SimpleButton();
            this.LocalLabel = new DevExpress.XtraEditors.LabelControl();
            this.DateFromLabel = new DevExpress.XtraEditors.LabelControl();
            this.DateToLabel = new DevExpress.XtraEditors.LabelControl();
            this.RaportGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PrevButton = new DevExpress.XtraEditors.SimpleButton();
            this.NextButton = new DevExpress.XtraEditors.SimpleButton();
            this.PageLabel = new System.Windows.Forms.TextBox();
            this.LocalSelectBox = new DevExpress.XtraEditors.LookUpEdit();
            this.LastPageButton = new DevExpress.XtraEditors.SimpleButton();
            this.FirstPageButton = new DevExpress.XtraEditors.SimpleButton();
            this.ValidationMessage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.localsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaportGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalSelectBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DateFrom
            // 
            this.DateFrom.EditValue = null;
            this.DateFrom.Location = new System.Drawing.Point(24, 94);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFrom.Size = new System.Drawing.Size(100, 20);
            this.DateFrom.TabIndex = 1;
            this.DateFrom.EditValueChanged += new System.EventHandler(this.DateFrom_EditValueChanged);
            // 
            // DateTo
            // 
            this.DateTo.EditValue = null;
            this.DateTo.Location = new System.Drawing.Point(24, 139);
            this.DateTo.Name = "DateTo";
            this.DateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Size = new System.Drawing.Size(100, 20);
            this.DateTo.TabIndex = 2;
            this.DateTo.EditValueChanged += new System.EventHandler(this.DateTo_EditValueChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(24, 467);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(90, 23);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Zatwierdź";
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // LocalLabel
            // 
            this.LocalLabel.Location = new System.Drawing.Point(24, 29);
            this.LocalLabel.Name = "LocalLabel";
            this.LocalLabel.Size = new System.Drawing.Size(24, 13);
            this.LocalLabel.TabIndex = 4;
            this.LocalLabel.Text = "Lokal";
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.Location = new System.Drawing.Point(24, 75);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(38, 13);
            this.DateFromLabel.TabIndex = 5;
            this.DateFromLabel.Text = "Data od";
            // 
            // DateToLabel
            // 
            this.DateToLabel.Location = new System.Drawing.Point(24, 120);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(38, 13);
            this.DateToLabel.TabIndex = 6;
            this.DateToLabel.Text = "Data do";
            // 
            // RaportGrid
            // 
            this.RaportGrid.Location = new System.Drawing.Point(152, 29);
            this.RaportGrid.MainView = this.gridView1;
            this.RaportGrid.Name = "RaportGrid";
            this.RaportGrid.Size = new System.Drawing.Size(773, 432);
            this.RaportGrid.TabIndex = 7;
            this.RaportGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.RaportGrid;
            this.gridView1.Name = "gridView1";
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(353, 467);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 8;
            this.PrevButton.Text = "poprzednia";
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(556, 467);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "następna";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Enabled = false;
            this.PageLabel.Location = new System.Drawing.Point(434, 467);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(116, 21);
            this.PageLabel.TabIndex = 11;
            this.PageLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocalSelectBox
            // 
            this.LocalSelectBox.Location = new System.Drawing.Point(24, 49);
            this.LocalSelectBox.Name = "LocalSelectBox";
            this.LocalSelectBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LocalSelectBox.Size = new System.Drawing.Size(100, 20);
            this.LocalSelectBox.TabIndex = 12;
            this.LocalSelectBox.EditValueChanged += new System.EventHandler(this.LocalSelectBox_EditValueChanged);
            // 
            // LastPageButton
            // 
            this.LastPageButton.Location = new System.Drawing.Point(637, 467);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(75, 23);
            this.LastPageButton.TabIndex = 13;
            this.LastPageButton.Text = "ostatnia";
            this.LastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // FirstPageButton
            // 
            this.FirstPageButton.Location = new System.Drawing.Point(272, 467);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.Size = new System.Drawing.Size(75, 23);
            this.FirstPageButton.TabIndex = 14;
            this.FirstPageButton.Text = "pierwsza";
            this.FirstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // ValidationMessage
            // 
            this.ValidationMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValidationMessage.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ValidationMessage.Appearance.Options.UseFont = true;
            this.ValidationMessage.Appearance.Options.UseForeColor = true;
            this.ValidationMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ValidationMessage.Location = new System.Drawing.Point(152, -3);
            this.ValidationMessage.Name = "ValidationMessage";
            this.ValidationMessage.Size = new System.Drawing.Size(773, 26);
            this.ValidationMessage.TabIndex = 15;
            // 
            // RaportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 502);
            this.Controls.Add(this.ValidationMessage);
            this.Controls.Add(this.FirstPageButton);
            this.Controls.Add(this.LastPageButton);
            this.Controls.Add(this.LocalSelectBox);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.RaportGrid);
            this.Controls.Add(this.DateToLabel);
            this.Controls.Add(this.DateFromLabel);
            this.Controls.Add(this.LocalLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Name = "RaportForm";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaportGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalSelectBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource localsBindingSource;
        private DevExpress.XtraEditors.DateEdit DateFrom;
        private DevExpress.XtraEditors.DateEdit DateTo;
        private DevExpress.XtraEditors.SimpleButton ConfirmButton;
        private DevExpress.XtraEditors.LabelControl LocalLabel;
        private DevExpress.XtraEditors.LabelControl DateFromLabel;
        private DevExpress.XtraEditors.LabelControl DateToLabel;
        private DevExpress.XtraGrid.GridControl RaportGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton PrevButton;
        private DevExpress.XtraEditors.SimpleButton NextButton;
        private System.Windows.Forms.TextBox PageLabel;
        private DevExpress.XtraEditors.LookUpEdit LocalSelectBox;
        private DevExpress.XtraEditors.SimpleButton LastPageButton;
        private DevExpress.XtraEditors.SimpleButton FirstPageButton;
        private DevExpress.XtraEditors.LabelControl ValidationMessage;
    }
}

