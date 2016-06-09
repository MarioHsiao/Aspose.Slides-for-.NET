﻿/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

using Aspose.Slides;
using Aspose.Slides.Export;

namespace CSharp.ProgrammersGuide.Presentations
{
    class ConvetToSWF
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Presentations();

            // Instantiate a Presentation object that represents a presentation file
            using (Presentation presentation = new Presentation(dataDir + "HelloWorld.pptx"))
            {
                SwfOptions swfOptions = new SwfOptions();
                swfOptions.ViewerIncluded = false;

                // Saving presentation
                presentation.Save(dataDir+ "SaveAsSwf.swf", SaveFormat.Swf, swfOptions);

                swfOptions.ViewerIncluded = true;

                // Saving notes pages
                presentation.Save(dataDir+ "SaveNotes.swf", SaveFormat.SwfNotes, swfOptions);
            }
        } 
    }
}

 