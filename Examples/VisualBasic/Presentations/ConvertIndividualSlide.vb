﻿Imports Aspose.Slides.Export
Imports Aspose.Slides

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.Slides.Examples.VisualBasic.Presentations

    Public Class ConvertIndividualSlide
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Presentations()

            ' Instantiate a Presentation object that represents a presentation file
            Using presentation As New Presentation(dataDir + "Individual-Slide.pptx")

                Dim opts As New HtmlOptions()
                opts.HtmlFormatter = HtmlFormatter.CreateCustomFormatter(CType(New CustomFormattingController(), IHtmlFormattingController))

                ' Saving File 
                For i As Integer = 0 To presentation.Slides.Count - 1
                    presentation.Save(dataDir + "IndividualSlide" + i.ToString() + "_out.html", New Integer() {i + 1}, SaveFormat.Html, opts)
                Next
            End Using
        End Sub
    End Class

    Public Class CustomFormattingController

        Implements IHtmlFormattingController
        Public Sub New()
        End Sub

        Private Sub IHtmlFormattingController_WriteDocumentStart(generator As IHtmlGenerator, presentation As IPresentation) Implements IHtmlFormattingController.WriteDocumentStart
        End Sub

        Private Sub IHtmlFormattingController_WriteDocumentEnd(generator As IHtmlGenerator, presentation As IPresentation) Implements IHtmlFormattingController.WriteDocumentEnd
        End Sub

        Private Sub IHtmlFormattingController_WriteSlideStart(generator As IHtmlGenerator, slide As ISlide) Implements IHtmlFormattingController.WriteSlideStart
            generator.AddHtml(String.Format(SlideHeader, generator.SlideIndex + 1))
        End Sub

        Private Sub IHtmlFormattingController_WriteSlideEnd(generator As IHtmlGenerator, slide As ISlide) Implements IHtmlFormattingController.WriteSlideEnd
            generator.AddHtml(SlideFooter)
        End Sub

        Private Sub IHtmlFormattingController_WriteShapeStart(generator As IHtmlGenerator, shape As IShape) Implements IHtmlFormattingController.WriteShapeStart
        End Sub

        Private Sub IHtmlFormattingController_WriteShapeEnd(generator As IHtmlGenerator, shape As IShape) Implements IHtmlFormattingController.WriteShapeEnd
        End Sub

        Private Const SlideHeader As String = "<div class=""slide"" name=""slide"" id=""slide{0}"">"
        Private Const SlideFooter As String = "</div>"
    End Class
End Namespace