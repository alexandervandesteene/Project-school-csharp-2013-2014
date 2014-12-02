namespace CSGroep03_2013_2014_
{
    partial class MijnEvents
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
            this.grbEvenementen = new System.Windows.Forms.GroupBox();
            this.lbxMyEvents = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblMaxSubscriptions = new System.Windows.Forms.Label();
            this.lblSubscriptions = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.grbEvenementen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEvenementen
            // 
            this.grbEvenementen.Controls.Add(this.lblOrg);
            this.grbEvenementen.Controls.Add(this.lblMaxSubscriptions);
            this.grbEvenementen.Controls.Add(this.lblSubscriptions);
            this.grbEvenementen.Controls.Add(this.lblEventDate);
            this.grbEvenementen.Controls.Add(this.lblEventName);
            this.grbEvenementen.Controls.Add(this.lbxMyEvents);
            this.grbEvenementen.Location = new System.Drawing.Point(12, 12);
            this.grbEvenementen.Name = "grbEvenementen";
            this.grbEvenementen.Size = new System.Drawing.Size(699, 272);
            this.grbEvenementen.TabIndex = 3;
            this.grbEvenementen.TabStop = false;
            this.grbEvenementen.Text = "Mijn Events";
            // 
            // lbxMyEvents
            // 
            this.lbxMyEvents.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMyEvents.FormattingEnabled = true;
            this.lbxMyEvents.HorizontalScrollbar = true;
            this.lbxMyEvents.ItemHeight = 15;
            this.lbxMyEvents.Location = new System.Drawing.Point(3, 42);
            this.lbxMyEvents.Name = "lbxMyEvents";
            this.lbxMyEvents.Size = new System.Drawing.Size(691, 214);
            this.lbxMyEvents.TabIndex = 0;
            this.lbxMyEvents.Click += new System.EventHandler(this.lbxMyEvents_Click);
            this.lbxMyEvents.DoubleClick += new System.EventHandler(this.lbxMyEvents_DoubleClick);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Enabled = false;
            this.btnVerwijder.Location = new System.Drawing.Point(304, 290);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(101, 28);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Uitschrijven";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Location = new System.Drawing.Point(551, 21);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(61, 13);
            this.lblOrg.TabIndex = 10;
            this.lblOrg.Text = "Organisator";
            // 
            // lblMaxSubscriptions
            // 
            this.lblMaxSubscriptions.Location = new System.Drawing.Point(449, 21);
            this.lblMaxSubscriptions.Name = "lblMaxSubscriptions";
            this.lblMaxSubscriptions.Size = new System.Drawing.Size(82, 16);
            this.lblMaxSubscriptions.TabIndex = 9;
            this.lblMaxSubscriptions.Text = "Max. inschr.";
            // 
            // lblSubscriptions
            // 
            this.lblSubscriptions.Location = new System.Drawing.Point(365, 21);
            this.lblSubscriptions.Name = "lblSubscriptions";
            this.lblSubscriptions.Size = new System.Drawing.Size(87, 16);
            this.lblSubscriptions.TabIndex = 8;
            this.lblSubscriptions.Text = "Aantal inschr.";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(289, 21);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(38, 13);
            this.lblEventDate.TabIndex = 7;
            this.lblEventDate.Text = "Datum";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(6, 21);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(35, 13);
            this.lblEventName.TabIndex = 6;
            this.lblEventName.Text = "Event";
            // 
            // MijnEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 330);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.grbEvenementen);
            this.Name = "MijnEvents";
            this.Text = "MijnEvents";
            this.grbEvenementen.ResumeLayout(false);
            this.grbEvenementen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEvenementen;
        private System.Windows.Forms.ListBox lbxMyEvents;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.Label lblMaxSubscriptions;
        private System.Windows.Forms.Label lblSubscriptions;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventName;

    }
}