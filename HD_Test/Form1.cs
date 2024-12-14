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

namespace HD_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void huongDanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEADMEmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  "Guide.html");
            OpenFile(filePath);
        }

        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  "README.md");
            OpenFile(filePath);
        }

        private void OpenFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Mở bằng ứng dụng mặc định
                });
            }
            else
            {
                MessageBox.Show($"Không tìm thấy file: {filePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
