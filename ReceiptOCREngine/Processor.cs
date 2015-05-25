using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using Tesseract;
using Tesseract.Interop;
using System.Text.RegularExpressions;


namespace ReceiptOCREngine
{

    public class OcrData
    {
        public string ReadText { get; set; }
        public string IterationName { get; set; }
        public int IterationCount { get; set; }
        public ROI TargetArea { get; set; }
        public decimal LineConfidence { get; set; }
        public int Count { get { return ReadText.Length; } }
    }

    public class Line
    {
        public List<Word> Words {get;set;}
        public char WordSeparator{get;set;}

    }

    public class Word
    {
        public string Value {get;set;}
        public char[] Characters{get;set;}        
        public float CorrectConfidence{get;set;}
    }

    public class ROI
    {
        public int X1 = 0;
        public int Y1 = 0;
        public int X2 = 0;
        public int Y2 = 0;
        public int Height = 0;
        public int Width = 0;
    }
    public class Processor
    {
        public static OcrData RunOCR(Bitmap inputImage, OcrPageMode pageSegMode)
        {
            OcrData OcrData1 = new OcrData();
            using (var ocrEngine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                ocrEngine.SetVariable("tessedit_char_whitelist", @"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz$/.&");
                ////ocrEngine.SetVariable("language_model_penalty_non_freq_dict_word", "0");
                ////ocrEngine.SetVariable("language_model_penalty_non_dict_word", "0");
                ////ocrEngine.SetVariable("tessedit_char_blacklist", "");
                ////ocrEngine.SetVariable("classify_bln_numeric_mode", "1");
                //BitmapToPixConverter b2p = new BitmapToPixConverter();
                //Pix nPic = b2p.Convert(inputImage);
                //nPic = nPic.ConvertRGBToGray(255, 255, 255);
                //nPic.BinarizeSauvola(120, (float)0.35, false);
                

                using (var ocrPage = ocrEngine.Process(inputImage,(PageSegMode)pageSegMode))
                {
                    //ocrPage.AnalyseLayout();

                    //ocrPage.GetThresholdedImage().Save(@"D:\\ocrd_image.jpg", ImageFormat.Default);
                    ROI OcrRoi = new ROI();
                    OcrRoi.X1 = ocrPage.RegionOfInterest.X1;
                    OcrRoi.Y1 = ocrPage.RegionOfInterest.Y1;
                    OcrRoi.X2 = ocrPage.RegionOfInterest.X2;
                    OcrRoi.Y2 = ocrPage.RegionOfInterest.Y2;
                    OcrRoi.Height = ocrPage.RegionOfInterest.Height;
                    OcrRoi.Width = ocrPage.RegionOfInterest.Width;
                    OcrData1.ReadText = ocrPage.GetText();
                    OcrData1.LineConfidence = (int)ocrPage.GetMeanConfidence();
                    
                    
                }

            }
            return OcrData1;
        }                

        public static string SanatizeLine(string InputLine)
        {
            Regex rg = new Regex(@"\.\\/",RegexOptions.Singleline);
            var CleanLine = rg.Replace(InputLine, string.Empty);

            var rg1 = new Regex(@"  ", RegexOptions.Singleline);
            CleanLine = rg1.Replace(CleanLine, " ");

            return CleanLine;
        }

        //public static char MostCommonChar() { }
    }

    
    public enum OcrPageMode
    {
        // Summary:
        //     Orientation and script detection (OSD) only.
        OsdOnly = 0,
        //
        // Summary:
        //     Automatic page sementation with orientantion and script detection (OSD).
        AutoOsd = 1,
        //
        // Summary:
        //     Automatic page segmentation, but no OSD, or OCR.
        AutoOnly = 2,
        //
        // Summary:
        //     Fully automatic page segmentation, but no OSD.
        Auto = 3,
        //
        // Summary:
        //     Assume a single column of text of variable sizes.
        SingleColumn = 4,
        //
        // Summary:
        //     Assume a single uniform block of vertically aligned text.
        SingleBlockVertText = 5,
        //
        // Summary:
        //     Assume a single uniform block of text.
        SingleBlock = 6,
        //
        // Summary:
        //     Treat the image as a single text line.
        SingleLine = 7,
        //
        // Summary:
        //     Treat the image as a single word.
        SingleWord = 8,
        //
        // Summary:
        //     Treat the image as a single word in a circle.
        CircleWord = 9,
        //
        // Summary:
        //     Treat the image as a single character.
        SingleChar = 10,
        //
        // Summary:
        //     Number of enum entries.
        Count = 11,

    };
}

