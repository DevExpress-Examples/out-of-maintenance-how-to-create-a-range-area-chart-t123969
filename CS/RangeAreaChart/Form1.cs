using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace RangeAreaChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            // Create a new chart.
            ChartControl rangeAreaChart = new ChartControl();

            // Create a range area series.
            Series series1 = new Series("Series 1", ViewType.RangeArea);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 1), 2.08, 4.28));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 2), 2.42, 4.03));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 3), 2.78, 3.98));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 4), 2.57, 3.94));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 5), 2.69, 4.18));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 6), 2.69, 5.02));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 7), 2.36, 5.60));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 8), 1.97, 5.37));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 9), 2.76, 4.94));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 10), 3.54, 3.66));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 11), 4.31, 1.07));
            series1.Points.Add(new SeriesPoint(new DateTime(2008, 1, 12), 4.08, 0.09));

            // Add a series to the chart.
            rangeAreaChart.Series.Add(series1);

            // Access the view-type-specific options of the series.
            ((RangeAreaSeriesView)series1.View).Transparency = 80;

            // Access the type-specific options of the diagram.
            ((XYDiagram)rangeAreaChart.Diagram).AxisX.GridLines.Visible = true;
            ((XYDiagram)rangeAreaChart.Diagram).AxisY.WholeRange.MinValue = -0.5;
            ((XYDiagram)rangeAreaChart.Diagram).AxisY.WholeRange.MaxValue = 6;

            // Hide the legend (if necessary).
            rangeAreaChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            rangeAreaChart.Titles.Add(new ChartTitle());
            rangeAreaChart.Titles[0].Text = "A Range Area Chart";

            // Add the chart to the form.
            rangeAreaChart.Dock = DockStyle.Fill;
            this.Controls.Add(rangeAreaChart);
        }
    }
}
