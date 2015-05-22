using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using System.Drawing.Imaging;
using ReceiptOCREngine;

namespace ReceiptOCRForm
{
    public partial class Form1 : Form
    {
        private string origFile { get;set;}
        private Bitmap origImg;
        private Bitmap imgForScanning;
        private bool wtThreshold, enhance, contrast, autoGamma, autoOrient, autoLevel,despeckle, sharpen,invert, medianFilter;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.ShowDialog();
            var name = ofdlg.FileName;
            if (name.Length > 0)
            {
                origFile = name;
                
                Stream imageStreamSource = new FileStream(origFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                using (MemoryStream memstream = new MemoryStream())
                {

                    memstream.SetLength(imageStreamSource.Length);
                    imageStreamSource.Read(memstream.GetBuffer(), 0, (int)imageStreamSource.Length);
                    imageStreamSource.Close();

                    origImg = new Bitmap(Bitmap.FromStream(memstream));
                    optionsPanel.Enabled = true;

                }

                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BackgroundImage = origImg;                
            }
            else
            {
                MessageBox.Show("Sorry there was an error getting your ne image\rNow Restore previous image");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BackgroundImage = origImg;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderChkbx = (CheckBox)sender;
            switch (senderChkbx.Name)
            {
                case "wtThresholdChk":
                    {
                        if (senderChkbx.Checked)
                        {
                            this.wtThresInt.Enabled = true;
                            this.wtThreshold = true;
                        }
                        else
                        {
                            this.wtThresInt.Enabled = false;
                            this.wtThreshold = false;
                        }
                        break;
                    }
                case "sharpenChk":
                    {
                        if (senderChkbx.Checked)
                        { 
                            this.sharpenIntX.Enabled = true;
                            this.sharpenIntY.Enabled = true;
                            this.sharpen = true;
                        }
                        else
                        {
                            this.sharpenIntX.Enabled = false;
                            this.sharpenIntY.Enabled = false;
                            this.sharpen = false;
                        }
                        break;
                    }
                case "autoGammaChk":
                    {
                        if (senderChkbx.Checked)
                        {
                            this.autoGamma = true;
                        }
                        else
                        {
                            this.autoGamma = false;
                        }
                           
                        break;
                    }
                case "autoLevelChk":
                    {
                        if (senderChkbx.Checked)
                            this.autoLevel = true;
                        else
                            this.autoLevel = false;
                        break;
                    }
                case "autoOrientChk":
                    {
                        if (senderChkbx.Checked)
                            this.autoOrient = true;
                        else
                            this.autoOrient = false;
                        break;
                    }
                case "enhanceChk":
                    {
                        if (senderChkbx.Checked)
                            this.enhance = true;
                        else
                            this.enhance = false;
                        break;
                    }
                case "contrastChk":
                    {
                        if (senderChkbx.Checked)
                            this.contrast = true;
                        else
                            this.contrast = false;
                        break;
                    }
                case "despeckleChk":
                    {
                        if (senderChkbx.Checked)
                            this.despeckle = true;
                        else
                            this.despeckle = false;
                        break;
                    }

                case "invertChk":
                    {
                        if (senderChkbx.Checked)
                            this.invert = true;
                        else
                            this.invert = false;
                        break;
                    }
                case "medianChk":
                    {
                        if (senderChkbx.Checked)
                        {
                            this.medianFilter = true;
                            this.medianInt.Enabled = true;
                        }
                        else
                        {
                            this.medianFilter = false;
                            this.medianInt.Enabled = false;
                        }
                        break;
                    }
            }

            imgForScanning = processImgForScanning(origImg);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = imgForScanning;
        }

        private Bitmap processImgForScanning(Bitmap imgInput)
        {
            using (MemoryStream memstream = new MemoryStream())
            {
                imgInput.Save(memstream, ImageFormat.Jpeg);
                MagickImage img = new MagickImage(memstream.ToArray());

                if (wtThreshold)
                {
                   // img.WhiteThreshold((int)wtThresInt.Value);

                    img.TransformSkewX(2);
                    img.TransformSkewY(2);
                }

                if (invert)
                {
                   // img.Equalize();
                    //img.Flop();  horisontal image flip                   
                    //img.MedianFilter(2);
                    img.Negate();
                }

                if (medianFilter)
                {
                    img.MedianFilter((int)medianInt.Value);
                }

                if (autoLevel)
                {
                    img.AutoLevel();
                }

                if (enhance)
                {
                    img.Enhance();
                }

                if (contrast)
                {
                    img.Contrast();
                }

                if (autoGamma)
                {
                    img.AutoGamma();
                }

                if (autoOrient)
                {                    
                    img.AutoOrient();
                    //img.Grayscale(PixelIntensityMethod.Average);
                    //MagickGeometry geo = new MagickGeometry(2191,4000);
                    //img.Scale(geo);
                    img.Unsharpmask(6.8, 2.69, 2.69, 0);
                    img.BackgroundColor = Color.White;
                    img.BlackPointCompensation = true;
                    img.
                    //img.Deskew(10);
                }

                if (despeckle)
                {
                    img.Despeckle();
                }

                if (sharpen)
                {
                    img.Sharpen((int)sharpenIntX.Value, (int)sharpenIntY.Value, Channels.All);
                }

                return img.ToBitmap();
            }           
        }

        private void ParamVal_ValueChanged(object sender, EventArgs e)
        {
            imgForScanning = processImgForScanning(origImg);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = imgForScanning;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OcrData OcrData1 = Processor.RunOCR(imgForScanning,OcrPageMode.SingleBlock);
            richTextBox1.Text = OcrData1.ReadText;
            //GetSlices(origImg);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgForScanning = processImgForScanning(origImg);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = imgForScanning;
        }


        //public List<Bitmap> GetSlices(Bitmap InputImg)
        public void GetSlices(Bitmap InputImg)
        {
            MemoryStream memstream = new MemoryStream();
            InputImg.Save(memstream, ImageFormat.Jpeg);
            MagickImage img = new MagickImage(memstream.ToArray());
            
            List<Bitmap> Slices = new List<Bitmap>();
            int imgWidth = 0, imgHeight = 0, slice = 5, currSlice = 0;

            imgHeight = img.Height;
            imgWidth = img.Width;

            img.TransformSkewX(2);
            img.TransformSkewY(2);


        }

        
    }
}
