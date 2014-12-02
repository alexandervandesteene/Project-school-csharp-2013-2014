namespace CSGroep03_2013_2014_
{
    partial class RapportInfo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.eventsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSGroep03DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSGroep03DataSet = new CSGroep03_2013_2014_.Model.CSGroep03DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eventsListTableAdapter = new CSGroep03_2013_2014_.Model.CSGroep03DataSetTableAdapters.EventsListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep03DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep03DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsListBindingSource
            // 
            this.eventsListBindingSource.DataMember = "EventsList";
            this.eventsListBindingSource.DataSource = this.cSGroep03DataSetBindingSource;
            // 
            // cSGroep03DataSetBindingSource
            // 
            this.cSGroep03DataSetBindingSource.DataSource = this.cSGroep03DataSet;
            this.cSGroep03DataSetBindingSource.Position = 0;
            // 
            // cSGroep03DataSet
            // 
            this.cSGroep03DataSet.DataSetName = "CSGroep03DataSet";
            this.cSGroep03DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RDSEventsList";
            reportDataSource1.Value = this.eventsListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSGroep03_2013_2014_.Rapporten.AlleEvents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(652, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // eventsListTableAdapter
            // 
            this.eventsListTableAdapter.ClearBeforeFill = true;
            // 
            // RapportInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RapportInfo";
            this.Text = "RapportInfo";
            this.Load += new System.EventHandler(this.RapportInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep03DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep03DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Model.CSGroep03DataSet cSGroep03DataSet;
        private System.Windows.Forms.BindingSource cSGroep03DataSetBindingSource;
        private System.Windows.Forms.BindingSource eventsListBindingSource;
        private Model.CSGroep03DataSetTableAdapters.EventsListTableAdapter eventsListTableAdapter;
    }
}