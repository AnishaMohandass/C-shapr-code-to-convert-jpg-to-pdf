using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
namespace imgtopdf
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();

            string[] files = new string[2];

            files[0] = "C:\\Users\\Admin\\source\\repos\\imgtopdf\\Data\\pic1.jpg";
            files[1] = "C:\\Users\\Admin\\source\\repos\\imgtopdf\\Data\\pic2.jpg";

            ConvertImageToPdf(files, doc);

            doc.Save("C:\\Users\\Admin\\source\\repos\\imgtopdf\\Data\\output.pdf");
        }

        private static void ConvertImageToPdf (string[] files, Document doc)
        {
            DocumentBuilder builder = new DocumentBuilder(doc);

            for(int i=0; i<files.Length; i++)
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(files[i]);

                PageSetup pageSetup = builder.PageSetup;

                pageSetup.PageWidth = ConvertUtil.PixelToPoint(image.Width, image.HorizontalResolution);
                pageSetup.PageHeight = ConvertUtil.PixelToPoint(image.Height, image.VerticalResolution);

                builder.InsertImage(image, Aspose.Words.Drawing.RelativeHorizontalPosition.Page, 0, Aspose.Words.Drawing.RelativeVerticalPosition.Page, 0,
                    pageSetup.PageWidth, pageSetup.PageHeight, Aspose.Words.Drawing.WrapType.None);

                if (i < files.Length - 1)
                    builder.InsertBreak(BreakType.SectionBreakNewPage);
            }
        }
    }
}
