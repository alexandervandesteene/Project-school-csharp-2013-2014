namespace CSGroep03_2013_2014_
{
    partial class WachtwoordWijzigen
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
            this.lblOudWachtwoord = new System.Windows.Forms.Label();
            this.lblNieuwWachtwoord = new System.Windows.Forms.Label();
            this.lblNieuwWachtwoord2 = new System.Windows.Forms.Label();
            this.txtOudWachtwoord = new System.Windows.Forms.TextBox();
            this.txtNieuwWachtwoord = new System.Windows.Forms.TextBox();
            this.txtNieuwWachtwoord2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorOudWachtwoord = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNieuwWachtwoord = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorOudWachtwoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNieuwWachtwoord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOudWachtwoord
            // 
            this.lblOudWachtwoord.AutoSize = true;
            this.lblOudWachtwoord.Location = new System.Drawing.Point(35, 38);
            this.lblOudWachtwoord.Name = "lblOudWachtwoord";
            this.lblOudWachtwoord.Size = new System.Drawing.Size(88, 13);
            this.lblOudWachtwoord.TabIndex = 0;
            this.lblOudWachtwoord.Text = "Oud wachtwoord";
            // 
            // lblNieuwWachtwoord
            // 
            this.lblNieuwWachtwoord.AutoSize = true;
            this.lblNieuwWachtwoord.Location = new System.Drawing.Point(35, 80);
            this.lblNieuwWachtwoord.Name = "lblNieuwWachtwoord";
            this.lblNieuwWachtwoord.Size = new System.Drawing.Size(98, 13);
            this.lblNieuwWachtwoord.TabIndex = 1;
            this.lblNieuwWachtwoord.Text = "Nieuw wachtwoord";
            // 
            // lblNieuwWachtwoord2
            // 
            this.lblNieuwWachtwoord2.AutoSize = true;
            this.lblNieuwWachtwoord2.Location = new System.Drawing.Point(35, 124);
            this.lblNieuwWachtwoord2.Name = "lblNieuwWachtwoord2";
            this.lblNieuwWachtwoord2.Size = new System.Drawing.Size(98, 13);
            this.lblNieuwWachtwoord2.TabIndex = 2;
            this.lblNieuwWachtwoord2.Text = "Nieuw wachtwoord";
            // 
            // txtOudWachtwoord
            // 
            this.txtOudWachtwoord.Location = new System.Drawing.Point(139, 35);
            this.txtOudWachtwoord.Name = "txtOudWachtwoord";
            this.txtOudWachtwoord.Size = new System.Drawing.Size(150, 20);
            this.txtOudWachtwoord.TabIndex = 3;
            // 
            // txtNieuwWachtwoord
            // 
            this.txtNieuwWachtwoord.Location = new System.Drawing.Point(139, 77);
            this.txtNieuwWachtwoord.Name = "txtNieuwWachtwoord";
            this.txtNieuwWachtwoord.Size = new System.Drawing.Size(150, 20);
            this.txtNieuwWachtwoord.TabIndex = 4;
            // 
            // txtNieuwWachtwoord2
            // 
            this.txtNieuwWachtwoord2.Location = new System.Drawing.Point(139, 121);
            this.txtNieuwWachtwoord2.Name = "txtNieuwWachtwoord2";
            this.txtNieuwWachtwoord2.Size = new System.Drawing.Size(150, 20);
            this.txtNieuwWachtwoord2.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(38, 191);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorOudWachtwoord
            // 
            this.errorOudWachtwoord.ContainerControl = this;
            // 
            // errorNieuwWachtwoord
            // 
            this.errorNieuwWachtwoord.ContainerControl = this;
            // 
            // WachtwoordWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 234);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNieuwWachtwoord2);
            this.Controls.Add(this.txtNieuwWachtwoord);
            this.Controls.Add(this.txtOudWachtwoord);
            this.Controls.Add(this.lblNieuwWachtwoord2);
            this.Controls.Add(this.lblNieuwWachtwoord);
            this.Controls.Add(this.lblOudWachtwoord);
            this.Name = "WachtwoordWijzigen";
            this.Text = "WachtwoordWijzigen";
            ((System.ComponentModel.ISupportInitialize)(this.errorOudWachtwoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNieuwWachtwoord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOudWachtwoord;
        private System.Windows.Forms.Label lblNieuwWachtwoord;
        private System.Windows.Forms.Label lblNieuwWachtwoord2;
        private System.Windows.Forms.TextBox txtOudWachtwoord;
        private System.Windows.Forms.TextBox txtNieuwWachtwoord;
        private System.Windows.Forms.TextBox txtNieuwWachtwoord2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorOudWachtwoord;
        private System.Windows.Forms.ErrorProvider errorNieuwWachtwoord;
    }
}