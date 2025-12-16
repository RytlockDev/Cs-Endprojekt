namespace Kontoverwaltung
{
    partial class KontoPortal
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
            kundenPortal = new TabControl();
            kontoDetails = new TabPage();
            kontoAuszug = new TabPage();
            kontoUeberweisung = new TabPage();
            kontoDauerauftrag = new TabPage();
            header = new Label();
            btnLogout = new Button();
            kundenPortal.SuspendLayout();
            SuspendLayout();
            // 
            // kundenPortal
            // 
            kundenPortal.Controls.Add(kontoDetails);
            kundenPortal.Controls.Add(kontoAuszug);
            kundenPortal.Controls.Add(kontoUeberweisung);
            kundenPortal.Controls.Add(kontoDauerauftrag);
            kundenPortal.Location = new Point(0, 28);
            kundenPortal.Name = "kundenPortal";
            kundenPortal.SelectedIndex = 0;
            kundenPortal.Size = new Size(800, 421);
            kundenPortal.TabIndex = 6;
            // 
            // kontoDetails
            // 
            kontoDetails.Location = new Point(4, 24);
            kontoDetails.Name = "kontoDetails";
            kontoDetails.Padding = new Padding(3);
            kontoDetails.Size = new Size(792, 393);
            kontoDetails.TabIndex = 0;
            kontoDetails.Text = "Konto Details";
            kontoDetails.UseVisualStyleBackColor = true;
            // 
            // kontoAuszug
            // 
            kontoAuszug.Location = new Point(4, 24);
            kontoAuszug.Name = "kontoAuszug";
            kontoAuszug.Padding = new Padding(3);
            kontoAuszug.Size = new Size(792, 393);
            kontoAuszug.TabIndex = 1;
            kontoAuszug.Text = "Konto Auszug";
            kontoAuszug.UseVisualStyleBackColor = true;
            // 
            // kontoUeberweisung
            // 
            kontoUeberweisung.Location = new Point(4, 24);
            kontoUeberweisung.Name = "kontoUeberweisung";
            kontoUeberweisung.Padding = new Padding(3);
            kontoUeberweisung.Size = new Size(792, 393);
            kontoUeberweisung.TabIndex = 2;
            kontoUeberweisung.Text = "Ueberweisung";
            kontoUeberweisung.UseVisualStyleBackColor = true;
            // 
            // kontoDauerauftrag
            // 
            kontoDauerauftrag.Location = new Point(4, 24);
            kontoDauerauftrag.Name = "kontoDauerauftrag";
            kontoDauerauftrag.Padding = new Padding(3);
            kontoDauerauftrag.Size = new Size(792, 393);
            kontoDauerauftrag.TabIndex = 3;
            kontoDauerauftrag.Text = "Dauerauftrag";
            kontoDauerauftrag.UseVisualStyleBackColor = true;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Location = new Point(4, 9);
            header.Name = "header";
            header.Size = new Size(81, 15);
            header.TabIndex = 7;
            header.Text = "Willkommen: ";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(721, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // KontoPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(header);
            Controls.Add(kundenPortal);
            Name = "KontoPortal";
            Text = "Kontoverwaltung";
            Load += KontoPortal_Load;
            kundenPortal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label meldungen;
        private TabControl kundenPortal;
        private TabPage kontoDauerauftrag;
        private TabPage kontoUeberweisung;
        private TabPage kontoAuszug;
        private TabPage kontoDetails;
        private Label header;
        private Button btnLogout;
    }
}