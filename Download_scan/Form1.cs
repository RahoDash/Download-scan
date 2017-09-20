using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_scan
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folder;
        Download dl;
        Comic cm;
        Chapter ch;

        public Form1()
        {
            InitializeComponent();
            dl = new Download();
            cm = new Comic();
            ch = new Chapter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm.DownloadAll(txtLien.Text, folder.SelectedPath.ToString(), listBox1);
            MessageBox.Show("Done !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folder = new FolderBrowserDialog();
            folder.ShowDialog();

            if (folder.SelectedPath.ToString() != null)
            {
                BtnDownloadAll.Enabled = true;
                btnDLChapter.Enabled = true;
            }

        }

        private void btnDLChapter_Click(object sender, EventArgs e)
        {
            ch.DownloadChapter(txtLien.Text, folder.SelectedPath.ToString(), listBox1);
            MessageBox.Show("Done !");
        }
    }
}
