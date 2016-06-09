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
    Public Class AddSlides
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()


            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If


            'Instantiate Presentation class that represents the presentation file
            Using pres As New Presentation()

                'Instantiate SlideCollection calss
                Dim slds As ISlideCollection = pres.Slides

                For i As Integer = 0 To pres.LayoutSlides.Count - 1
                    'Add an empty slide to the Slides collection
                    slds.AddEmptySlide(pres.LayoutSlides(i))

                Next i
                'Do some work on the newly added slide

                'Save the PPTX file to the Disk
                pres.Save(dataDir & "EmptySlide.pptx", Aspose.Slides.Export.SaveFormat.Pptx)

            End Using
        End Sub
    End Class
End Namespace