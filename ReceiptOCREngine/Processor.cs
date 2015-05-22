using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using Tesseract;


namespace ReceiptOCREngine
{

    public class OcrData
    {
        public string ReadText { get; set; }
        public string IterationName { get; set; }
        public int IterationCount { get; set; }
        public decimal LineConfidence { get; set; }
        public int Count { get { return ReadText.Length; } }
    }
    public class Processor
    {
        public static OcrData RunOCR(Bitmap inputImage, OcrPageMode pageSegMode)
        {
            OcrData OcrData1 = new OcrData();
            using (var ocrEngine = new TesseractEngine(@"./tessdata", "eng", EngineMode.TesseractAndCube))
            {
                using (var ocrPage = ocrEngine.Process(inputImage,ReturnPageMode(pageSegMode)))
                {
                    OcrData1.ReadText = ocrPage.GetText();
                    OcrData1.LineConfidence = (int)ocrPage.GetMeanConfidence();                    
                }

            }
            return OcrData1;
        }

        public static PageSegMode ReturnPageMode(OcrPageMode pgMode)
        {
            //var var1 = Enum.GetName(typeof(PageSegMode), pgMode);
            //return (PageSegMode)var1;

            PageSegMode returnValue = PageSegMode.Auto;
            switch ((int)pgMode)
            {
                case 0:
                    {
                        returnValue = PageSegMode.OsdOnly;
                        break;
                    }
                case 1:
                    {
                        returnValue = PageSegMode.AutoOsd;
                        break;
                    }
                case 2:
                    {
                        returnValue = PageSegMode.AutoOnly;
                        break;
                    }
                case 3:
                    {
                        returnValue = PageSegMode.Auto;
                        break;
                    }
                case 4:
                    {
                        returnValue = PageSegMode.SingleColumn;
                        break;
                    }
                case 5:
                    {
                        returnValue = PageSegMode.SingleBlockVertText;
                        break;
                    }
                case 6:
                    {
                        returnValue = PageSegMode.SingleBlock;
                        break;
                    }
                case 7:
                    {
                        returnValue = PageSegMode.SingleLine;
                        break;
                    }
                case 8:
                    {
                        returnValue = PageSegMode.SingleWord;
                        break;
                    }
                case 9:
                    {
                        returnValue = PageSegMode.CircleWord;
                        break;
                    }
                case 10:
                    {
                        returnValue = PageSegMode.SingleChar;
                        break;
                    }
                case 11:
                    {
                        returnValue = PageSegMode.Count;
                        break;
                    }
            }
            return returnValue;
        }
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

