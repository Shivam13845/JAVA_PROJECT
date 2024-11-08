using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string pdfPath = @"D:\SVNShivam\Airanalytics2023\BSP_LIVE\BSP\UploadedFiles\BSP\BSP_YAT__BSP_ANALYTICS__20241022181436775PM.PDF";
        StringBuilder text = new StringBuilder();

        using (PdfReader pdfReader = new PdfReader(pdfPath))
        {
            using (PdfDocument pdfDoc = new PdfDocument(pdfReader))
            {
                for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string pageText = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);
                    text.Append(pageText);
                }
            }
        }

        Console.WriteLine(text.ToString());
    }
}