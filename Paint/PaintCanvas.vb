Public Class PaintCanvas
    'public enumeration 
    Public Enum GraphicsSizes As Integer
        Small = 5
        Medium = 10
        Large = 25

    End Enum
    Public Enum GraphicsTools As Integer
        CirclePen = 0

    End Enum

    'public variables 
    Public GraphicsItems As New ArrayList()
    Public graphicsTool As GraphicsTools = GraphicsTools.CirclePen
    Public graphicsSize As GraphicsSizes = GraphicsSizes.Large
    Public GraphicsColor As Color = Color.Black

    'private methods
    Private Sub DoMousePaint(ByVal e As MouseEventArgs)
        Dim objGraphicsItem As GraphicsItem

        Select Case graphicsTool
            Case GraphicsTools.CirclePen
                Dim ObjGraphicsCicle As New GraphicsCircle()
                ObjGraphicsCicle.SetPoint(e.X, e.Y, graphicsSize, GraphicsColor, True)
                objGraphicsItem = ObjGraphicsCicle
        End Select
        If objGraphicsItem IsNot Nothing Then
            GraphicsItems.Add(objGraphicsItem)
            Me.Invalidate(objGraphicsItem.Rectangle)
        End If
    End Sub

    Private Sub PaintCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            DoMousePaint(e)

        End If
    End Sub

    Private Sub PaintCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            DoMousePaint(e)
        End If
    End Sub

    Private Sub PaintCanvas_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        For Each objGraicsItem As GraphicsItem In GraphicsItems
            objGraicsItem.Draw(e.Graphics)
        Next
    End Sub

    Public Sub clearCanvas()
        GraphicsItems.Clear()
        Me.Invalidate()
    End Sub
End Class
