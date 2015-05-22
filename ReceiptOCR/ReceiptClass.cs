using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptOCR.Receipt
{
    public class Raw
    {
        public ReceiptChar FirstChar { get; set; }
        public ReceiptChar LastChar { get; set; }
        public Line[] Lines { get; set; }
    }

    public class Line
    {
        public IntPtr xy1 { get; set; }
        public IntPtr xy2 { get; set; }
        public ReceiptChar[] Chars { get; set; } 
        public int Count { get; set; }
    }

    public class ReceiptChar 
    {
        public IntPtr xy1 { get; set; }
        public IntPtr xy2 { get; set; }
    }

    public class DataStack
    {
        public Raw[] ReceiptStack { get; set; }
        public Line[] LineStack { get; set; }
        public ReceiptChar[] CharStack { get; set; }
    }
}
