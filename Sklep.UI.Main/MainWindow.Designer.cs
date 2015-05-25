namespace Sklep.UI.Main
{
    partial class MainWindow
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
            this.panel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.newsletterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komunikatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazynierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kierownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 118);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(688, 350);
            this.panel.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menu.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newsletterToolStripMenuItem,
            this.komunikatorToolStripMenuItem,
            this.magazynierToolStripMenuItem,
            this.kierownikToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(708, 38);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // newsletterToolStripMenuItem
            // 
            this.newsletterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newsletterToolStripMenuItem.Name = "newsletterToolStripMenuItem";
            this.newsletterToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.newsletterToolStripMenuItem.Text = "Newsletter";
            this.newsletterToolStripMenuItem.Click += new System.EventHandler(this.newsletterToolStripMenuItem_Click);
            // 
            // komunikatorToolStripMenuItem
            // 
            this.komunikatorToolStripMenuItem.Name = "komunikatorToolStripMenuItem";
            this.komunikatorToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.komunikatorToolStripMenuItem.Text = "Komunikator";
            this.komunikatorToolStripMenuItem.Click += new System.EventHandler(this.komunikatorToolStripMenuItem_Click);
            // 
            // magazynierToolStripMenuItem
            // 
            this.magazynierToolStripMenuItem.Name = "magazynierToolStripMenuItem";
            this.magazynierToolStripMenuItem.Size = new System.Drawing.Size(136, 34);
            this.magazynierToolStripMenuItem.Text = "Magazynier";
            this.magazynierToolStripMenuItem.Click += new System.EventHandler(this.magazynierToolStripMenuItem_Click);
            // 
            // kierownikToolStripMenuItem
            // 
            this.kierownikToolStripMenuItem.Name = "kierownikToolStripMenuItem";
            this.kierownikToolStripMenuItem.Size = new System.Drawing.Size(119, 34);
            this.kierownikToolStripMenuItem.Text = "Kierownik";
            this.kierownikToolStripMenuItem.Click += new System.EventHandler(this.kierownikToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // wylogujBtn
            // 
            this.wylogujBtn.BackColor = System.Drawing.Color.White;
            this.wylogujBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wylogujBtn.ForeColor = System.Drawing.Color.Navy;
            this.wylogujBtn.Location = new System.Drawing.Point(12, 474);
            this.wylogujBtn.Name = "wylogujBtn";
            this.wylogujBtn.Size = new System.Drawing.Size(133, 25);
            this.wylogujBtn.TabIndex = 2;
            this.wylogujBtn.Text = "WYLOGUJ";
            this.wylogujBtn.UseVisualStyleBackColor = false;
            this.wylogujBtn.Visible = false;
            this.wylogujBtn.Click += new System.EventHandler(this.wylogujBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Magazyn sklepu";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.ForeColor = System.Drawing.Color.Navy;
            this.exitBtn.Location = new System.Drawing.Point(538, 474);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(162, 25);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "ZAMKNIJ PROGRAM";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 506);
            this.Controls.Add(this.wylogujBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem newsletterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komunikatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazynierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kierownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.Button wylogujBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
    }
}

