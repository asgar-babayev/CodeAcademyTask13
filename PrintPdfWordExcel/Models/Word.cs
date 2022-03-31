using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPdfWordExcel.Models
{
    class Word : IPrintable
    {
        public string Filename { get; set; }
        public int WordCount { get; set; }

        public Word(int wordCount)
        {
            WordCount = wordCount;
        }
        public Word(string fileName, int wordCount) : this(wordCount)
        {
            Filename = fileName;
        }

        public void PrintFile()
        {
            Console.WriteLine($"{Filename} is created. Word counts {WordCount}");
        }
    }
}
