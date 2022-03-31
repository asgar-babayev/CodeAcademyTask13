using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPdfWordExcel.Models
{
    public class PrintFile<T> where T : IPrintable
    {
        public void Print(T t)
        {
            t.PrintFile();
        }
    }
}
