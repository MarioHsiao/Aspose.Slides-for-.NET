﻿Imports Aspose.Slides.Export
Imports Aspose.Slides

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.Slides.Examples.VisualBasic.Presentations
    Public Class ConvertNotesSlideViewToPDF
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Presentations()

            ' Instantiate a Presentation object that represents a presentation file
            Using presentation As Presentation = New Presentation(dataDir + "NotesFile.pptx")

                ' Saving the presentation to PDF notes
                presentation.Save(dataDir + "Pdf_Notes_out.pdf", SaveFormat.PdfNotes)
            End Using
        End Sub
    End Class
End Namespace