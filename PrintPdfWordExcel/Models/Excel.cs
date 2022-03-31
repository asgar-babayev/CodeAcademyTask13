using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPdfWordExcel.Models
{
    public class Excel : IPrintable
    {
        public string Filename { get; set; }
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }

        public Excel(int rowCount, int columnCount)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
        }
        public Excel(string filename, int rowCount, int columnCount) : this(rowCount, columnCount)
        {
            Filename = filename;
        }
        public void PrintFile()
        {
            Console.WriteLine($"{Filename} is crated. Row counts {RowCount}, column counts {ColumnCount}");
        }
    }
}
