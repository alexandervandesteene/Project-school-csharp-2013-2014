namespace CSGroep03_2013_2014_
{
    partial class RapportMijnEvents
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVolgen = new System.Windows.Forms.TabPage();
            this.tabOrganiseren = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cSGroep03DataSet = new CSGroep03_2013_2014_.Model.CSGroep03DataSet();
            this.eventsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsListTableAdapter = new CSGroep03_2013_2014_.Model.CSGroep03DataSetTableAdapters.EventsListTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eventOrganisatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventOrganisatorTableAdapter = new CSGroep03_2013_2014_.Model.CSGroep03DataSetTableAdapters.EventOrganisatorTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabVolgen.SuspendLayout();
            this.tabOrganiseren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep03DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventOrganisatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVolgen);
            this.tabControl1.Controls.Add(this.tabOrganiseren);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVolgen
            // 
            this.tabVolgen.Controls.Add(this.reportViewer1);
            this.tabVolgen.Location = new System.Drawing.Point(4, 22);
            this.tabVolgen.Name = "tabVolgen";
            this.tabVolgen.Padding = new System.Windows.Forms.Padding(3);
            this.tabVolgen.Size = new System.Drawing.Size(764, 279);
            this.tabVolgen.TabIndex = 0;
            this.tabVolgen.Text = "tabPage1";
            this.tabVolgen.UseVisualStyleBackColor = true;
            // 
            // tabOrganiseren
            // 
            this.tabOrganiseren.Controls.Add(this.reportViewer2);
            this.tabOrganiseren.Location = new System.Drawing.Point(4, 22);
            this.tabOrganiseren.Name = "tabOrganiseren";
            this.tabOrganiseren.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrganiseren.Size = new System.Drawing.Size(764, 279);
            this.tabOrganiseren.TabIndex = 1;
            this.tabOrganiseren.Text = "tabPage2";
            this.tabOrganiseren.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RDSEventsDieGebruikersVolgt";
            reportDataSource1.Value = this.eventsListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSGroep03_2013_2014_.Rapporten.EventsDieGebruikersVolgt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(758, 273);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cSGroep03DataSet
            // 
            this.cSGroep03DataSet.DataSetName = "CSGroep03DataSet";
            this.cSGroep03DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsListBindingSource
            // 
            this.eventsListBindingSource.DataMember = "EventsList";
            this.eventsListBindingSource.DataSource = this.cSGroep03DataSet;
            // 
            // eventsListTableAdapter
            // 
            this.eventsListTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "RDSEventsDieGebruikerOrganiseert";
            reportDataSource2.Value = this.eventOrganisatorBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CSGroep03_2013_2014_.Rapporten.EventsDieGebruikerOrganiseert.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(758, 273);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // eventOrganisatorBindingSource
            // 
            this.eventOrganisatorBindingSource.DataMember = "EventOrganisator";
            this.eventOrganisatorBindingSource.DataSource = this.cSGroep03DataSet;
            // 
            // eventOrganisatorTableAdapter
            // 
            this.eventOrganisatorTableAdapter.ClearBeforeFill = true;
            // 
            // RapportMijnEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 305);
            this.Controls.Add(this.tabControl1);
            this.Name = "RapportMijnEvents";
            this.Text = "RapportMijnEvents";
            this.tabControl1.ResumeLayout(false);
            this.tabVolgen.ResumeLayout(false);
            this.tabOrganiseren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cSGroep03DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventOrganisatorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVolgen;
        private System.Windows.Forms.TabPage tabOrganiseren;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Model.CSGroep03DataSet cSGroep03DataSet;
        private System.Windows.Forms.BindingSource eventsListBindingSource;
        private Model.CSGroep03DataSetTableAdapters.EventsListTableAdapter eventsListTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource eventOrganisatorBindingSource;
        private Model.CSGroep03DataSetTableAdapters.EventOrganisatorTableAdapter eventOrganisatorTableAdapter;
    }
}