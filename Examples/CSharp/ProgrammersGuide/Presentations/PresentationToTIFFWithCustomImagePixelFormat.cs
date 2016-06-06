﻿/*
//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
*/

using Aspose.Slides.Export;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace CSharp.ProgrammersGuide.Presentations
{
    class PresentationToTIFFWithCustomImagePixelFormat
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Presentations();

            // Instantiate a Presentation object that represents a Presentation file
            using (Presentation presentation = new Presentation(dataDir + "DemoFile.pptx"))
            {
                TiffOptions options = new TiffOptions();
                options.PixelFormat = ImagePixelFormat.Format8bppIndexed;

                /*
                ImagePixelFormat contains the following values (as could be seen from documentation):
                Format1bppIndexed; // 1 bits per pixel, indexed.
                Format4bppIndexed; // 4 bits per pixel, indexed.
                Format8bppIndexed; // 8 bits per pixel, indexed.
                Format24bppRgb; // 24 bits per pixel, RGB.
                Format32bppArgb; // 32 bits per pixel, ARGB.
                */

                // Save the presentation to TIFF with specified image size
                presentation.Save(dataDir + "Tiff_With_Custom_Image_Pixel_Format.tiff", SaveFormat.Tiff, options);
            }
        }
    }
}
