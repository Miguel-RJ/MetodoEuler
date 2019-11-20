Imports info.lundin.math

Public Class Euler
    Dim x(500), Y(500), er(500) As Double
    Dim ec, A, h, xf As Double
    Dim i, redon, c As Integer
    Dim cadena As String
    Function f(x As Double, y As Double) As Double
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        parser.Values.Add("xy", x * y)
        parser.Values.Add("yx", y * x)
        Return parser.Parse(tf.Text)
    End Function
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        x(i) = tx0.Text
        Y(i) = ty0.Text
        xf = txf.Text
        h = th.Text
        c = tc.Text
        redon = c + 2
        Salida.Rows.Add(Math.Round(x(i), redon), Math.Round(Y(i), redon))
        Do While x(i) < xf
            i = i + 1
            Y(i) = Y(i - 1) + h * f(x(i - 1), Y(i - 1))
            x(i) = x(i - 1) + h
            Salida.Rows.Add(Math.Round(x(i), redon), Math.Round(Y(i), redon))
        Loop
    End Sub


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
