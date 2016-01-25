Public Class GraphicsCircle
    Inherits GraphicsItem


    Public Overrides Sub Draw(ByVal graphics As System.Drawing.Graphics)

        Dim objSolidBrush As New SolidBrush(Me.color)
        graphics.FillEllipse(objSolidBrush, Me.Rectangle)
    End Sub


End Class
