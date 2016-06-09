//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using Aspose.Slides.Export;

namespace CSharp.Shapes
{
    public class AddVideoFrame
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes();

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate PrseetationEx class that represents the PPTX
            using (Presentation pres = new Presentation())
            {

                //Get the first slide
                ISlide sld = pres.Slides[0];

                //Add Video Frame
                IVideoFrame vf = sld.Shapes.AddVideoFrame(50, 150, 300, 150, dataDir+ "video1.avi");

                //Set Play Mode and Volume of the Video
                vf.PlayMode = VideoPlayModePreset.Auto;
                vf.Volume = AudioVolumeMode.Loud;

                //Write the PPTX file to disk
                pres.Save(dataDir+ "VideoFrame.pptx", SaveFormat.Pptx);
            }

            
            
        }
    }
}