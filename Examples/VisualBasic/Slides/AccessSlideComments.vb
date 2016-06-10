﻿Imports System
Imports System.Drawing
Imports Aspose.Slides.Export
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace VisualBasic.Slides
    Class AccessSlideComments
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()

            ' ExStart:AccessSlideComments
            ' Instantiate Presentation class
            Using presentation As New Presentation(dataDir & Convert.ToString("Comments.pptx"))
                For Each commentAuthor In presentation.CommentAuthors
                    Dim author = DirectCast(commentAuthor, CommentAuthor)
                    For Each comment1 In author.Comments
                        Dim comment = DirectCast(comment1, Comment)
                        ' ExEnd:AccessSlideComments
                        Console.WriteLine("ISlide :" & comment.Slide.SlideNumber & " has comment: " & comment.Text & " with Author: " & comment.Author.Name & " posted on time :" & comment.CreatedTime)
                    Next
                Next
            End Using
        End Sub
    End Class
End Namespace
