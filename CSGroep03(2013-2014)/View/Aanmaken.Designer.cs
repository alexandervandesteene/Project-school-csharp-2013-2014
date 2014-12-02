namespace CSGroep03_2013_2014_
{
    partial class Aanmaken
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblOrganisator = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtOrganisator = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(18, 29);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(67, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Event naam:";
            // 
            // lblOrganisator
            // 
            this.lblOrganisator.AutoSize = true;
            this.lblOrganisator.Location = new System.Drawing.Point(18, 67);
            this.lblOrganisator.Name = "lblOrganisator";
            this.lblOrganisator.Size = new System.Drawing.Size(64, 13);
            this.lblOrganisator.TabIndex = 1;
            this.lblOrganisator.Text = "Organisator:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(18, 105);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(143, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Maximum aantal deelnemers:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(18, 143);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(88, 26);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(168, 20);
            this.txtNaam.TabIndex = 4;
            // 
            // txtOrganisator
            // 
            this.txtOrganisator.Location = new System.Drawing.Point(88, 64);
            this.txtOrganisator.Name = "txtOrganisator";
            this.txtOrganisator.ReadOnly = true;
            this.txtOrganisator.Size = new System.Drawing.Size(168, 20);
            this.txtOrganisator.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(168, 105);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(88, 20);
            this.txtMax.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Location = new System.Drawing.Point(21, 199);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(75, 23);
            this.btnAanmaken.TabIndex = 8;
            this.btnAanmaken.Text = "Aanmaken";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(181, 199);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleren.TabIndex = 9;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Aanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 248);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtOrganisator);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblOrganisator);
            this.Controls.Add(this.lblNaam);
            this.Name = "Aanmaken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event aanmaken";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblOrganisator;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtOrganisator;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAanmaken;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}