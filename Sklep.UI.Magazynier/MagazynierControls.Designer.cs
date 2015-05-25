namespace Sklep.UI.Magazynier
{
    partial class MagazynierControls
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pobierzUpDown = new System.Windows.Forms.NumericUpDown();
            this.pobierzBtn = new System.Windows.Forms.Button();
            this.pozostaloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pobierzUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.Navy;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(105, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pobierzUpDown
            // 
            this.pobierzUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pobierzUpDown.Location = new System.Drawing.Point(428, 195);
            this.pobierzUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pobierzUpDown.Name = "pobierzUpDown";
            this.pobierzUpDown.Size = new System.Drawing.Size(128, 38);
            this.pobierzUpDown.TabIndex = 1;
            this.pobierzUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pobierzUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pobierzBtn
            // 
            this.pobierzBtn.BackColor = System.Drawing.Color.White;
            this.pobierzBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pobierzBtn.ForeColor = System.Drawing.Color.Navy;
            this.pobierzBtn.Location = new System.Drawing.Point(428, 251);
            this.pobierzBtn.Name = "pobierzBtn";
            this.pobierzBtn.Size = new System.Drawing.Size(128, 34);
            this.pobierzBtn.TabIndex = 5;
            this.pobierzBtn.Text = "POBIERZ";
            this.pobierzBtn.UseVisualStyleBackColor = false;
            this.pobierzBtn.Click += new System.EventHandler(this.pobierzBtn_Click);
            // 
            // pozostaloLabel
            // 
            this.pozostaloLabel.AutoSize = true;
            this.pozostaloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pozostaloLabel.ForeColor = System.Drawing.Color.Navy;
            this.pozostaloLabel.Location = new System.Drawing.Point(424, 140);
            this.pozostaloLabel.Name = "pozostaloLabel";
            this.pozostaloLabel.Size = new System.Drawing.Size(0, 24);
            this.pozostaloLabel.TabIndex = 6;
            // 
            // MagazynierControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pozostaloLabel);
            this.Controls.Add(this.pobierzBtn);
            this.Controls.Add(this.pobierzUpDown);
            this.Controls.Add(this.listBox1);
            this.Name = "MagazynierControls";
            this.Size = new System.Drawing.Size(688, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pobierzUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown pobierzUpDown;
        private System.Windows.Forms.Button pobierzBtn;
        private System.Windows.Forms.Label pozostaloLabel;
    }
}
