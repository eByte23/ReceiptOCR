using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using System.IO;

namespace ReceiptOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string imageFilename = Console.ReadLine();
            Stream imageStreamSource = new FileStream(imageFilename, FileMode.Open, FileAccess.Read, FileShare.Read);
            MemoryStream memstream = new MemoryStream();
            memstream.SetLength(imageStreamSource.Length);
            imageStreamSource.Read(memstream.GetBuffer(), 0, (int)imageStreamSource.Length);
            imageStreamSource.Close();   
            
            Bitmap bmpNew;
            bmpNew = (Bitmap)Bitmap.FromStream(memstream).Clone();
            int imgX = bmpNew.Width;
            int imgY = bmpNew.Height;
            string fileTx = "################################";
            //Console.WriteLine("");
            //Console.WriteLine("################################");
            //Console.WriteLine("##########Image Data############");
            fileTx += "##########Image Data############ \r\n";
            int xCnt = 0;
            List<string> obj = new List<string>();
            for (int x = 0; x != imgX; x++)
            {
                int yCnt = 0;
                for (int y = 0; y != imgY; y++)
                {
                    //Console.WriteLine(string.Format("pos({0},{1})  {2}",xCnt,yCnt, bmpNew.GetPixel(xCnt, yCnt).Name));
                    fileTx += string.Format("pos({0},{1})  {2}  {3}  {4}  {5}\r\n", xCnt, yCnt, bmpNew.GetPixel(xCnt, yCnt).Name,bmpNew.GetPixel(xCnt, yCnt).GetSaturation(),bmpNew.GetPixel(xCnt, yCnt).GetBrightness(),bmpNew.GetPixel(xCnt, yCnt).GetHue());
                    obj.Add(bmpNew.GetPixel(xCnt, yCnt).Name);
                    if (bmpNew.GetPixel(xCnt, yCnt).GetHue() < 10 || (bmpNew.GetPixel(xCnt, yCnt).GetHue() >240))
                        bmpNew.SetPixel(xCnt, yCnt, Color.Black);
                    yCnt++;
                }
                xCnt++;
            }
            //Console.WriteLine(bmpNew.GetPixel(0,0).Name);
            fileTx += "################################";
            Console.WriteLine("################################");

            Dictionary<string, int> MostPopular = new Dictionary<string, int>();
            obj.Sort();
            foreach(string colorA in obj)
            {
                if(!MostPopular.ContainsKey(colorA)){
                    MostPopular.Add(colorA,1);
                }else{
                    MostPopular[colorA]++;
                }
            }

            fileTx += "\r\n Most Popular color\r\n";
            
            foreach (string a in MostPopular.Keys)
            {
                fileTx += "color: " + a + " count: " + MostPopular[a] +"\r\n";
            }
            Bitmap newBit = new Bitmap(bmpNew);
            newBit.Save("D:\\LWA\\Other\\OCR_Stuff\\test.jpg");
            //File.WriteAllBytes("D:\\LWA\\Other\\OCR_Stuff\\test.jpg", bmpNew);

            File.WriteAllText("D:\\LWA\\Other\\OCR_Stuff\\test.txt", fileTx);
            Console.Read();
            
            
           
        }

     
    }
}
