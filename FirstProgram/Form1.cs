using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FirstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File(*.bmt,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofile.FileName);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);

            Processing.ConvertToGray(copy);
            this.picResult.Image = copy;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);

            Processing.ConvertToNegative(copy);
            this.picResult.Image = copy;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files(*.jpeg)|*.jpeg";// Saving files in JPEG Format
                if(DialogResult.OK == sfd.ShowDialog()){

                    this.picResult.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                }
        }
    }
}
