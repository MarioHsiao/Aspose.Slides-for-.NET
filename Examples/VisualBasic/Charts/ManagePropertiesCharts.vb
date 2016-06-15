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

Namespace Aspose.Slides.Examples.VisualBasic.Charts
    Public Class ManagePropertiesCharts
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Charts()

            ' Create an instance of Presentation class
            Dim presentation As New Presentation()

            ' Access first slide
            Dim slide As ISlide = presentation.Slides(0)

            ' Add chart with default data
            Dim chart As IChart = slide.Shapes.AddChart(ChartType.StackedColumn3D, 0, 0, 500, 500)

            ' Setting the index of chart data sheet
            Dim defaultWorksheetIndex As Integer = 0

            ' Getting the chart data worksheet
            Dim fact As IChartDataWorkbook = chart.ChartData.ChartDataWorkbook

            ' Add series
            chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 0, 1, "Series 1"), chart.Type)
            chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 0, 2, "Series 2"), chart.Type)

            ' Add Catrgories
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 1, 0, "Caetegoty 1"))
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 2, 0, "Caetegoty 2"))
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 3, 0, "Caetegoty 3"))

            ' Set Rotation3D properties
            chart.Rotation3D.RightAngleAxes = True
            chart.Rotation3D.RotationX = 40
            chart.Rotation3D.RotationY = 270
            chart.Rotation3D.DepthPercents = 150

            ' Take second chart series
            Dim series As IChartSeries = chart.ChartData.Series(1)

            ' Now populating series data
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 1, 1, 20))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 2, 1, 50))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 3, 1, 30))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 1, 2, 30))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 2, 2, 10))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 3, 2, 60))

            ' Set OverLap value
            series.ParentSeriesGroup.Overlap = 100

            ' Write presentation to disk
            presentation.Save(dataDir & Convert.ToString("Rotation3D.pptx"), SaveFormat.Pptx)

        End Sub
    End Class
End Namespace