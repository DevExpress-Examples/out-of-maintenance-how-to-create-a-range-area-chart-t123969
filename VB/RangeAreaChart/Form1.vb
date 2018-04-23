Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace RangeAreaChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim rangeAreaChart As New ChartControl()

			' Create a range area series.
			Dim series1 As New Series("Series 1", ViewType.RangeArea)

			' Add points to them.
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 1), 2.08, 4.28))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 2), 2.42, 4.03))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 3), 2.78, 3.98))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 4), 2.57, 3.94))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 5), 2.69, 4.18))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 6), 2.69, 5.02))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 7), 2.36, 5.60))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 8), 1.97, 5.37))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 9), 2.76, 4.94))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 10), 3.54, 3.66))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 11), 4.31, 1.07))
			series1.Points.Add(New SeriesPoint(New DateTime(2008, 1, 12), 4.08, 0.09))

			' Add a series to the chart.
			rangeAreaChart.Series.Add(series1)

			' Access the view-type-specific options of the series.
			CType(series1.View, RangeAreaSeriesView).Transparency = 80

			' Access the type-specific options of the diagram.
			CType(rangeAreaChart.Diagram, XYDiagram).AxisX.GridLines.Visible = True
			CType(rangeAreaChart.Diagram, XYDiagram).AxisY.WholeRange.MinValue = -0.5
			CType(rangeAreaChart.Diagram, XYDiagram).AxisY.WholeRange.MaxValue = 6

			' Hide the legend (if necessary).
			rangeAreaChart.Legend.Visible = False

			' Add a title to the chart (if necessary).
			rangeAreaChart.Titles.Add(New ChartTitle())
			rangeAreaChart.Titles(0).Text = "A Range Area Chart"

			' Add the chart to the form.
			rangeAreaChart.Dock = DockStyle.Fill
			Me.Controls.Add(rangeAreaChart)
		End Sub
	End Class
End Namespace
