//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using System.Drawing;
using Aspose.Slides.Export;

namespace CSharp.Tables
{
    public class TableFromScratch
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tables();

            // Instantiate Presentation class that represents PPTX//Instantiate Presentation class that represents PPTX
            using (Presentation presentation = new Presentation(dataDir + "UpdateExistingTable.pptx"))
            {
                // Access the first slide
                ISlide sld = presentation.Slides[0];

                // Initialize null TableEx
                ITable table = null;

                // Iterate through the shapes and set a reference to the table found
                foreach (IShape shape in sld.Shapes)
                    if (shape is ITable)
                        table = (ITable)shape;

                // Set the text of the first column of second row
                table[0, 1].TextFrame.Text = "New";

                // Write the PPTX to Disk
                presentation.Save(dataDir + "UpdateTable.pptx", SaveFormat.Pptx);
            }
        }
    }
}