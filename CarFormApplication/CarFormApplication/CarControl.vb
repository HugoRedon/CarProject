Imports CarProject

Public Class CarControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim createdCar As New Car
        createdCar.BodyCar = BC.objec
        createdCar.engine = Eng1.objec
        createdCar.frontLeftTire = LF.objec
        createdCar.frontRightTire = RF.objec
        createdCar.rearLeftTire = LR.objec
        createdCar.rearRightTire = RR.objec

        Debug.WriteLine(createdCar.ToString)

    End Sub
End Class
