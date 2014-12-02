namespace CSGroep03_2013_2014_
{
    partial class Inloggen
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
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(13, 26);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(84, 13);
            this.lblGebruikersnaam.TabIndex = 0;
            this.lblGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(13, 54);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lblWachtwoord.TabIndex = 1;
            this.lblWachtwoord.Text = "Wachtwoord";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(117, 26);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(169, 20);
            this.txtGebruikersnaam.TabIndex = 2;
            this.txtGebruikersnaam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGebruikersnaam_KeyPress);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(117, 54);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '●';
            this.txtWachtwoord.Size = new System.Drawing.Size(169, 20);
            this.txtWachtwoord.TabIndex = 3;
            this.txtWachtwoord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWachtwoord_KeyPress);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(117, 100);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(75, 23);
            this.btnInloggen.TabIndex = 4;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(211, 100);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleren.TabIndex = 5;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Inloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 135);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Name = "Inloggen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inloggen";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.ErrorProvider error;
    }
}