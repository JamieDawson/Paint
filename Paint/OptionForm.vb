Public Class OptionForm
    Private myPaint As New Form1
    Private Sub ComboBoxSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSize.SelectedIndexChanged
        myPaint.setSize(ComboBoxSize.SelectedIndex)
    End Sub
    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxSize.SelectedIndex = 0
        myPaint.Show()
        lblColor.Text = myPaint.PaintCanvas1.GraphicsColor.ToString()

    End Sub
    Private Sub ButtonColor_Click(sender As Object, e As EventArgs) Handles ButtonColor.Click
        ColorDialogBrush.ShowDialog()
        Try
            myPaint.setColor(ColorDialogBrush.Color)
            lblColor.Text = myPaint.PaintCanvas1.GraphicsColor.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        myPaint.PaintCanvas1.clearCanvas()
    End Sub





End Class