Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports Aspose.Slides.Export
Imports System.Drawing

Namespace Aspose.Slides.Examples.VisualBasic.Slides
    Public Class SetSlideBackgroundMaster
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Slides_Presentations()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate the Presentation class that represents the presentation file
            Using pres As New Presentation()

                'Set the background color of the Master ISlide to Forest Green
                pres.Masters(0).Background.Type = BackgroundType.OwnBackground
                pres.Masters(0).Background.FillFormat.FillType = FillType.Solid
                pres.Masters(0).Background.FillFormat.SolidFillColor.Color = Color.ForestGreen

                'Write the presentation to disk
                pres.Save(dataDir & "SetSlideBackgroundMaster.pptx", SaveFormat.Pptx)

            End Using

        End Sub
    End Class
End Namespace