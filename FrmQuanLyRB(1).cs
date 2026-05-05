using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNSNew.Models;

namespace QLNSNew
{
    public partial class FrmQuanLyRB : Form
    {
        public FrmQuanLyRB()
        {
            InitializeComponent();
        }

        private void FrmQuanLyRB_Load(object sender, EventArgs e)
        {
            LoadFileList();
            if(AppData.RBData.Count > 0) LoadGrid();
        }
        private void LoadFileList()
        {
            string folder = Path.Combine(Application.StartupPath, "Data");
            var files = Directory.GetFiles(folder , "*.csv");
            cbFiles.Items.Clear();

            foreach (var file in files)
                cbFiles.Items.Add(Path.GetFileName(file));

            if (cbFiles.Items.Count > 0)
                cbFiles.SelectedIndex = 0;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (cbFiles.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn file!");
                return;
            }

            string file = cbFiles.SelectedItem.ToString();
            string path = Path.Combine(Application.StartupPath, "Data", file);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int countAdded = 0;

            foreach (var line in File.ReadLines(path).Skip(1))
            {
                var parts = line.Split(new[] { ',' }, 5);
                if (parts.Length < 5) continue;

                bool isExist = AppData.RBData.Any(x => x.TiengViet == parts[0]);
                if (isExist) continue;

                Word w = new Word(parts[0], parts[1], parts[2], parts[3]);

                var exList = parts[4].Split(';');
                foreach (var ex in exList)
                {
                    var exParts = ex.Split('|');
                    if (exParts.Length == 3)
                    {
                        w.Examples.Add(new Example
                        {
                            Hanzi = exParts[0],
                            Pinyin = exParts[1],
                            Nghia = exParts[2]
                        });
                    }
                }

                AppData.RB.Insert(w);
                AppData.RBData.Add(w);
                countAdded++;
            }

            sw.Stop();

            LoadGrid();
            int chieuCao = AppData.RB.GetTreeHeight();
            lblChieuCao.Text = $"Chiều cao cây Đỏ-Đen: {chieuCao}";
            MessageBox.Show($"Đã đọc {countAdded} từ!");
            lblTime.Text = $"Load RB: {sw.ElapsedMilliseconds}  ms";

        }
        private void LoadGrid()
        {
            dgvWords.DataSource = null;
            dgvWords.DataSource = AppData.RBData;

            if (dgvWords.Columns.Contains("Examples"))
                dgvWords.Columns["Examples"].Visible = false;

            dgvWords.Columns["TiengViet"].HeaderText = "Tiếng Việt";
            dgvWords.Columns["TiengTrung"].HeaderText = "Tiếng Trung";
            dgvWords.Columns["Pinyin"].HeaderText = "Pinyin";
            dgvWords.Columns["TuLoai"].HeaderText = "Từ loại";

            dgvWords.DefaultCellStyle.Font = new Font("Arial", 11);
            dgvWords.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvWords.RowTemplate.Height = 28;
        }

        private void dgvWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var w = dgvWords.Rows[e.RowIndex].DataBoundItem as Word;
            if (w == null) return;

            txtViet.Text = w.TiengViet;
            txtTrung.Text = w.TiengTrung;
            txtPinyin.Text = w.Pinyin;
            txtTuLoai.Text = w.TuLoai;

            rtbExample.Clear();

            foreach (var ex in w.Examples)
            {
                rtbExample.AppendText(
                    ex.Hanzi + "|" +
                    ex.Pinyin + "|" +
                    ex.Nghia + "\r\n"
                );
            }
        
    }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string keyToDelete = txtViet.Text.Trim();
            if (string.IsNullOrEmpty(keyToDelete))
            {
                MessageBox.Show("Vui lòng chọn từ cần xóa!");
                return;
            }

            // Xác nhận
            if (MessageBox.Show($"Xóa tạm thời từ '{keyToDelete}'?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // 1. Xóa trong cây Red-Black
            AppData.RB.Delete(keyToDelete);

            sw.Stop();

            // 2. Xóa trong danh sách hiển thị
            var item = AppData.RBData.FirstOrDefault(x => x.TiengViet.Equals(keyToDelete, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                AppData.RBData.Remove(item);

                // 3. Cập nhật UI
                LoadGrid();
                lblChieuCao.Text = $"Chiều cao cây Đỏ-Đen: {AppData.RB.GetTreeHeight()}";
                lblTime.Text = $"Delete RB: {sw.ElapsedMilliseconds}  ms";

                MessageBox.Show("Đã xóa tạm thời khỏi bộ nhớ!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ!");
            }
        }
    }
}
