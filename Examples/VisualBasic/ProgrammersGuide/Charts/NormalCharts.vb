'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides.Charts
Imports System.Drawing
Imports Aspose.Slides.Export
Imports Aspose.Slides

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace VisualBasic.Charts
    Public Class NormalCharts
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Charts()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate Presentation class that represents PPTX file
            Dim pres As New Presentation()

            'Access first slide
            Dim sld As ISlide = pres.Slides(0)

            ' Add chart with default data
            Dim chart As IChart = sld.Shapes.AddChart(ChartType.ClusteredColumn, 0, 0, 500, 500)

            'Setting chart Title
            'chart.ChartTitle.TextFrameForOverriding.Text = "Sample Title";
            chart.ChartTitle.AddTextFrameForOverriding("Sample Title")
            chart.ChartTitle.TextFrameForOverriding.TextFrameFormat.CenterText = NullableBool.True
            chart.ChartTitle.Height = 20
            chart.HasTitle = True

            'Set first series to Show Values
            chart.ChartData.Series(0).Labels.DefaultDataLabelFormat.ShowValue = True

            'Setting the index of chart data sheet
            Dim defaultWorksheetIndex As Integer = 0

            'Getting the chart data worksheet
            Dim fact As IChartDataWorkbook = chart.ChartData.ChartDataWorkbook

            'Delete default generated series and categories
            chart.ChartData.Series.Clear()
            chart.ChartData.Categories.Clear()
            Dim s As Integer = chart.ChartData.Series.Count
            s = chart.ChartData.Categories.Count

            'Adding new series
            chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 0, 1, "Series 1"), chart.Type)
            chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 0, 2, "Series 2"), chart.Type)

            'Adding new categories
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 1, 0, "Caetegoty 1"))
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 2, 0, "Caetegoty 2"))
            chart.ChartData.Categories.Add(fact.GetCell(defaultWorksheetIndex, 3, 0, "Caetegoty 3"))

            'Take first chart series
            Dim series As IChartSeries = chart.ChartData.Series(0)

            'Now populating series data

            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 1, 1, 20))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 2, 1, 50))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 3, 1, 30))

            'Setting fill color for series
            series.Format.Fill.FillType = FillType.Solid
            series.Format.Fill.SolidFillColor.Color = Color.Red


            'Take second chart series
            series = chart.ChartData.Series(1)

            'Now populating series data
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 1, 2, 30))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 2, 2, 10))
            series.DataPoints.AddDataPointForBarSeries(fact.GetCell(defaultWorksheetIndex, 3, 2, 60))

            'Setting fill color for series
            series.Format.Fill.FillType = FillType.Solid
            series.Format.Fill.SolidFillColor.Color = Color.Green

            'first label will be show Category name
            Dim lbl As IDataLabel = series.DataPoints(0).Label
            lbl.DataLabelFormat.ShowCategoryName = True

            lbl = series.DataPoints(1).Label
            lbl.DataLabelFormat.ShowSeriesName = True

            'Show value for third label
            lbl = series.DataPoints(2).Label
            lbl.DataLabelFormat.ShowValue = True
            lbl.DataLabelFormat.ShowSeriesName = True
            lbl.DataLabelFormat.Separator = "/"

            'Save presentation with chart
            pres.Save(dataDir & "AsposeChart.pptx", SaveFormat.Pptx)

        End Sub
    End Class
End Namespace