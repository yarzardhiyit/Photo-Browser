using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Browser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            opfDialbrowse.Filter = "Joint Photographic Groups (.jpg)|*.jpg|Portable Network Graphics (.png)|*.png|All Files(*.*)|*.*";
            opfDialbrowse.FilterIndex = 1; //Default 1 = JPG
            opfDialbrowse.Multiselect = true;
            DialogResult result = opfDialbrowse.ShowDialog();
            if (result == DialogResult.OK) //u've picked a file.
            {
                string sFname = opfDialbrowse.FileName;
                //MessageBox.Show(sFname);
                Image img = Image.FromFile(sFname);
                picArea.Image = img; //picArea is PictureBox
            }
        }

        private void comView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(comView.SelectedItem.ToString()); /*test comboBox
            switch (comView.SelectedItem.ToString())
            {
                case "Normal":picArea.SizeMode = PictureBoxSizeMode.Normal; break;
                case "StretchImage": picArea.SizeMode = PictureBoxSizeMode.StretchImage; break;
                // case "AutoSize": picArea.SizeMode = PictureBoxSizeMode.AutoSize; break; /* out of picturebox range, so i ignored it.
                case "CenterImage": picArea.SizeMode = PictureBoxSizeMode.CenterImage; break;
                case "Zoom": picArea.SizeMode = PictureBoxSizeMode.Zoom; break;
            }
        }
    }
}