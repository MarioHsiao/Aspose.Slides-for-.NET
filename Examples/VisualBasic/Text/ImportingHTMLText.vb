'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides

Namespace VisualBasic.Text
    Public Class ImportingHTMLText
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            'Create Empty presentation instance//Create Empty presentation instance
            Using pres As New Presentation()
                'Acesss the default first slide of presentation
                Dim slide As ISlide = pres.Slides(0)

                'Adding the AutoShape to accomodate the HTML content
                Dim ashape As IAutoShape = slide.Shapes.AddAutoShape(ShapeType.Rectangle, 10, 10, pres.SlideSize.Size.Width - 20, pres.SlideSize.Size.Height - 10)

                ashape.FillFormat.FillType = FillType.NoFill

                'Adding text frame to the shape
                ashape.AddTextFrame("")

                'Clearing all paragraphs in added text frame
                ashape.TextFrame.Paragraphs.Clear()

                'Loading the HTML file using stream reader
                Dim tr As TextReader = New StreamReader(dataDir & "file.html")

                'Adding text from HTML stream reader in text frame
                ashape.TextFrame.Paragraphs.AddFromHtml(tr.ReadToEnd())

                'Saving Presentation
                pres.Save(dataDir & "output.pptx", Aspose.Slides.Export.SaveFormat.Pptx)

            End Using

        End Sub
    End Class
End Namespace