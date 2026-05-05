namespace QLNSNew
{
    partial class FrmSearch
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
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.rdbAVL = new System.Windows.Forms.RadioButton();
            this.rdbRB = new System.Windows.Forms.RadioButton();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDemSS = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(414, 98);
            this.txtTraCuu.Multiline = true;
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(474, 57);
            this.txtTraCuu.TabIndex = 0;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(502, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(980, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRA CỨU TỪ ĐIỂN VIỆT-TRUNG THEO CÂY AVL HOẶC ĐỎ ĐEN";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTraCuu.Location = new System.Drawing.Point(894, 98);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(138, 57);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // rdbAVL
            // 
            this.rdbAVL.AutoSize = true;
            this.rdbAVL.Checked = true;
            this.rdbAVL.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAVL.Location = new System.Drawing.Point(1103, 115);
            this.rdbAVL.Name = "rdbAVL";
            this.rdbAVL.Size = new System.Drawing.Size(72, 27);
            this.rdbAVL.TabIndex = 3;
            this.rdbAVL.TabStop = true;
            this.rdbAVL.Text = "AVL";
            this.rdbAVL.UseVisualStyleBackColor = true;
            // 
            // rdbRB
            // 
            this.rdbRB.AutoSize = true;
            this.rdbRB.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRB.Location = new System.Drawing.Point(1256, 115);
            this.rdbRB.Name = "rdbRB";
            this.rdbRB.Size = new System.Drawing.Size(122, 27);
            this.rdbRB.TabIndex = 4;
            this.rdbRB.TabStop = true;
            this.rdbRB.Text = "Red-Black";
            this.rdbRB.UseVisualStyleBackColor = true;
            // 
            // rtbDetail
            // 
            this.rtbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDetail.Location = new System.Drawing.Point(0, 0);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.Size = new System.Drawing.Size(1269, 560);
            this.rtbDetail.TabIndex = 5;
            this.rtbDetail.Text = "";
            // 
            // lstResult
            // 
            this.lstResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 27;
            this.lstResult.Location = new System.Drawing.Point(0, 0);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(394, 560);
            this.lstResult.TabIndex = 6;
            this.lstResult.SelectedIndexChanged += new System.EventHandler(this.lstResult_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDemSS);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTraCuu);
            this.panel1.Controls.Add(this.btnTraCuu);
            this.panel1.Controls.Add(this.rdbRB);
            this.panel1.Controls.Add(this.rdbAVL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1663, 235);
            this.panel1.TabIndex = 7;
            // 
            // lblDemSS
            // 
            this.lblDemSS.AutoSize = true;
            this.lblDemSS.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemSS.Location = new System.Drawing.Point(1132, 196);
            this.lblDemSS.Name = "lblDemSS";
            this.lblDemSS.Size = new System.Drawing.Size(109, 19);
            this.lblDemSS.TabIndex = 7;
            this.lblDemSS.Text = "Số lần so sánh:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1532, 197);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 20);
            this.lblTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1405, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time Search: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 560);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(394, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1269, 560);
            this.panel3.TabIndex = 9;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 795);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearch";
            this.Text = "Tra cứu từ điển Việt-Trung";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.RadioButton rdbAVL;
        private System.Windows.Forms.RadioButton rdbRB;
        private System.Windows.Forms.RichTextBox rtbDetail;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDemSS;
    }
}