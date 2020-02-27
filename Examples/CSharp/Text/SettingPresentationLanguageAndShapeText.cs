using System.IO;

using Aspose.Slides;

namespace Aspose.Slides.Examples.CSharp.Text
{
    public class SettingPresentationLanguageAndShapeText
    {
        public static void Run()
        {
            // ExStart:SettingPresentationLanguageAndShapeText
            using (Presentation pres = new Presentation())
            {
                IAutoShape shape = pres.Slides[0].Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 200, 50);
                shape.AddTextFrame("Text to apply spellcheck language");
                shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.LanguageId = "en-EN";

                pres.Save(RunExamples.OutPath + "test1.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
        // ExEnd:SettingPresentationLanguageAndShapeText
    }
}
