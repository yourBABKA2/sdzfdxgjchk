using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Picture_scroll_bar
{
    public partial class Form1 : Form
    {
        string filename;
        Bitmap bmp;
        int pbh, pbw, pbX, pbY;
        Size spbSize;
        Color pixelColor, desiredcolor;
        int desiredcolorR, desiredcolorG, desiredcolorB;
        int mosaicW, mosaicH;
        bool mosaic = false;

        public Form1()
        {
            InitializeComponent();
            pbw = pictureBox.Width;
            pbh = pictureBox.Height;
            pbX = pictureBox.Location.X;
            pbY = pictureBox.Location.Y;
            spbSize = pictureBox.Size;
            textBoxMH.Visible = false;
            textBoxMW.Visible = false;
            buttonCreate.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\alex\\Downloads";
            openFileDialog1.Filter = "Images(*.BMP; *.JPG; *.PNG; *.TIFF)| *.BMP; *.JPG; *.PNG; *.TIFF | " + "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                bmp = (Bitmap)Image.FromFile(filename);
                pictureBox.Image = bmp;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Choose an image");
            }
            else
            {
                Size size = pictureBox.Size;
                pictureBox.Width = (int)(size.Width / 0.8);
                pictureBox.Height = (int)(size.Height / 0.8);
                pictureBox.Image = bmp;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Choose an image");
            }
            else 
            {
                Size size = pictureBox.Size;
                pictureBox.Width = (int)(size.Width * 0.8);
                pictureBox.Height = (int)(size.Height * 0.8);
                pictureBox.Image = bmp;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Choose an image");
            }
            else
            {
                pictureBox.Width = (int)(spbSize.Width);
                pictureBox.Height = (int)(spbSize.Height);
                pictureBox.Location = new Point(pbX, pbY);
                pictureBox.Image = bmp;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox.Image = bmp;
            }
            else
            {
                MessageBox.Show("Choose an image");
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox.Image = bmp;
            }
            else
            {
                MessageBox.Show("Choose an image");
            }
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (bmp != null)
            {
                pixelColor = bmp.GetPixel(e.X, e.Y);
                pictureBoxInitial.BackColor = pixelColor;
                textBoxInitialColor.Text = "R: " + Convert.ToString(pixelColor.R) + " G: " + Convert.ToString(pixelColor.G) + " B: " + Convert.ToString(pixelColor.B);
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                MessageBox.Show("Before you take pixel's color, load an image!!!");
            }
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            Color col;
            if (bmp != null)
            {
                try
                {
                    for (int i = 1; i < pictureBox.Image.Height - 1; i++)
                    {
                        for (int j = 1; j < pictureBox.Image.Width - 1; j++)
                        {
                            col = bmp.GetPixel(j, i);
                            int colR = col.R;
                            int colG = col.G;
                            int colB = col.B;

                            if (colR == pixelColor.R && colG == pixelColor.G && colB == pixelColor.B)
                            {
                                colR = desiredcolor.R;
                                colG = desiredcolor.G;
                                colB = desiredcolor.B;
                                col = Color.FromArgb(0, colR, colG, colB);
                                bmp.SetPixel(j, i, col);
                            }
                        }
                    }
                    pictureBox.Refresh();
                }
                catch
                {
                    MessageBox.Show("Проблема с изображением. Может его нет?",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                return;
            }

        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxWant.BackColor = colorDialog.Color;
                desiredcolor = colorDialog.Color;
                textBoxWant.Text = "R: " + Convert.ToString(desiredcolor.R) + " G: " + Convert.ToString(desiredcolor.G) + " B: " + Convert.ToString(desiredcolor.B);
            }
        }

        private void buttonьMirrow1_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox.Image = bmp;
            }
            else
            {
                MessageBox.Show("Choose an image");
            }
        }

        private void buttonMirrow2_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox.Image = bmp;
            }
            else
            {
                MessageBox.Show("Choose an image");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Choose an image");
            }
            else
            {
                pictureBox.Width = (int)(spbSize.Width);
                pictureBox.Height = (int)(spbSize.Height);
                pictureBox.Location = new Point(pbX, pbY);
                pictureBox.Image = null;
                pictureBox.Refresh();
                bmp = null;
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            desiredcolorR = trackBarRed.Value;
            textBoxRed.Text = desiredcolorR.ToString();
            desiredcolor = Color.FromArgb(255, desiredcolorR, desiredcolorG, desiredcolorB);
            pictureBoxWant.BackColor = desiredcolor;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            desiredcolorG = trackBarGreen.Value;
            textBoxGreen.Text = desiredcolorG.ToString();
            desiredcolor = Color.FromArgb(255, desiredcolorR, desiredcolorG, desiredcolorB);
            pictureBoxWant.BackColor = desiredcolor;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            desiredcolorB = trackBarBlue.Value;
            textBoxBlue.Text = desiredcolorB.ToString();
            desiredcolor = Color.FromArgb(255, desiredcolorR, desiredcolorG, desiredcolorB);
            pictureBoxWant.BackColor = desiredcolor;
        }
        private void whiteAndBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                try
                {
                    for (int i = 0; i < pictureBox.Image.Height - 1; i++)
                    {
                        for (int j = 0; j < pictureBox.Image.Width - 1; j++)
                        {
                            Color colorN = ((Bitmap)pictureBox.Image).GetPixel(j, i);
                            int avg = ((int)colorN.R + (int)colorN.G + (int)colorN.B) / 3;
                            bmp.SetPixel(j, i, Color.FromArgb(avg, avg, avg));
                        }
                    }
                    pictureBox.Refresh();
                }
                catch
                {
                    MessageBox.Show("Проблема с изображением. Может его нет?",
                                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("At first choose an image!!!");
                return;
            }

        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                try
                {
                    for (int i = 0; i < pictureBox.Image.Height - 1; i++)
                    {
                        for (int j = 0; j < pictureBox.Image.Width - 1; j++)
                        {
                            Color colorN = ((Bitmap)pictureBox.Image).GetPixel(j, i);
                            colorN = Color.FromArgb(255, 0xFF - colorN.R, 0xFF - colorN.G, 0xFF - colorN.B);
                            ((Bitmap)pictureBox.Image).SetPixel(j, i, colorN);
                        }
                    }
                    pictureBox.Refresh();
                }
                catch
                {
                    MessageBox.Show("Проблема с изображением. Может его нет?",
                                                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("At first choose an image!!!");
                return;
            }
        }
        private void brightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                Rectangle rec = new Rectangle(0, 0, bmp.Width, bmp.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Brush br = new SolidBrush(Color.FromArgb(128, Color.White));
                gr.FillRectangle(br, rec);
                pictureBox.Refresh();
            }
            else
            {
                MessageBox.Show("At first choose an image!!!");
                return;
            }
        }
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                Rectangle rec = new Rectangle(0, 0, bmp.Width, bmp.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Brush br = new SolidBrush(Color.FromArgb(128, Color.Black));
                gr.FillRectangle(br, rec);
                pictureBox.Refresh();
            }
            else
            {
                MessageBox.Show("At first choose an image!!!");
                return;
            }
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {

                int pixelColorR, pixelColorG, pixelColorB;

                try
                {
                    for (int i = 0; i < pictureBox.Image.Height - 1; i++)
                    {
                        for (int j = 0; j < pictureBox.Image.Width - 1; j++)
                        {
                            Color pixelColor = ((Bitmap)pictureBox.Image).GetPixel(j, i);
                            Color colN = bmp.GetPixel(j, i);

                            int scale = (int)((colN.R * .3) + (colN.G * .59) + (colN.B * .11));
                            Color newC = Color.FromArgb(scale, scale, scale);

                            pixelColorR = newC.R * 1;
                            pixelColorG = (int)(newC.G * 0.95);
                            pixelColorB = (int)(newC.B * 0.82);

                            bmp.SetPixel(j, i, Color.FromArgb(pixelColorR, pixelColorG, pixelColorB));
                        }
                    }
                    pictureBox.Refresh();
                }
                catch
                {
                    MessageBox.Show("Проблема с изображением. Может его нет?",
                                                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("At first choose an image!!!");
                return;
            }
        }
        private void mosaicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mosaic = true;
            if (mosaic == true)
            {
                textBoxMH.Visible = true;
                textBoxMW.Visible = true;
                buttonCreate.Visible = true;
            }
            else
            {
                textBoxMH.Visible = false;
                textBoxMH.Visible = false;
                buttonCreate.Visible = false;
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            mosaic = false;
            if (bmp != null)
            {
                try
                {
                    mosaicH = Convert.ToInt32(textBoxMH.Text);
                    mosaicW = Convert.ToInt32(textBoxMH.Text);
                    // MessageBox.Show("Mosaic making process");
                    Graphics g2 = Graphics.FromImage(pictureBox.Image);

                    for (int i = 0; i < pictureBox.Image.Height - 1; i += mosaicH)
                    {
                        for (int j = 0; j < pictureBox.Image.Width - 1; j += mosaicW)
                        {
                            Brush br = new SolidBrush(bmp.GetPixel(j, i));
                            g2.FillRectangle(br, j, i, mosaicW, mosaicH);

                        }
                    }
                    pictureBox.Refresh();
                    Show(mosaic);
                }
                catch
                {
                    MessageBox.Show("Input integer values");
                }
            }
            else
            {
                MessageBox.Show("At first choose an image!!!");
            }
        }

        void Show(bool x)
        {
            if (mosaic == false)
            {
                textBoxMH.Visible = false;
                textBoxMW.Visible = false;
                buttonCreate.Visible = false;
            }
            else
            {
                textBoxMH.Visible = true;
                textBoxMW.Visible = true;
                buttonCreate.Visible = true;
            }
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp = (Bitmap)Image.FromFile(filename);
                pictureBox.Image = bmp;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("At first choose an image!!!");
                return;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                saveFileDialog1.InitialDirectory = "C:\\Users\\alex\\Downloads";
                saveFileDialog1.Filter = "Image files (*.bmp)|*.bmp|Image files (*.jpg)|*.jpg|Image files (*png)|*.png";
                saveFileDialog1.Title = "Save as...";
                saveFileDialog1.CheckPathExists = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox.Image.Save(saveFileDialog1.FileName);
                        MessageBox.Show("Image has been saved!!!");
                    }
                    catch
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }
    }

}
