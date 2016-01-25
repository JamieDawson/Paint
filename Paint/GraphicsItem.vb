Public MustInherit Class GraphicsItem
    'public variables 
    Public color As Color
    Public isFilled As Boolean
    Public Rectangle As Rectangle

    'public methods 
    Public MustOverride Sub Draw(ByVal graphics As Graphics)

    Public Sub SetPoint(ByVal x As Integer, ByVal y As Integer, ByVal graphicsSize As Integer, ByVal graphicsColor As Color, ByVal graphicsIsFilled As Boolean)
        Rectangle = New Rectangle(x - (graphicsSize / 2), y - (graphicsSize / 2), graphicsSize, graphicsSize)
        color = graphicsColor
        isFilled = graphicsIsFilled
    End Sub

End Class
