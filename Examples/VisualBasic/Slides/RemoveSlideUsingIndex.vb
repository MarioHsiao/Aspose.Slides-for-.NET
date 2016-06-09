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

Namespace VisualBasic.Slides
    Public Class RemoveSlideUsingIndex
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()

            'Instantiate a Presentation object that represents a presentation file
            Using pres As New Presentation(dataDir & "RemoveSlideUsingIndex.pptx")

                'Removing a slide using its slide index
                pres.Slides.RemoveAt(0)


                'Writing the presentation file
                pres.Save(dataDir & "modified.pptx", Aspose.Slides.Export.SaveFormat.Pptx)

            End Using
        End Sub
    End Class
End Namespace