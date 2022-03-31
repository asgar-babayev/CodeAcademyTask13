using PrintPdfWordExcel.Models;
using System;

namespace PrintPdfWordExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word("Word", 10);
            PDF pDF = new PDF("Pdf", 50);
            Excel excel = new Excel("Excel", 50, 10);


            PrintFile<Word> w = new PrintFile<Word>();
            PrintFile<PDF> p = new PrintFile<PDF>();
            PrintFile<Excel> e = new PrintFile<Excel>();

            p.Print(pDF);
            w.Print(word);
            e.Print(excel);
        }
    }
}
