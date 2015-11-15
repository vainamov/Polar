Public Class FestivalColorConverter

    Public Shared Function toHSBV(ByVal RGB As List(Of Integer)) As List(Of Double)
        Dim Max As Integer = RGB.Max
        Dim Min As Integer = RGB.Min
        Dim tReturn As New List(Of Double)
        If Max - Min = 0 Then tReturn.Add(0)
        If Max = RGB(0) Then tReturn.Add((60 * ((RGB(1) - RGB(2)) / (Max - Min))) Mod 360)
        If Max = RGB(1) Then tReturn.Add(60 * ((RGB(2) - RGB(0)) / (Max - Min)) + 120)
        If Max = RGB(2) Then tReturn.Add(60 * ((RGB(0) - RGB(1)) / (Max - Min)) + 240)
        tReturn.Add((Max - Min) / RGB(1))
        tReturn.Add(Max)
        Return tReturn
    End Function

    Public Shared Function toHSL(ByVal RGB As List(Of Integer)) As List(Of Double)
        Dim Max As Integer = RGB.Max
        Dim Min As Integer = RGB.Min
        Dim Lightness As Double = 0
        Dim tReturn As New List(Of Double)
        If Max - Min = 0 Then tReturn.Add(0)
        If Max = RGB(0) Then tReturn.Add((60 * ((RGB(1) - RGB(2)) / (Max - Min))) Mod 360)
        If Max = RGB(1) Then tReturn.Add(60 * ((RGB(2) - RGB(0)) / (Max - Min)) + 120)
        If Max = RGB(2) Then tReturn.Add(60 * ((RGB(0) - RGB(1)) / (Max - Min)) + 240)
        Lightness = 0.5 * (Max + Min)
        tReturn.Add((Max - Min) / (1 - Math.Abs(2 * Lightness - 1)))
        tReturn.Add(Lightness)
        Return tReturn
    End Function

    Public Shared Function toHSI(ByVal RGB As List(Of Integer)) As List(Of Double)
        Dim Min As Integer = RGB.Min
        Dim Intensity As Double = 0
        Dim Saturation As Double = 0
        Dim Hue As Double = 0
        Dim tReturn As New List(Of Double)
        Intensity = 1 / 3 * (RGB(0) + RGB(1) + RGB(2))
        Saturation = 1 - (3 / (RGB(0) + RGB(1) + RGB(2))) * Min
        Hue = Math.Acos((0.5 * ((RGB(0) - RGB(1)) + (RGB(0) - RGB(1)))) / ((RGB(0) - RGB(2)) ^ 2 + (RGB(0) - RGB(2)) * (RGB(1) - RGB(2))) ^ (0.5))
        If Saturation = 0 Then Hue = 0
        If (RGB(2) / Intensity) > (RGB(1) / Intensity) Then
            Hue = 360 - Hue
            Hue = Hue / 360
        End If
        tReturn.Add(Hue)
        tReturn.Add(Saturation)
        tReturn.Add(Intensity)
        Return tReturn
    End Function

    Public Shared Function toCMY(ByVal RGB As List(Of Integer)) As List(Of Double)
        Dim tReturn As New List(Of Double)
        tReturn.AddRange({1 - RGB(0), 1 - RGB(1), 1 - RGB(2)})
        Return tReturn
    End Function

    Public Shared Function toCMYK(ByVal RGB As List(Of Integer)) As List(Of Double)
        Dim RGBInv As New List(Of Double)
        RGBInv.AddRange({RGB(0) / 255, RGB(1) / 255, RGB(2) / 255})
        Dim Key As Double = 1 - RGBInv.Max
        Dim tReturn As New List(Of Double)
        tReturn.Add((1 - RGBInv(0) - Key) / (1 - Key))
        tReturn.Add((1 - RGBInv(1) - Key) / (1 - Key))
        tReturn.Add((1 - RGBInv(2) - Key) / (1 - Key))
        tReturn.Add(Key)
        Return tReturn
    End Function

    Public Shared Function CMYKtoRGB(ByVal CMYK As List(Of Double)) As List(Of Integer)
        Dim tReturn As New List(Of Integer)
        tReturn.Add(CInt(Math.Ceiling(255 * (1 - CMYK(0)) * (1 - CMYK(3)))))
        tReturn.Add(CInt(Math.Ceiling(255 * (1 - CMYK(1)) * (1 - CMYK(3)))))
        tReturn.Add(CInt(Math.Ceiling(255 * (1 - CMYK(2)) * (1 - CMYK(3)))))
        Return tReturn
    End Function

    Public Shared Function HEXtoRGB(ByVal HEX As String) As List(Of Integer)
        Dim c As Color = ColorTranslator.FromHtml(HEX)
        Dim tReturn As New List(Of Integer)
        tReturn.Add(c.R)
        tReturn.Add(c.G)
        tReturn.Add(c.B)
        Return tReturn
    End Function

    Public Shared Function HEXtoARGB(ByVal HEX As String) As List(Of Integer)
        Dim c As Color = ColorTranslator.FromHtml(HEX)
        Dim tReturn As New List(Of Integer)
        tReturn.Add(c.A)
        tReturn.Add(c.R)
        tReturn.Add(c.G)
        tReturn.Add(c.B)
        Return tReturn
    End Function

End Class
