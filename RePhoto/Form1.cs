using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RePhoto
{
    public partial class RePhoto : Form
    {
        public RePhoto()
        {
            InitializeComponent();
            lv_files.View = View.Details;
            lv_files.Columns.Add("File location", -2, HorizontalAlignment.Left);
            lv_files.Columns.Add("File name", -2, HorizontalAlignment.Left);
        }

        private void btn_loadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog thisDialog = new OpenFileDialog();

            thisDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            thisDialog.FilterIndex = 2;
            thisDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            thisDialog.RestoreDirectory = true;
            thisDialog.Multiselect = true;

            if (thisDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in thisDialog.FileNames)
                {
                    try
                    {
                        FileInfo info = new FileInfo(file);
                        lv_files.Items.Add(new ListViewItem(new[] { info.FullName, info.Name }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
            ResizeColumns();
        }

        private void btn_removeSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lv_files.SelectedItems)
                lv_files.Items.Remove(i);
        }

        private void btn_removeAll_Click(object sender, EventArgs e)
        {
            lv_files.Items.Clear();
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            if (lv_files.Items.Count > 0)
            {
                int height = 0;
                int width = 0;
                bool validHeight = int.TryParse(txt_height.Text, out height);
                bool validWidth = int.TryParse(txt_width.Text, out width);
                if (validHeight == true && validWidth == true)
                {
                    foreach (ListViewItem a in lv_files.Items)
                    {
                        FileInfo info = new FileInfo(a.Text);
                        using (Image image = Image.FromFile(a.Text))
                        {
                            using (Bitmap resizedImage = ResizeImage(image, width, height))
                            {
                                resizedImage.Save(
                                    info.DirectoryName + "\\"
                                        + info.Name.Substring(0, info.Name.LastIndexOf(info.Extension))
                                        + "_s"
                                        + info.Extension,
                                    ImageFormat.Jpeg);
                            }
                        }
                    }
                    MessageBox.Show("DONE!");
                }
                else
                {
                    MessageBox.Show("Check your values for height and width!");
                }
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void ResizeColumns()
        {
            for (int i = 0; i < lv_files.Columns.Count - 1; i++) lv_files.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            {
                lv_files.Columns[lv_files.Columns.Count - 1].Width = -2;
            }
        }
    }
}