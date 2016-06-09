﻿Imports System
Imports System.IO
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace VisualBasic.Slides
    Class ExtractVideo
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()

            ' ExStart:RemoveNotesFromAllSlides
            ' Instantiate Presentation class
            Dim presentation As New Presentation(dataDir & Convert.ToString("Video.pptx"))

            For Each slide As ISlide In presentation.Slides
                For Each shape As IShape In presentation.Slides(0).Shapes
                    If TypeOf shape Is VideoFrame Then
                        Dim vf As IVideoFrame = TryCast(shape, IVideoFrame)
                        Dim type As [String] = vf.EmbeddedVideo.ContentType
                        Dim ss As Integer = type.LastIndexOf("/"c)
                        type = type.Remove(0, type.LastIndexOf("/"c) + 1)
                        Dim buffer As [Byte]() = vf.EmbeddedVideo.BinaryData
                        Using stream As New FileStream((dataDir & Convert.ToString("NewVideo.")) + type, FileMode.Create, FileAccess.Write, FileShare.Read)
                            ' ExEnd:RemoveNotesFromAllSlides                            
                            stream.Write(buffer, 0, buffer.Length)
                        End Using
                    End If
                Next
            Next
        End Sub
    End Class
End Namespace