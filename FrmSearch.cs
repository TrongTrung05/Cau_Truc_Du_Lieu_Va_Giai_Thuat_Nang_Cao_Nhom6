using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;
using QLNSNew.DataStructures.AVL;
using QLNSNew.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLNSNew
{
    public partial class FrmSearch : Form
    {
       
        public FrmSearch()
        {
            InitializeComponent();
        }
        private void FrmSearch_Load(object sender, EventArgs e)

        {
            if (AppData.AVL == null || AppData.AVLData.Count == 0)
            {
                MessageBox.Show("Dữ liệu hiện đang trống. Vui lòng vào mục Quản lý để Load file trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTraCuu.Text.Trim().ToLower();

            lstResult.Items.Clear();
            if (string.IsNullOrEmpty(keyword))
            {
                return;
            }
            List<Word> list = new List<Word>();

            if (rdbAVL.Checked)
            {
                list = AppData.AVL.SearchPrefix(keyword);
            }
            else if (rdbRB.Checked)
            {
                list = AppData.RB.SearchPrefix(keyword);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại cây!");
                return;
            }
            foreach (Word word in list)
            {
                lstResult.Items.Add(word);
            }

        }

        private void ShowWordDetail(Word w)
        {
            rtbDetail.Clear();

            // ===== TIẾNG TRUNG =====
            rtbDetail.SelectionFont = new Font("Arial", 18, FontStyle.Bold);
            rtbDetail.SelectionColor = Color.Black;
            rtbDetail.AppendText(w.TiengTrung + "\n");

            // ===== PINYIN =====
            rtbDetail.SelectionFont = new Font("Arial", 13, FontStyle.Italic);
            rtbDetail.SelectionColor = Color.Blue;
            rtbDetail.AppendText(w.Pinyin + "\n");

            // ===== NGHĨA =====
            rtbDetail.SelectionFont = new Font("Arial", 13, FontStyle.Regular);
            rtbDetail.SelectionColor = Color.Black;
            rtbDetail.AppendText("→ " + w.TiengViet + "\n");

            // ===== TỪ LOẠI =====
            rtbDetail.SelectionFont = new Font("Arial", 11, FontStyle.Italic);
            rtbDetail.SelectionColor = Color.Gray;
            rtbDetail.AppendText("(" + w.TuLoai + ")\n\n");

            // ===== VÍ DỤ =====
            rtbDetail.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
            rtbDetail.SelectionColor = Color.DarkGreen;
            rtbDetail.AppendText("Ví dụ:\n\n");

            foreach (var ex in w.Examples)
            {
                // Trung
                rtbDetail.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
                rtbDetail.SelectionColor = Color.Black;
                rtbDetail.AppendText(ex.Hanzi + "\n");

                // Pinyin
                rtbDetail.SelectionFont = new Font("Arial", 11, FontStyle.Italic);
                rtbDetail.SelectionColor = Color.Blue;
                rtbDetail.AppendText(ex.Pinyin + "\n");

                // Nghĩa
                rtbDetail.SelectionFont = new Font("Arial", 11, FontStyle.Regular);
                rtbDetail.SelectionColor = Color.Black;
                rtbDetail.AppendText("→ " + ex.Nghia + "\n\n");
            }
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResult.SelectedItem == null) return;

            Word selected = (Word)lstResult.SelectedItem;
            Stopwatch sw = new Stopwatch();
            Word w = null;
            int count = 0;

            if (rdbAVL.Checked)
            {
                sw.Start();
                // Gọi hàm Search có tham số out để đếm bước nhảy
                w = AppData.AVL.Search(selected.TiengViet.ToLower(), out count);
                sw.Stop();

                lblTime.Text = $"AVL Search: {sw.ElapsedTicks}  ticks";
                lblDemSS.Text = $"Số lần so sánh: {count}";
            }
            else if (rdbRB.Checked)
            {
                sw.Start();
                // Đảm bảo bạn đã sửa hàm Search trong class RedBlackTree để có tham số out count tương tự AVL
                w = AppData.RB.Search(selected.TiengViet.ToLower() , out count);
                sw.Stop();

                lblTime.Text = $"RB Search: {sw.ElapsedTicks}  ticks";
                lblDemSS.Text = $"Số lần so sánh: {count}";
            }

            if (w != null)
            {
                ShowWordDetail(w);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string keyword = txtTraCuu.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ cần tìm!");
                return;
            }

            // 1. Xóa danh sách cũ và lấy danh sách gợi ý mới
            lstResult.Items.Clear();
            List<Word> list = new List<Word>();

            if (rdbAVL.Checked)
            {
                list = AppData.AVL.SearchPrefix(keyword);
            }
            else if (rdbRB.Checked)
            {
                list = AppData.RB.SearchPrefix(keyword);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại cây!");
                return;
            }

            // 2. Hiển thị danh sách vào ListBox
            if (list != null && list.Count > 0)
            {
                foreach (Word word in list)
                {
                    lstResult.Items.Add(word);
                }

                // 3. Tự động chọn dòng đầu tiên
                // Lệnh này sẽ tự động kích hoạt hàm lstResult_SelectedIndexChanged bên dưới
                lstResult.SelectedIndex = 0;
            }
            else
            {
                rtbDetail.Clear();
                lblDemSS.Text = "Số lần so sánh: 0";
                MessageBox.Show("Không tìm thấy kết quả nào!");
            }
        }

        
    }
}
