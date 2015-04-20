Imports System.Text

Public Class Car
    Public Property rearLeftTire As Tire
    Public Property rearRightTire As Tire
    Public Property frontLeftTire As Tire
    Public Property frontRightTire As Tire

    Public Property engine As Engine
    Public Property BodyCar As BodyCar

    Public Overrides Function ToString() As String
        Dim out As New StringBuilder()
        out.Append("Created Car:")
        out.Append(If(rearLeftTire Is Nothing, "", "Left rear tire pressure = " & rearLeftTire.pressure & ","))
        out.Append(If(rearRightTire Is Nothing, "", "Right rear tire pressure = " & rearRightTire.pressure & ","))
        out.Append(If(frontLeftTire Is Nothing, "", "Left front tire pressure = " & frontLeftTire.pressure & ","))
        out.Append(If(frontRightTire Is Nothing, "", "Right front tire pressure = " & frontRightTire.pressure & ","))
        out.Append(If(engine Is Nothing, "", "Engine is on = " & engine.isOn & ","))
        out.Append(If(BodyCar Is Nothing, "", "Body Car color is = " & BodyCar.color.ToString))

        Return out.ToString
    End Function
End Class
