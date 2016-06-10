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
Imports Aspose.Slides.Export

Namespace VisualBasic.Slides
    Public Class CloneAtEndOfAnother
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()

            'Instantiate Presentation class to load the source presentation file
            Using srcPres As New Presentation(dataDir & "CloneAtEndOfAnother.pptx")
                'Instantiate Presentation class for destination PPTX (where slide is to be cloned)
                Using destPres As New Presentation()
                    'Clone the desired slide from the source presentation to the end of the collection of slides in destination presentation
                    Dim slds As ISlideCollection = destPres.Slides

                    slds.AddClone(srcPres.Slides(0))

                    'Write the destination presentation to disk
                    destPres.Save(dataDir & "Aspose_out.pptx", SaveFormat.Pptx)
                End Using
            End Using
        End Sub
    End Class
End Namespace