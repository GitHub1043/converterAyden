Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculateFeet.Click
        Dim sngMeters As Single
        Dim sngFeet As Single
        Const FEET As Single = 3.281

        sngMeters = Val(txtMeters.Text)

        sngFeet = sngMeters * FEET

        lblFoot.Text = "Feet: " & sngFeet

    End Sub

    Private Sub btnCalculateMeters_Click(sender As Object, e As EventArgs) Handles btnCalculateMeters.Click
        Dim sngMeters As Single
        Dim sngFeet As Single
        Const METERS As Single = 3.281

        sngFeet = Val(txtFeet.Text)

        sngMeters = sngFeet / METERS

        lblMeter.Text = "Meters: " & sngMeters

    End Sub
End Class
