//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using System;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace CSharp.Shapes 
{
    public class ConnectorLineAngle
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes();

            Presentation pres = new Presentation(dataDir + "ConnectorLineAngle.pptx");
            Slide slide = (Slide)pres.Slides[0];
            Shape shape;
            for (int i = 0; i < slide.Shapes.Count; i++)
            {
                double dir = 0.0;
                shape = (Shape)slide.Shapes[i];
                if (shape is AutoShape)
                {
                    AutoShape ashp = (AutoShape)shape;
                    if (ashp.ShapeType == ShapeType.Line)
                    {
                        dir = getDirection(ashp.Width, ashp.Height, Convert.ToBoolean(ashp.Frame.FlipH), Convert.ToBoolean(ashp.Frame.FlipV));
                    }
                }
                else if (shape is Connector)
                {
                    Connector ashp = (Connector)shape;
                    dir = getDirection(ashp.Width, ashp.Height, Convert.ToBoolean(ashp.Frame.FlipH), Convert.ToBoolean(ashp.Frame.FlipV));
                }

                Console.WriteLine(dir);
            }
            
        }
        public static double getDirection(float w, float h, bool flipH, bool flipV)
        {
            float endLineX = w * (flipH ? -1 : 1);
            float endLineY = h * (flipV ? -1 : 1);
            float endYAxisX = 0;
            float endYAxisY = h;
            double angle = (Math.Atan2(endYAxisY, endYAxisX) - Math.Atan2(endLineY, endLineX));
            if (angle < 0) angle += 2 * Math.PI;
            return angle * 180.0 / Math.PI;
        }
    }

}