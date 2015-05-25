namespace Sklep.UI.Komunikator
{
    partial class KomunikatorControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.odbiorcaBtn = new System.Windows.Forms.Button();
            this.odbiorcaCombo = new System.Windows.Forms.ComboBox();
            this.przychodzaceTxt = new System.Windows.Forms.RichTextBox();
            this.wysylanieTxt = new System.Windows.Forms.RichTextBox();
            this.wyslijBtn = new System.Windows.Forms.Button();
            this.polaczBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // odbiorcaBtn
            // 
            this.odbiorcaBtn.BackColor = System.Drawing.Color.White;
            this.odbiorcaBtn.Enabled = false;
            this.odbiorcaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odbiorcaBtn.ForeColor = System.Drawing.Color.Navy;
            this.odbiorcaBtn.Location = new System.Drawing.Point(124, 138);
            this.odbiorcaBtn.Name = "odbiorcaBtn";
            this.odbiorcaBtn.Size = new System.Drawing.Size(190, 23);
            this.odbiorcaBtn.TabIndex = 2;
            this.odbiorcaBtn.Text = "Odśwież listę rozmówców";
            this.odbiorcaBtn.UseVisualStyleBackColor = false;
            this.odbiorcaBtn.Click += new System.EventHandler(this.odbiorcaBtn_Click);
            // 
            // odbiorcaCombo
            // 
            this.odbiorcaCombo.Enabled = false;
            this.odbiorcaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odbiorcaCombo.ForeColor = System.Drawing.Color.Navy;
            this.odbiorcaCombo.FormattingEnabled = true;
            this.odbiorcaCombo.Location = new System.Drawing.Point(124, 167);
            this.odbiorcaCombo.Name = "odbiorcaCombo";
            this.odbiorcaCombo.Size = new System.Drawing.Size(190, 28);
            this.odbiorcaCombo.TabIndex = 3;
            this.odbiorcaCombo.Text = "Wybierz rozmówcę";
            this.odbiorcaCombo.SelectedIndexChanged += new System.EventHandler(this.odbiorcaCombo_SelectedIndexChanged);
            // 
            // przychodzaceTxt
            // 
            this.przychodzaceTxt.BackColor = System.Drawing.Color.White;
            this.przychodzaceTxt.ForeColor = System.Drawing.Color.Navy;
            this.przychodzaceTxt.Location = new System.Drawing.Point(320, 51);
            this.przychodzaceTxt.Name = "przychodzaceTxt";
            this.przychodzaceTxt.ReadOnly = true;
            this.przychodzaceTxt.Size = new System.Drawing.Size(365, 205);
            this.przychodzaceTxt.TabIndex = 4;
            this.przychodzaceTxt.Text = "";
            this.przychodzaceTxt.TextChanged += new System.EventHandler(this.przychodzaceTxt_TextChanged);
            // 
            // wysylanieTxt
            // 
            this.wysylanieTxt.Enabled = false;
            this.wysylanieTxt.Location = new System.Drawing.Point(320, 262);
            this.wysylanieTxt.Name = "wysylanieTxt";
            this.wysylanieTxt.Size = new System.Drawing.Size(365, 39);
            this.wysylanieTxt.TabIndex = 5;
            this.wysylanieTxt.Text = "";
            this.wysylanieTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wysylanieTxt_KeyDown);
            // 
            // wyslijBtn
            // 
            this.wyslijBtn.BackColor = System.Drawing.Color.White;
            this.wyslijBtn.Enabled = false;
            this.wyslijBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyslijBtn.ForeColor = System.Drawing.Color.Navy;
            this.wyslijBtn.Location = new System.Drawing.Point(559, 307);
            this.wyslijBtn.Name = "wyslijBtn";
            this.wyslijBtn.Size = new System.Drawing.Size(115, 28);
            this.wyslijBtn.TabIndex = 6;
            this.wyslijBtn.Text = "WYŚLIJ";
            this.wyslijBtn.UseVisualStyleBackColor = false;
            this.wyslijBtn.Click += new System.EventHandler(this.wyslijBtn_Click);
            // 
            // polaczBtn
            // 
            this.polaczBtn.BackColor = System.Drawing.Color.White;
            this.polaczBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polaczBtn.ForeColor = System.Drawing.Color.Navy;
            this.polaczBtn.Location = new System.Drawing.Point(33, 26);
            this.polaczBtn.Name = "polaczBtn";
            this.polaczBtn.Size = new System.Drawing.Size(96, 29);
            this.polaczBtn.TabIndex = 8;
            this.polaczBtn.Text = "POŁĄCZ";
            this.polaczBtn.UseVisualStyleBackColor = false;
            this.polaczBtn.Click += new System.EventHandler(this.polaczBtn_Click);
            // 
            // KomunikatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.polaczBtn);
            this.Controls.Add(this.wyslijBtn);
            this.Controls.Add(this.wysylanieTxt);
            this.Controls.Add(this.przychodzaceTxt);
            this.Controls.Add(this.odbiorcaCombo);
            this.Controls.Add(this.odbiorcaBtn);
            this.Name = "KomunikatorControl";
            this.Size = new System.Drawing.Size(688, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odbiorcaBtn;
        private System.Windows.Forms.ComboBox odbiorcaCombo;
        private System.Windows.Forms.RichTextBox przychodzaceTxt;
        private System.Windows.Forms.RichTextBox wysylanieTxt;
        private System.Windows.Forms.Button wyslijBtn;
        private System.Windows.Forms.Button polaczBtn;
    }
}
