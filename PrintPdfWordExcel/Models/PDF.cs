using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPdfWordExcel.Models
{
    public class PDF : IPrintable
    {
        public string Filename { get; set; }
        public int PageCount { get; set; }

        public PDF(int pageCount)
        {
            PageCount = pageCount;
        }

        public PDF(string filename, int pageCount) : this(pageCount)
        {
            Filename = filename;
        }
        public void PrintFile()
        {
            Console.WriteLine($"{Filename} is Created. Page count is {PageCount}");
        }
    }
}
