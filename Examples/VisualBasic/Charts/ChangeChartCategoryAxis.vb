﻿Imports System
Imports Aspose.Slides.Charts
Imports Aspose.Slides.Export
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace VisualBasic.Charts
    Public Class ChangeChartCategoryAxis
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Charts()

            Using presentation As New Presentation(dataDir & Convert.ToString("ExistingChart.pptx"))
                Dim chart As IChart = TryCast(presentation.Slides(0).Shapes(0), IChart)
                chart.Axes.HorizontalAxis.CategoryAxisType = CategoryAxisType.[Date]
                chart.Axes.HorizontalAxis.IsAutomaticMajorUnit = False
                chart.Axes.HorizontalAxis.MajorUnit = 1
                chart.Axes.HorizontalAxis.MajorUnitScale = TimeUnitType.Months
                presentation.Save(dataDir & Convert.ToString("ChangeChartCategoryAxis.pptx"), SaveFormat.Pptx)
            End Using
        End Sub
    End Class
End Namespace