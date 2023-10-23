using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiDienTu
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();

        }

        //---------------------------------------------------
        private void homeToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            // Tạo một viền tùy chỉnh với màu sắc và độ rộng
            using (Pen pen = new Pen(Color.Black, 1))
            {
                Rectangle rect = new Rectangle(1, 1, item.Width - 3, item.Height - 3);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        private void khoToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            // Tạo một viền tùy chỉnh với màu sắc và độ rộng
            using (Pen pen = new Pen(Color.Black, 1))
            {
                Rectangle rect = new Rectangle(1, 1, item.Width - 3, item.Height - 3);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        private void receiptToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            // Tạo một viền tùy chỉnh với màu sắc và độ rộng
            using (Pen pen = new Pen(Color.Black, 1))
            {
                Rectangle rect = new Rectangle(1, 1, item.Width - 3, item.Height - 3);
                e.Graphics.DrawRectangle(pen, rect);
            }
        
    }
        private void employeesToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            // Tạo một viền tùy chỉnh với màu sắc và độ rộng
            using (Pen pen = new Pen(Color.Black, 1))
            {
                Rectangle rect = new Rectangle(1, 1, item.Width - 3, item.Height - 3);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        private void danhMụcToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            // Tạo một viền tùy chỉnh với màu sắc và độ rộng
            using (Pen pen = new Pen(Color.Black, 1))
            {
                Rectangle rect = new Rectangle(1, 1, item.Width - 3, item.Height - 3);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        //---------------------------------------------------

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(); // Tạo một thể hiện của form "Home"
            homeForm.Show();
            this.Hide();
            homeForm.homeToolStripMenuItem.ForeColor = Color.BlueViolet;
            homeForm.homeToolStripMenuItem.BackColor = Color.White;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kho khoForm = new Kho();
            khoForm.Show();
            this.Hide();
            khoForm.khoToolStripMenuItem.ForeColor = Color.BlueViolet;
            khoForm.khoToolStripMenuItem.BackColor = Color.White;
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees employeesForm = new Employees();
            employeesForm.Show();
            this.Hide();
            employeesForm.employeesToolStripMenuItem.ForeColor = Color.BlueViolet;
            employeesForm.employeesToolStripMenuItem.BackColor = Color.White;
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMuc danhmucForm = new DanhMuc();
            danhmucForm.Show();
            this.Hide();
            danhmucForm.danhMụcToolStripMenuItem.ForeColor = Color.BlueViolet;
            danhmucForm.danhMụcToolStripMenuItem.BackColor= Color.White;
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt receiptForm =new Receipt();
            receiptForm.Show();
            this.Hide();
            receiptForm.receiptToolStripMenuItem.ForeColor = Color.BlueViolet;
            receiptForm.receiptToolStripMenuItem.BackColor = Color.White;
        }
    }
}
