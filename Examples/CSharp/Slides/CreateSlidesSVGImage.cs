//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;

namespace CSharp.Slides
{
    public class CreateSlidesSVGImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Slides_Presentations();

            //Instantiate a Presentation class that represents the presentation file

            using (Presentation pres = new Presentation(dataDir + "CreateSlidesSVGImage.pptx"))
            {

                //Access the first slide
                ISlide sld = pres.Slides[0];

                //Create a memory stream object
                MemoryStream SvgStream = new MemoryStream();

                //Generate SVG image of slide and save in memory stream
                sld.WriteAsSvg(SvgStream);
                SvgStream.Position = 0;

                //Save memory stream to file
                using (Stream fileStream = System.IO.File.OpenWrite(dataDir + "Aspose.svg"))
                {
                    byte[] buffer = new byte[8 * 1024];
                    int len;
                    while ((len = SvgStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, len);
                    }

                }
                SvgStream.Close();
            }
        }
    }
}