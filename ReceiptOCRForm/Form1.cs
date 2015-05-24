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
                    MagickImage img = new MagickImage(memstream.ToArray());
                   // img.Grayscale(PixelIntensityMethod.Average);
                    
                    

                    origImg = img.ToBitmap();
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
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = imgForScanning;
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
                         
                //imgForScanning = processImgForScanning(origImg);                
                //pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                //pictureBox2.BackgroundImage = imgForScanning;
          
            //processImg[0].Wait();
        }

        private Bitmap processImgForScanning(Bitmap imgInput)
        {
            using (MemoryStream memstream = new MemoryStream())
            {
                imgInput.Save(memstream, ImageFormat.Jpeg);
                MagickImage img = new MagickImage(memstream.ToArray());

                //basic options

                //img.ColorFuzz = 2;
                //img.FillColor =(Color.Black);
                //MagickGeometry geo = new MagickGeometry(0,0);
                //img.FloodFill(img, 0, 0, Color.White);
                //img.Alpha(AlphaOption.Off);
                //img.Threshold((Percentage)50);
                //img.Morphology(MorphologyMethod.HitAndMiss, Kernel.Undefined, "3x3:-,0,-,0,1,0,-,0,-", Channels.All, 10);
                //img.Threshold((Percentage)50);
                //img.Depth = 8;
                
                //////////////

                if (wtThreshold)
                {
                    //img.WhiteThreshold((int)wtThresInt.Value);
                    img.ReduceNoise();
                    //img.TransformSkewX(2);
                    //img.TransformSkewY(2);
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
                    img.Scale((Percentage)300, (Percentage)300);
                    img.Unsharpmask(6.8, 2.69, 2.69, 0);
                    img.BackgroundColor = Color.White;
                    //img.BlackPointCompensation = true;
                    //img.
                    //img.Deskew(10);
                    img.ReduceNoise(3);
                }

                if (despeckle)
                {
                    img.Despeckle();
                }

                if (sharpen)
                {
                    img.Sharpen((int)sharpenIntX.Value, (int)sharpenIntY.Value,Channels.All);
                }

                return img.ToBitmap();
            }           
        }

        private void ParamVal_ValueChanged(object sender, EventArgs e)
        {
            //imgForScanning = processImgForScanning(origImg);
            //pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            //pictureBox2.BackgroundImage = imgForScanning;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                button2.Enabled =false;
                var tx = button2.Text ;
                button2.Text = "Reading...";
               OcrData OcrData1 = Processor.RunOCR(imgForScanning, OcrPageMode.Auto);
               richTextBox1.Text = OcrData1.ReadText;                
                 button2.Enabled =true;
                 button2.Text = tx;

               Stream imageStreamSource = new FileStream(@"D:\\ocrd_image.jpg", FileMode.Open, FileAccess.Read, FileShare.Read);
                using (MemoryStream memstream = new MemoryStream())
                {

                    memstream.SetLength(imageStreamSource.Length);
                    imageStreamSource.Read(memstream.GetBuffer(), 0, (int)imageStreamSource.Length);
                    imageStreamSource.Close();
                    pictureBox2.BackgroundImage = Bitmap.FromStream(memstream);
                }

                       
                       
            //GetSlices(origImg);
                // Bitmap imgI = (Bitmap)pictureBox2.BackgroundImage;
            //imgI =FixBG(imgI);
            //DetectColorWithUnsafeParallel(imgI, 255, 255, 255,(byte)int.Parse(textBox1.Text));
           // pictureBox2.BackgroundImage = imgI;

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

        public Bitmap FixBG(Bitmap img)
        {           
            int imgX = img.Width;
            int imgY = img.Height;

            for (int i = 0; i < imgX; i++)
            {               
                for (int y = 0; y < imgY; y++)
                {
                    if (img.GetPixel(i, y).GetSaturation() >= 0.6)
                    {
                        img.SetPixel(i, y, Color.Orange);
                    }
                    else if (img.GetPixel(i, y).GetSaturation() >= 0.5 && img.GetPixel(i, y).GetSaturation() < 0.6)
                    {
                        //MessageBox.Show(string.Format("{0},{1}  {2}", i, y, img.GetPixel(i, y).GetSaturation()));
                        img.SetPixel(i, y, Color.Black);
                        
                    }
                    else if (img.GetPixel(i, y).GetSaturation() >= 0.3 && img.GetPixel(i, y).GetSaturation() < 0.5)
                    {
                        img.SetPixel(i, y, Color.Pink);
                    }
                    else if (img.GetPixel(i, y).GetSaturation() >= 0.1 && img.GetPixel(i, y).GetSaturation() < 0.3)
                    {
                        img.SetPixel(i, y, Color.Blue);
                    }
                    else if (img.GetPixel(i, y).GetSaturation() >= 0.01 && img.GetPixel(i, y).GetSaturation() < 0.1)
                    {
                        img.SetPixel(i, y, Color.Red);
                    }
                    else if (img.GetPixel(i, y).GetSaturation() > 0.001 && img.GetPixel(i, y).GetSaturation() < 0.01)
                    {
                        img.SetPixel(i, y, Color.White);
                    }
                }               
            }


            return img;
        }

        static unsafe void DetectColorWithUnsafeParallel(Bitmap image, 
    byte searchedR, byte searchedG, int searchedB, int tolerance)
{
    BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, 
      image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
    int bytesPerPixel = 3;

    byte* scan0 = (byte*)imageData.Scan0.ToPointer();
            //imageData
    int stride = imageData.Stride;

    byte unmatchingValue = 0;
    byte matchingValue = 255;
    int toleranceSquared = tolerance * tolerance;

    Task[] tasks = new Task[4];
    for (int i = 0; i < tasks.Length; i++)
    {
        int ii = i;
        tasks[i] = Task.Factory.StartNew(() =>
            {
                int minY = ii < 2 ? 0 : imageData.Height / 2;
                int maxY = ii < 2 ? imageData.Height / 2 : imageData.Height;

                int minX = ii % 2 == 0 ? 0 : imageData.Width / 2;
                int maxX = ii % 2 == 0 ? imageData.Width / 2 : imageData.Width;                        
                
                for (int y = minY; y < maxY; y++)
                {
                    byte* row = scan0 + (y * stride);

                    for (int x = minX; x < maxX; x++)
                    {
                        int bIndex = x * bytesPerPixel;
                        int gIndex = bIndex + 1;
                        int rIndex = bIndex + 2;

                        byte pixelR = row[rIndex];
                        byte pixelG = row[gIndex];
                        byte pixelB = row[bIndex];

                        int diffR = pixelR - searchedR;
                        int diffG = pixelG - searchedG;
                        int diffB = pixelB - searchedB;

                        int distance = diffR * diffR + diffG * diffG + diffB * diffB;

                        row[rIndex] = row[bIndex] = row[gIndex] = distance >
                            toleranceSquared ? unmatchingValue : matchingValue;
                    }
                }
            });
    }

    Task.WaitAll(tasks);

    image.UnlockBits(imageData);
}

        

        
    }
}
