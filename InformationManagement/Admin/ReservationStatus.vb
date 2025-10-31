Imports System.Windows.Forms.DataVisualization.Charting

Public Class ReservationStatus
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ReservationStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' === Chart Setup ===
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("MainArea")

        Dim series As New Series("Reservation Status")
        series.ChartType = SeriesChartType.Pie
        series.ChartArea = "MainArea"

        ' Example data — replace with your actual values
        series.Points.AddXY("Pending", 5)
        series.Points.AddXY("Confirmed", 8)
        series.Points.AddXY("Cancelled", 2)

        ' Colors
        series.Points(0).Color = Color.Orange
        series.Points(1).Color = Color.Green
        series.Points(2).Color = Color.Red

        ' Show values
        series.IsValueShownAsLabel = True

        ' Add to chart
        Chart1.Series.Add(series)

        ' Optional title
        Chart1.Titles.Add("Reservation Status")
    End Sub
End Class