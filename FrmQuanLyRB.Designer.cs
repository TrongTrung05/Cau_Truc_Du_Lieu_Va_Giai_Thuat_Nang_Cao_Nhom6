namespace QLNSNew
{
    partial class FrmQuanLyRB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyRB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.cbFiles = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTuLoai = new System.Windows.Forms.TextBox();
            this.txtPinyin = new System.Windows.Forms.TextBox();
            this.txtTrung = new System.Windows.Forms.TextBox();
            this.lblTuloai = new System.Windows.Forms.Label();
            this.lblPinYin = new System.Windows.Forms.Label();
            this.lblTiengTrung = new System.Windows.Forms.Label();
            this.txtViet = new System.Windows.Forms.TextBox();
            this.rtbExample = new System.Windows.Forms.RichTextBox();
            this.lblTiengViet = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblChieuCao);
            this.panel1.Controls.Add(this.cbFiles);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.txtTuLoai);
            this.panel1.Controls.Add(this.txtPinyin);
            this.panel1.Controls.Add(this.txtTrung);
            this.panel1.Controls.Add(this.lblTuloai);
            this.panel1.Controls.Add(this.lblPinYin);
            this.panel1.Controls.Add(this.lblTiengTrung);
            this.panel1.Controls.Add(this.txtViet);
            this.panel1.Controls.Add(this.rtbExample);
            this.panel1.Controls.Add(this.lblTiengViet);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnLoadFile);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1891, 514);
            this.panel1.TabIndex = 1;
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location = new System.Drawing.Point(798, 470);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Size = new System.Drawing.Size(116, 20);
            this.lblChieuCao.TabIndex = 48;
            this.lblChieuCao.Text = "Chiều cao cây: ";
            // 
            // cbFiles
            // 
            this.cbFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFiles.FormattingEnabled = true;
            this.cbFiles.Location = new System.Drawing.Point(298, 367);
            this.cbFiles.Name = "cbFiles";
            this.cbFiles.Size = new System.Drawing.Size(182, 28);
            this.cbFiles.TabIndex = 46;
            this.cbFiles.Text = "choose file";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1051, 470);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 45;
            this.lblTime.Text = "Time";
            // 
            // txtTuLoai
            // 
            this.txtTuLoai.Location = new System.Drawing.Point(964, 224);
            this.txtTuLoai.Name = "txtTuLoai";
            this.txtTuLoai.Size = new System.Drawing.Size(279, 26);
            this.txtTuLoai.TabIndex = 44;
            // 
            // txtPinyin
            // 
            this.txtPinyin.Location = new System.Drawing.Point(964, 100);
            this.txtPinyin.Name = "txtPinyin";
            this.txtPinyin.Size = new System.Drawing.Size(279, 26);
            this.txtPinyin.TabIndex = 43;
            // 
            // txtTrung
            // 
            this.txtTrung.Location = new System.Drawing.Point(406, 223);
            this.txtTrung.Name = "txtTrung";
            this.txtTrung.Size = new System.Drawing.Size(279, 26);
            this.txtTrung.TabIndex = 42;
            // 
            // lblTuloai
            // 
            this.lblTuloai.AutoSize = true;
            this.lblTuloai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuloai.Location = new System.Drawing.Point(809, 225);
            this.lblTuloai.Name = "lblTuloai";
            this.lblTuloai.Size = new System.Drawing.Size(78, 23);
            this.lblTuloai.TabIndex = 41;
            this.lblTuloai.Text = "Từ Loại";
            // 
            // lblPinYin
            // 
            this.lblPinYin.AutoSize = true;
            this.lblPinYin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinYin.Location = new System.Drawing.Point(809, 101);
            this.lblPinYin.Name = "lblPinYin";
            this.lblPinYin.Size = new System.Drawing.Size(64, 23);
            this.lblPinYin.TabIndex = 40;
            this.lblPinYin.Text = "PinYin";
            // 
            // lblTiengTrung
            // 
            this.lblTiengTrung.AutoSize = true;
            this.lblTiengTrung.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiengTrung.Location = new System.Drawing.Point(227, 224);
            this.lblTiengTrung.Name = "lblTiengTrung";
            this.lblTiengTrung.Size = new System.Drawing.Size(113, 23);
            this.lblTiengTrung.TabIndex = 39;
            this.lblTiengTrung.Text = "Tiếng Trung";
            // 
            // txtViet
            // 
            this.txtViet.Location = new System.Drawing.Point(406, 99);
            this.txtViet.Name = "txtViet";
            this.txtViet.Size = new System.Drawing.Size(279, 26);
            this.txtViet.TabIndex = 38;
            // 
            // rtbExample
            // 
            this.rtbExample.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbExample.Location = new System.Drawing.Point(1550, 0);
            this.rtbExample.Name = "rtbExample";
            this.rtbExample.Size = new System.Drawing.Size(341, 514);
            this.rtbExample.TabIndex = 37;
            this.rtbExample.Text = "";
            // 
            // lblTiengViet
            // 
            this.lblTiengViet.AutoSize = true;
            this.lblTiengViet.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiengViet.Location = new System.Drawing.Point(227, 99);
            this.lblTiengViet.Name = "lblTiengViet";
            this.lblTiengViet.Size = new System.Drawing.Size(98, 23);
            this.lblTiengViet.TabIndex = 36;
            this.lblTiengViet.Text = "Tiếng Việt";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(97)))), ((int)(((byte)(213)))));
            this.lblTitle.Location = new System.Drawing.Point(672, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(574, 45);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "QUẢN LÝ TỪ ĐIỂN THEO RB";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(97)))), ((int)(((byte)(213)))));
            this.btnLoadFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadFile.Image")));
            this.btnLoadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadFile.Location = new System.Drawing.Point(106, 348);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLoadFile.Size = new System.Drawing.Size(154, 65);
            this.btnLoadFile.TabIndex = 34;
            this.btnLoadFile.Text = "     LoadFile";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(97)))), ((int)(((byte)(213)))));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1157, 348);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(154, 65);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(97)))), ((int)(((byte)(213)))));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(845, 348);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(154, 65);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(97)))), ((int)(((byte)(213)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(525, 348);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(154, 65);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "       Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvWords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1891, 236);
            this.panel2.TabIndex = 2;
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToAddRows = false;
            this.dgvWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWords.Location = new System.Drawing.Point(0, 0);
            this.dgvWords.MultiSelect = false;
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.ReadOnly = true;
            this.dgvWords.RowHeadersWidth = 62;
            this.dgvWords.RowTemplate.Height = 28;
            this.dgvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWords.Size = new System.Drawing.Size(1891, 236);
            this.dgvWords.TabIndex = 0;
            this.dgvWords.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWords_CellEnter);
            // 
            // FrmQuanLyRB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1891, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuanLyRB";
            this.Text = "Quản lý từ điển theo Red-Black";
            this.Load += new System.EventHandler(this.FrmQuanLyRB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFiles;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTuLoai;
        private System.Windows.Forms.TextBox txtPinyin;
        private System.Windows.Forms.TextBox txtTrung;
        private System.Windows.Forms.Label lblTuloai;
        private System.Windows.Forms.Label lblPinYin;
        private System.Windows.Forms.Label lblTiengTrung;
        private System.Windows.Forms.TextBox txtViet;
        private System.Windows.Forms.RichTextBox rtbExample;
        private System.Windows.Forms.Label lblTiengViet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.Label lblChieuCao;
    }
}