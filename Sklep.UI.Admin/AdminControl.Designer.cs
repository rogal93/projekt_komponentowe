namespace Sklep.UI.Admin
{
    partial class AdminControl
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
            this.pracownicyListBox = new System.Windows.Forms.ListBox();
            this.nazwaTxt = new System.Windows.Forms.TextBox();
            this.hasloTxt = new System.Windows.Forms.TextBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.uprawnieniaCombo = new System.Windows.Forms.ComboBox();
            this.edytujBtn = new System.Windows.Forms.Button();
            this.zwolnijBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edycjaBox = new System.Windows.Forms.GroupBox();
            this.edycjaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pracownicyListBox
            // 
            this.pracownicyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pracownicyListBox.ForeColor = System.Drawing.Color.Navy;
            this.pracownicyListBox.FormattingEnabled = true;
            this.pracownicyListBox.ItemHeight = 24;
            this.pracownicyListBox.Location = new System.Drawing.Point(7, 40);
            this.pracownicyListBox.Name = "pracownicyListBox";
            this.pracownicyListBox.Size = new System.Drawing.Size(195, 244);
            this.pracownicyListBox.TabIndex = 1;
            this.pracownicyListBox.SelectedIndexChanged += new System.EventHandler(this.pracownicyListBox_SelectedIndexChanged);
            // 
            // nazwaTxt
            // 
            this.nazwaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaTxt.ForeColor = System.Drawing.Color.Navy;
            this.nazwaTxt.Location = new System.Drawing.Point(91, 23);
            this.nazwaTxt.Name = "nazwaTxt";
            this.nazwaTxt.Size = new System.Drawing.Size(211, 26);
            this.nazwaTxt.TabIndex = 3;
            // 
            // hasloTxt
            // 
            this.hasloTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTxt.ForeColor = System.Drawing.Color.Navy;
            this.hasloTxt.Location = new System.Drawing.Point(91, 55);
            this.hasloTxt.Name = "hasloTxt";
            this.hasloTxt.Size = new System.Drawing.Size(211, 26);
            this.hasloTxt.TabIndex = 4;
            // 
            // mailTxt
            // 
            this.mailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mailTxt.ForeColor = System.Drawing.Color.Navy;
            this.mailTxt.Location = new System.Drawing.Point(91, 87);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(211, 26);
            this.mailTxt.TabIndex = 5;
            // 
            // uprawnieniaCombo
            // 
            this.uprawnieniaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uprawnieniaCombo.ForeColor = System.Drawing.Color.Navy;
            this.uprawnieniaCombo.FormattingEnabled = true;
            this.uprawnieniaCombo.Items.AddRange(new object[] {
            "admin",
            "kierownik",
            "magazynier"});
            this.uprawnieniaCombo.Location = new System.Drawing.Point(91, 119);
            this.uprawnieniaCombo.Name = "uprawnieniaCombo";
            this.uprawnieniaCombo.Size = new System.Drawing.Size(161, 28);
            this.uprawnieniaCombo.TabIndex = 6;
            // 
            // edytujBtn
            // 
            this.edytujBtn.BackColor = System.Drawing.Color.White;
            this.edytujBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujBtn.ForeColor = System.Drawing.Color.Navy;
            this.edytujBtn.Location = new System.Drawing.Point(91, 153);
            this.edytujBtn.Name = "edytujBtn";
            this.edytujBtn.Size = new System.Drawing.Size(112, 38);
            this.edytujBtn.TabIndex = 7;
            this.edytujBtn.Text = "EDYTUJ";
            this.edytujBtn.UseVisualStyleBackColor = false;
            this.edytujBtn.Click += new System.EventHandler(this.edytujBtn_Click);
            // 
            // zwolnijBtn
            // 
            this.zwolnijBtn.BackColor = System.Drawing.Color.White;
            this.zwolnijBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zwolnijBtn.ForeColor = System.Drawing.Color.Navy;
            this.zwolnijBtn.Location = new System.Drawing.Point(42, 290);
            this.zwolnijBtn.Name = "zwolnijBtn";
            this.zwolnijBtn.Size = new System.Drawing.Size(126, 34);
            this.zwolnijBtn.TabIndex = 9;
            this.zwolnijBtn.Text = "ZWOLNIJ";
            this.zwolnijBtn.UseVisualStyleBackColor = false;
            this.zwolnijBtn.Click += new System.EventHandler(this.zwolnijBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(45, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(49, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasło";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(49, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(18, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Uprawnienia";
            // 
            // edycjaBox
            // 
            this.edycjaBox.Controls.Add(this.nazwaTxt);
            this.edycjaBox.Controls.Add(this.label6);
            this.edycjaBox.Controls.Add(this.hasloTxt);
            this.edycjaBox.Controls.Add(this.label5);
            this.edycjaBox.Controls.Add(this.mailTxt);
            this.edycjaBox.Controls.Add(this.label4);
            this.edycjaBox.Controls.Add(this.uprawnieniaCombo);
            this.edycjaBox.Controls.Add(this.label3);
            this.edycjaBox.Controls.Add(this.edytujBtn);
            this.edycjaBox.Enabled = false;
            this.edycjaBox.Location = new System.Drawing.Point(261, 40);
            this.edycjaBox.Name = "edycjaBox";
            this.edycjaBox.Size = new System.Drawing.Size(308, 244);
            this.edycjaBox.TabIndex = 14;
            this.edycjaBox.TabStop = false;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.edycjaBox);
            this.Controls.Add(this.zwolnijBtn);
            this.Controls.Add(this.pracownicyListBox);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(600, 350);
            this.edycjaBox.ResumeLayout(false);
            this.edycjaBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pracownicyListBox;
        private System.Windows.Forms.TextBox nazwaTxt;
        private System.Windows.Forms.TextBox hasloTxt;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.ComboBox uprawnieniaCombo;
        private System.Windows.Forms.Button edytujBtn;
        private System.Windows.Forms.Button zwolnijBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox edycjaBox;
    }
}
