namespace Sklep.UI.Newsletter
{
    partial class NewsletterControl
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
            this.hasloTxt = new System.Windows.Forms.TextBox();
            this.tematTxt = new System.Windows.Forms.TextBox();
            this.trescTxt = new System.Windows.Forms.RichTextBox();
            this.wyslijBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.adresatLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.odbiorcaCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.allWyslijBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toAllRadio = new System.Windows.Forms.RadioButton();
            this.jedenRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hasloTxt
            // 
            this.hasloTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTxt.ForeColor = System.Drawing.Color.Navy;
            this.hasloTxt.Location = new System.Drawing.Point(58, 234);
            this.hasloTxt.Name = "hasloTxt";
            this.hasloTxt.PasswordChar = '*';
            this.hasloTxt.Size = new System.Drawing.Size(127, 21);
            this.hasloTxt.TabIndex = 1;
            // 
            // tematTxt
            // 
            this.tematTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tematTxt.ForeColor = System.Drawing.Color.Navy;
            this.tematTxt.Location = new System.Drawing.Point(191, 120);
            this.tematTxt.Name = "tematTxt";
            this.tematTxt.Size = new System.Drawing.Size(267, 21);
            this.tematTxt.TabIndex = 3;
            // 
            // trescTxt
            // 
            this.trescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trescTxt.Location = new System.Drawing.Point(191, 149);
            this.trescTxt.Name = "trescTxt";
            this.trescTxt.Size = new System.Drawing.Size(470, 152);
            this.trescTxt.TabIndex = 4;
            this.trescTxt.Text = "";
            // 
            // wyslijBtn
            // 
            this.wyslijBtn.BackColor = System.Drawing.Color.White;
            this.wyslijBtn.Enabled = false;
            this.wyslijBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyslijBtn.ForeColor = System.Drawing.Color.Navy;
            this.wyslijBtn.Location = new System.Drawing.Point(191, 307);
            this.wyslijBtn.Name = "wyslijBtn";
            this.wyslijBtn.Size = new System.Drawing.Size(143, 30);
            this.wyslijBtn.TabIndex = 5;
            this.wyslijBtn.Text = "WYŚLIJ MAILA";
            this.wyslijBtn.UseVisualStyleBackColor = false;
            this.wyslijBtn.Click += new System.EventHandler(this.wyslijBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(32, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasło do poczty elektronicznej";
            // 
            // adresatLabel
            // 
            this.adresatLabel.AutoSize = true;
            this.adresatLabel.ForeColor = System.Drawing.Color.Navy;
            this.adresatLabel.Location = new System.Drawing.Point(145, 46);
            this.adresatLabel.Name = "adresatLabel";
            this.adresatLabel.Size = new System.Drawing.Size(43, 13);
            this.adresatLabel.TabIndex = 8;
            this.adresatLabel.Text = "Adresat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(151, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temat";
            // 
            // odbiorcaCombo
            // 
            this.odbiorcaCombo.BackColor = System.Drawing.Color.White;
            this.odbiorcaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odbiorcaCombo.Enabled = false;
            this.odbiorcaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odbiorcaCombo.ForeColor = System.Drawing.Color.Navy;
            this.odbiorcaCombo.FormattingEnabled = true;
            this.odbiorcaCombo.Location = new System.Drawing.Point(191, 38);
            this.odbiorcaCombo.Name = "odbiorcaCombo";
            this.odbiorcaCombo.Size = new System.Drawing.Size(208, 28);
            this.odbiorcaCombo.TabIndex = 10;
            this.odbiorcaCombo.SelectedIndexChanged += new System.EventHandler(this.odbiorcaCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(151, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Treść";
            // 
            // allWyslijBtn
            // 
            this.allWyslijBtn.BackColor = System.Drawing.Color.White;
            this.allWyslijBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allWyslijBtn.ForeColor = System.Drawing.Color.Navy;
            this.allWyslijBtn.Location = new System.Drawing.Point(61, 278);
            this.allWyslijBtn.Name = "allWyslijBtn";
            this.allWyslijBtn.Size = new System.Drawing.Size(124, 59);
            this.allWyslijBtn.TabIndex = 13;
            this.allWyslijBtn.Text = "WYŚLIJ DO WSZYSTKICH";
            this.allWyslijBtn.UseVisualStyleBackColor = false;
            this.allWyslijBtn.Click += new System.EventHandler(this.allWyslijBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toAllRadio);
            this.groupBox1.Controls.Add(this.jedenRadio);
            this.groupBox1.Location = new System.Drawing.Point(191, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 44);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // toAllRadio
            // 
            this.toAllRadio.AutoSize = true;
            this.toAllRadio.Checked = true;
            this.toAllRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toAllRadio.Location = new System.Drawing.Point(142, 10);
            this.toAllRadio.Name = "toAllRadio";
            this.toAllRadio.Size = new System.Drawing.Size(127, 24);
            this.toAllRadio.TabIndex = 1;
            this.toAllRadio.TabStop = true;
            this.toAllRadio.Text = "Do wszystkich";
            this.toAllRadio.UseVisualStyleBackColor = true;
            this.toAllRadio.CheckedChanged += new System.EventHandler(this.toAllRadio_CheckedChanged);
            // 
            // jedenRadio
            // 
            this.jedenRadio.AutoSize = true;
            this.jedenRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jedenRadio.Location = new System.Drawing.Point(7, 10);
            this.jedenRadio.Name = "jedenRadio";
            this.jedenRadio.Size = new System.Drawing.Size(129, 24);
            this.jedenRadio.TabIndex = 0;
            this.jedenRadio.Text = "Jeden adresat";
            this.jedenRadio.UseVisualStyleBackColor = true;
            this.jedenRadio.CheckedChanged += new System.EventHandler(this.jedenRadio_CheckedChanged);
            // 
            // NewsletterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.allWyslijBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odbiorcaCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adresatLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wyslijBtn);
            this.Controls.Add(this.trescTxt);
            this.Controls.Add(this.tematTxt);
            this.Controls.Add(this.hasloTxt);
            this.Name = "NewsletterControl";
            this.Size = new System.Drawing.Size(688, 350);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hasloTxt;
        private System.Windows.Forms.TextBox tematTxt;
        private System.Windows.Forms.RichTextBox trescTxt;
        private System.Windows.Forms.Button wyslijBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adresatLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button allWyslijBtn;
        public System.Windows.Forms.ComboBox odbiorcaCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton toAllRadio;
        private System.Windows.Forms.RadioButton jedenRadio;
    }
}
