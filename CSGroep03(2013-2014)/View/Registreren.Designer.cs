namespace CSGroep03_2013_2014_
{
    partial class Registreren
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
            this.btnAnnulerenRegistreren = new System.Windows.Forms.Button();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.lblGebruikersnaamRegistreren = new System.Windows.Forms.Label();
            this.lblWachtwoordRegistreren = new System.Windows.Forms.Label();
            this.txtGebruikersnaamRegistreren = new System.Windows.Forms.TextBox();
            this.txtWachtwoordRegistreren = new System.Windows.Forms.TextBox();
            this.errorDuplicatie = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtWachtwoordRegistreren2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorDuplicatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnulerenRegistreren
            // 
            this.btnAnnulerenRegistreren.Location = new System.Drawing.Point(211, 126);
            this.btnAnnulerenRegistreren.Name = "btnAnnulerenRegistreren";
            this.btnAnnulerenRegistreren.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerenRegistreren.TabIndex = 4;
            this.btnAnnulerenRegistreren.Text = "Annuleren";
            this.btnAnnulerenRegistreren.UseVisualStyleBackColor = true;
            this.btnAnnulerenRegistreren.Click += new System.EventHandler(this.btnAnnulerenRegistreren_Click);
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(117, 126);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreren.TabIndex = 3;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // lblGebruikersnaamRegistreren
            // 
            this.lblGebruikersnaamRegistreren.AutoSize = true;
            this.lblGebruikersnaamRegistreren.Location = new System.Drawing.Point(13, 26);
            this.lblGebruikersnaamRegistreren.Name = "lblGebruikersnaamRegistreren";
            this.lblGebruikersnaamRegistreren.Size = new System.Drawing.Size(84, 13);
            this.lblGebruikersnaamRegistreren.TabIndex = 5;
            this.lblGebruikersnaamRegistreren.Text = "Gebruikersnaam";
            // 
            // lblWachtwoordRegistreren
            // 
            this.lblWachtwoordRegistreren.AutoSize = true;
            this.lblWachtwoordRegistreren.Location = new System.Drawing.Point(13, 54);
            this.lblWachtwoordRegistreren.Name = "lblWachtwoordRegistreren";
            this.lblWachtwoordRegistreren.Size = new System.Drawing.Size(68, 13);
            this.lblWachtwoordRegistreren.TabIndex = 6;
            this.lblWachtwoordRegistreren.Text = "Wachtwoord";
            // 
            // txtGebruikersnaamRegistreren
            // 
            this.txtGebruikersnaamRegistreren.Location = new System.Drawing.Point(143, 26);
            this.txtGebruikersnaamRegistreren.Name = "txtGebruikersnaamRegistreren";
            this.txtGebruikersnaamRegistreren.Size = new System.Drawing.Size(169, 20);
            this.txtGebruikersnaamRegistreren.TabIndex = 1;
            this.txtGebruikersnaamRegistreren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGebruikersnaamRegistreren_KeyPress);
            // 
            // txtWachtwoordRegistreren
            // 
            this.txtWachtwoordRegistreren.Location = new System.Drawing.Point(143, 51);
            this.txtWachtwoordRegistreren.Name = "txtWachtwoordRegistreren";
            this.txtWachtwoordRegistreren.PasswordChar = '●';
            this.txtWachtwoordRegistreren.Size = new System.Drawing.Size(169, 20);
            this.txtWachtwoordRegistreren.TabIndex = 2;
            this.txtWachtwoordRegistreren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWachtwoordRegistreren_KeyPress);
            // 
            // errorDuplicatie
            // 
            this.errorDuplicatie.ContainerControl = this;
            // 
            // txtWachtwoordRegistreren2
            // 
            this.txtWachtwoordRegistreren2.Location = new System.Drawing.Point(143, 80);
            this.txtWachtwoordRegistreren2.Name = "txtWachtwoordRegistreren2";
            this.txtWachtwoordRegistreren2.PasswordChar = '●';
            this.txtWachtwoordRegistreren2.Size = new System.Drawing.Size(169, 20);
            this.txtWachtwoordRegistreren2.TabIndex = 7;
            this.txtWachtwoordRegistreren2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWachtwoordRegistreren2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Herhaal Wachtwoord";
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // Registreren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWachtwoordRegistreren2);
            this.Controls.Add(this.txtWachtwoordRegistreren);
            this.Controls.Add(this.txtGebruikersnaamRegistreren);
            this.Controls.Add(this.lblWachtwoordRegistreren);
            this.Controls.Add(this.lblGebruikersnaamRegistreren);
            this.Controls.Add(this.btnRegistreren);
            this.Controls.Add(this.btnAnnulerenRegistreren);
            this.Name = "Registreren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registreren";
            ((System.ComponentModel.ISupportInitialize)(this.errorDuplicatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulerenRegistreren;
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.Label lblGebruikersnaamRegistreren;
        private System.Windows.Forms.Label lblWachtwoordRegistreren;
        private System.Windows.Forms.TextBox txtGebruikersnaamRegistreren;
        private System.Windows.Forms.TextBox txtWachtwoordRegistreren;
        private System.Windows.Forms.ErrorProvider errorDuplicatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWachtwoordRegistreren2;
        private System.Windows.Forms.ErrorProvider errorPassword;
    }
}