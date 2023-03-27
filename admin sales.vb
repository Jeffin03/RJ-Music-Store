Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf

Public Class admin_sales
    Private Sub Chart()
        CartesianChart1.Series = New SeriesCollection From {
            New LineSeries With {
            .Values = New ChartValues(Of ObservablePoint) From {
            New ObservablePoint(0, 10),
            New ObservablePoint(4, 7),
            New ObservablePoint(5, 3),
            New ObservablePoint(7, 6),
            New ObservablePoint(10, 8)
            },
            .PointGeometrySize = 25
            },
            New LineSeries With {
            .Values = New ChartValues(Of ObservablePoint) From {
            New ObservablePoint(0, 2),
            New ObservablePoint(2, 5),
            New ObservablePoint(3, 6),
            New ObservablePoint(6, 8),
            New ObservablePoint(10, 5)
        },
        .PointGeometrySize = 15
        },
          New LineSeries With {
            .Values = New ChartValues(Of ObservablePoint) From {
            New ObservablePoint(0, 4),
            New ObservablePoint(5, 5),
            New ObservablePoint(7, 7),
            New ObservablePoint(9, 10),
            New ObservablePoint(10, 9)
        },
        .PointGeometrySize = 15
     }
 }
    End Sub
    Private Sub Chartcolumn()
        CartesianChart2.Series = New SeriesCollection From {
            New ColumnSeries With {
            .Title = "2021",
            .Values = New ChartValues(Of Double) From {
            10,
            50,
            39,
            50,
            49,
            35
        }
     }
 }
        CartesianChart2.Series.Add(New ColumnSeries With {
            .Title = "2022",
            .Values = New ChartValues(Of Double) From {
              11,
                   56,
                   42,
                   40,
                   60,
                   35
                   }
                   }
                   )
        CartesianChart2.Series(1).Values.Add(48.0R)
        CartesianChart2.AxisX.Add(New Axis With {
                                  .Title = "employees",
                                  .Labels = {"Jacob", "Susan", "Nirmala", "Steve"}
                                  })
        CartesianChart2.AxisY.Add(New Axis With {
                                  .Title = " Sold Products",
                                  .LabelFormatter = Function(value) value.ToString("N")
         })

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Close()
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Dim adstc = New admin_stocks
        adstc.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim hm = New Home
        hm.Show()
    End Sub

    Private Sub admin_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart()
        Chartcolumn()

    End Sub

    Private Sub Logoutbt_Click(sender As Object, e As EventArgs) Handles Logoutbt.Click
        Me.Hide()
        Dim log = New Start
        log.Show()


    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Close()
        End

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim ufb = New User_FB
        ufb.Show()
    End Sub
End Class