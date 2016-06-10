﻿Imports System
Imports Aspose.Slides.Export
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace VisualBasic.Text
    Class LineSpacing
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            'ExStart:LineSpacing
            ' Create an instance of Presentation class
            Dim presentation As New Presentation(dataDir & "Fonts.pptx")

            ' Obtain a slide's reference by its index
            Dim sld As ISlide = presentation.Slides(0)

            ' Access the TextFrame
            Dim tf1 As ITextFrame = DirectCast(sld.Shapes(0), IAutoShape).TextFrame

            ' Access the Paragraph
            Dim para1 As IParagraph = tf1.Paragraphs(0)

            ' Set properties of Paragraph
            para1.ParagraphFormat.SpaceWithin = 80
            para1.ParagraphFormat.SpaceBefore = 40
            para1.ParagraphFormat.SpaceAfter = 40

            'ExEnd:LineSpacing
            ' Save Presentation
            presentation.Save(dataDir & Convert.ToString("LineSpacing.pptx"), SaveFormat.Pptx)
        End Sub
    End Class
End Namespace