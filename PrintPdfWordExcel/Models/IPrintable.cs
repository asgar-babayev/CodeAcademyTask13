using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPdfWordExcel.Models
{
    public interface IPrintable
    {
        public string Filename { get; set; }

        public void PrintFile();
    }
}
