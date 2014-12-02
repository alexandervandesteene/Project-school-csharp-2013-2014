namespace CSGroep03_2013_2014_
{
    partial class Info
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
            this.lblEventNaam = new System.Windows.Forms.Label();
            this.lblEventDatum = new System.Windows.Forms.Label();
            this.lblAantalIngeschereven = new System.Windows.Forms.Label();
            this.lblMaxInschrijvingen = new System.Windows.Forms.Label();
            this.Organisator = new System.Windows.Forms.Label();
            this.txtEventNaam = new System.Windows.Forms.TextBox();
            this.txtOrganisator = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnInschrijvenOfUitschrijven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEventNaam
            // 
            this.lblEventNaam.AutoSize = true;
            this.lblEventNaam.Location = new System.Drawing.Point(13, 37);
            this.lblEventNaam.Name = "lblEventNaam";
            this.lblEventNaam.Size = new System.Drawing.Size(38, 13);
            this.lblEventNaam.TabIndex = 0;
            this.lblEventNaam.Text = "Naam:";
            // 
            // lblEventDatum
            // 
            this.lblEventDatum.AutoSize = true;
            this.lblEventDatum.Location = new System.Drawing.Point(12, 66);
            this.lblEventDatum.Name = "lblEventDatum";
            this.lblEventDatum.Size = new System.Drawing.Size(41, 13);
            this.lblEventDatum.TabIndex = 1;
            this.lblEventDatum.Text = "Datum:";
            // 
            // lblAantalIngeschereven
            // 
            this.lblAantalIngeschereven.AutoSize = true;
            this.lblAantalIngeschereven.Location = new System.Drawing.Point(12, 98);
            this.lblAantalIngeschereven.Name = "lblAantalIngeschereven";
            this.lblAantalIngeschereven.Size = new System.Drawing.Size(107, 13);
            this.lblAantalIngeschereven.TabIndex = 2;
            this.lblAantalIngeschereven.Text = "Aantal ingeschreven:";
            // 
            // lblMaxInschrijvingen
            // 
            this.lblMaxInschrijvingen.AutoSize = true;
            this.lblMaxInschrijvingen.Location = new System.Drawing.Point(13, 133);
            this.lblMaxInschrijvingen.Name = "lblMaxInschrijvingen";
            this.lblMaxInschrijvingen.Size = new System.Drawing.Size(153, 13);
            this.lblMaxInschrijvingen.TabIndex = 3;
            this.lblMaxInschrijvingen.Text = "Maximum aantal inschrijvingen:";
            // 
            // Organisator
            // 
            this.Organisator.AutoSize = true;
            this.Organisator.Location = new System.Drawing.Point(13, 161);
            this.Organisator.Name = "Organisator";
            this.Organisator.Size = new System.Drawing.Size(58, 13);
            this.Organisator.TabIndex = 4;
            this.Organisator.Text = "Organistor:";
            // 
            // txtEventNaam
            // 
            this.txtEventNaam.Location = new System.Drawing.Point(57, 34);
            this.txtEventNaam.Name = "txtEventNaam";
            this.txtEventNaam.Size = new System.Drawing.Size(179, 20);
            this.txtEventNaam.TabIndex = 5;
            // 
            // txtOrganisator
            // 
            this.txtOrganisator.Location = new System.Drawing.Point(77, 158);
            this.txtOrganisator.Name = "txtOrganisator";
            this.txtOrganisator.Size = new System.Drawing.Size(159, 20);
            this.txtOrganisator.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(172, 130);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(64, 20);
            this.txtMax.TabIndex = 8;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(125, 95);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(52, 20);
            this.txtAantal.TabIndex = 9;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(57, 60);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(179, 20);
            this.dtpDatum.TabIndex = 10;
            // 
            // btnInschrijvenOfUitschrijven
            // 
            this.btnInschrijvenOfUitschrijven.Location = new System.Drawing.Point(102, 206);
            this.btnInschrijvenOfUitschrijven.Name = "btnInschrijvenOfUitschrijven";
            this.btnInschrijvenOfUitschrijven.Size = new System.Drawing.Size(75, 23);
            this.btnInschrijvenOfUitschrijven.TabIndex = 12;
            this.btnInschrijvenOfUitschrijven.Text = "Inschrijven";
            this.btnInschrijvenOfUitschrijven.UseVisualStyleBackColor = true;
            this.btnInschrijvenOfUitschrijven.Click += new System.EventHandler(this.btnInschrijvenOfUitschrijven_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 243);
            this.Controls.Add(this.btnInschrijvenOfUitschrijven);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtOrganisator);
            this.Controls.Add(this.txtEventNaam);
            this.Controls.Add(this.Organisator);
            this.Controls.Add(this.lblMaxInschrijvingen);
            this.Controls.Add(this.lblAantalIngeschereven);
            this.Controls.Add(this.lblEventDatum);
            this.Controls.Add(this.lblEventNaam);
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventNaam;
        private System.Windows.Forms.Label lblEventDatum;
        private System.Windows.Forms.Label lblAantalIngeschereven;
        private System.Windows.Forms.Label lblMaxInschrijvingen;
        private System.Windows.Forms.Label Organisator;
        private System.Windows.Forms.TextBox txtEventNaam;
        private System.Windows.Forms.TextBox txtOrganisator;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnInschrijvenOfUitschrijven;
    }
}