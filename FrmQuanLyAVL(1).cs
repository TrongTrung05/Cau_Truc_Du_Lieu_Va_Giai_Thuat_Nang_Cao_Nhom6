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
using QLNSNew.DataStructures.AVL;
using QLNSNew.Models;

namespace QLNSNew
{
    public partial class FrmQuanLyAVL : Form
    {
        public FrmQuanLyAVL()
        {
            InitializeComponent();
        }
        
        private void FrmQuanLyAVL_Load(object sender, EventArgs e)
        {
            LoadFileList();
            if (AppData.AVLData.Count > 0) LoadGrid();

        }
        private void LoadFileList()
        {
            string folder = Path.Combine(Application.StartupPath, "Data");

            var files = Directory.GetFiles(folder, "*.csv");

            cbFiles.Items.Clear();

            foreach (var file in files)
            {
                cbFiles.Items.Add(Path.GetFileName(file));
            }

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

            // --- QUAN TRỌNG: KHÔNG khởi tạo lại AppData.AVL và KHÔNG Clear AppData.AVLData ---
            // Việc này giúp giữ lại dữ liệu cũ đã đọc từ các file trước đó.

            string file = cbFiles.SelectedItem.ToString();
            string path = Path.Combine(Application.StartupPath, "Data", file);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int countAdded = 0; // Đếm số từ mới được thêm vào

            try
            {
                foreach (var line in File.ReadLines(path).Skip(1))
                {
                    var parts = line.Split(new[] { ',' }, 5);
                    if (parts.Length < 5) continue;

                    // Kiểm tra xem từ này đã tồn tại trong danh sách chưa để tránh trùng lặp
                    // Nếu bạn muốn cho phép trùng thì bỏ qua bước kiểm tra này
                    bool isExist = AppData.AVLData.Any(x => x.TiengViet == parts[0]);
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

                    // Chèn thêm vào cấu trúc đang có sẵn
                    AppData.AVL.Insert(w);
                    AppData.AVLData.Add(w);
                    countAdded++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }

            sw.Stop();
            LoadGrid(); // Cập nhật lại Grid hiển thị toàn bộ dữ liệu (cũ + mới)
            int treeHeight = AppData.AVL.GetTreeHeight();
            lblChieuCao.Text = $"Chiều cao cây AVL: {treeHeight}";
            MessageBox.Show($"Đã đọc thêm thành công {countAdded} từ mới từ file {file}!");
            lblTime.Text = $"Load AVL: {sw.ElapsedMilliseconds} ms";
        }
        private void LoadGrid()
        {
            dgvWords.DataSource = null;
            dgvWords.DataSource = AppData.AVLData;

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

        
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            Word w = new Word(
                  txtViet.Text,
                  txtTrung.Text,
                  txtPinyin.Text,
                   txtTuLoai.Text
             );

            w.Examples = GetExamplesFromInput();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            AppData.AVL.Insert(w);

            sw.Stop();

            AppData.AVLData.Add(w);
            LoadGrid();

            lblTime.Text = $"Insert AVL: {sw.ElapsedMilliseconds} ms";
        }
        private List<Example> GetExamplesFromInput()
        {
            List<Example> list = new List<Example>();

            var lines = rtbExample.Text.Split('\n');

            foreach (var line in lines)
            {
                var clean = line.Trim();

                if (string.IsNullOrEmpty(clean))
                    continue;

                var parts = clean.Split('|');

                if (parts.Length == 3)
                {
                    list.Add(new Example
                    {
                        Hanzi = parts[0].Trim(),
                        Pinyin = parts[1].Trim(),
                        Nghia = parts[2].Trim()
                    });
                }
            }

            return list;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Lấy từ khóa (Tiếng Việt) hiện tại từ TextBox
            string targetKey = txtViet.Text.Trim();

            if (string.IsNullOrEmpty(targetKey))
            {
                MessageBox.Show("Vui lòng chọn từ cần sửa từ danh sách!");
                return;
            }

            // 2. Tìm đối tượng cũ trong List (AppData.AVLData)
            var oldWord = AppData.AVLData.FirstOrDefault(x => x.TiengViet.Equals(targetKey, StringComparison.OrdinalIgnoreCase));

            if (oldWord != null)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                // --- BƯỚC QUAN TRỌNG: Xử lý trên RAM ---

                // A. Xóa nút cũ khỏi cây AVL để tránh trùng lặp hoặc sai vị trí sắp xếp
                AppData.AVL.Delete(targetKey);

                // B. Xóa khỏi List hiển thị
                AppData.AVLData.Remove(oldWord);

                // C. Tạo đối tượng Word mới với dữ liệu đã cập nhật từ giao diện
                Word updatedWord = new Word(
                    txtViet.Text.Trim(),
                    txtTrung.Text.Trim(),
                    txtPinyin.Text.Trim(),
                    txtTuLoai.Text.Trim()
                );
                updatedWord.Examples = GetExamplesFromInput();

                // D. Chèn lại vào Cây AVL (để cây tự cân bằng lại vị trí mới)
                AppData.AVL.Insert(updatedWord);

                // E. Thêm lại vào List hiển thị
                AppData.AVLData.Add(updatedWord);

                sw.Stop();

                // 3. Cập nhật giao diện người dùng
                LoadGrid();

                lblChieuCao.Text = $"Chiều cao cây AVL: {AppData.AVL.GetTreeHeight()}";
                lblTime.Text = $"Sửa tạm thời mất: {sw.ElapsedMilliseconds}  ms";

                MessageBox.Show($"Đã cập nhật tạm thời từ '{targetKey}'. Dữ liệu file gốc không đổi.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ này trong bộ nhớ để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string keyToDelete = txtViet.Text.Trim();
            if (string.IsNullOrEmpty(keyToDelete))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập từ Tiếng Việt cần xóa!");
                return;
            }
            var confirmResult = MessageBox.Show($"Bạn có chắc muốn xóa từ '{keyToDelete}' khỏi danh sách tạm thời?",
                                     "Xác nhận xóa",
                                     MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            AppData.AVL.Delete(keyToDelete);
            sw.Stop();
            var itemInList = AppData.AVLData.FirstOrDefault(x => x.TiengViet.Equals(keyToDelete, StringComparison.OrdinalIgnoreCase));
            if (itemInList != null)
            {
                AppData.AVLData.Remove(itemInList);

                // 3. Cập nhật giao diện
                LoadGrid();

                // Cập nhật thông số cây
                int treeHeight = AppData.AVL.GetTreeHeight();
                lblChieuCao.Text = $"Chiều cao cây AVL: {treeHeight}";
                lblTime.Text = $"Xóa AVL mất: {sw.ElapsedMilliseconds}  ms"; // Dùng ticks vì xóa cực nhanh

                MessageBox.Show($"Đã xóa tạm thời từ '{keyToDelete}'. Dữ liệu trong file CSV vẫn được giữ nguyên.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ này trong danh sách hiện tại!");
            }

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
    }
}
