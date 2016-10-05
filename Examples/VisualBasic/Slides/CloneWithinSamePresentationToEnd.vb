Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports Aspose.Slides.Export

Namespace Aspose.Slides.Examples.VisualBasic.Slides
    Public Class CloneWithinSamePresentationToEnd
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()

            ' Instantiate Presentation class that represents a presentation file
            Using pres As New Presentation(dataDir & "CloneWithinSamePresentationToEnd.pptx")

                ' Clone the desired slide to the end of the collection of slides in the same presentation
                Dim slds As ISlideCollection = pres.Slides

                slds.AddClone(pres.Slides(0))

                'Write the modified presentation to disk
                pres.Save(dataDir & "Aspose_cloned_out.pptx", SaveFormat.Pptx)

            End Using
        End Sub
    End Class
End Namespace