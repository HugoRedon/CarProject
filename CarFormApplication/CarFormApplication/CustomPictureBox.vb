Imports CarProject

Public Class CustomPictureBox

    Public Property selectedType As AutoPart
    Public Property label As String
    Public Property source As Boolean
    Public Property objec As Object


    Private Sub TirePictureBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.AllowDrop = Not source
        If source Then
            Label1.Text = selectedType.ToString
            PictureBox1.Image = pictureForType.Item(selectedType)

        Else
            Label1.Text = label
            PictureBox1.Image = Nothing

        End If        
    End Sub

   

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        Debug.WriteLine("DragDrop")
        PictureBox1.Image = pictureForType.Item(selectedType)


        If e.Data.GetDataPresent(GetType(Tire)) Then
            TextBox1.Visible = True
            objec = e.Data.GetData(GetType(Tire))
            TextBox1.DataBindings.Add("Text", objec, "pressure", True, DataSourceUpdateMode.OnPropertyChanged)

        ElseIf e.Data.GetDataPresent(GetType(Engine)) Then
            CheckBox1.Visible = True
            objec = e.Data.GetData(GetType(Engine))
            CheckBox1.DataBindings.Add("Checked", objec, "isOn", True, DataSourceUpdateMode.OnPropertyChanged)

        ElseIf e.Data.GetDataPresent(GetType(BodyCar)) Then
            ComboBox1.Visible = True
            objec = e.Data.GetData(GetType(BodyCar))

            ComboBox1.DataSource = System.Enum.GetValues(GetType(Color))

            ComboBox1.DataBindings.Add("SelectedValue", objec, "color", True, DataSourceUpdateMode.OnPropertyChanged)
        End If




    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        If (e.Data.GetDataPresent(typeForClass.Item(selectedType))) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown        
        Form1.mouseIsDown = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If Form1.mouseIsDown Then
            Dim obj As Object = createObject()
            If obj Is Nothing Then Exit Sub
            PictureBox1.DoDragDrop(obj, DragDropEffects.Copy)
        End If
        Form1.mouseIsDown = False
    End Sub





    
    Dim pictureForType As New Dictionary(Of AutoPart, Image) From {
      {AutoPart.BodyCar, My.Resources.bodyCar},
      {AutoPart.Tire, My.Resources.tire},
      {AutoPart.Engine, My.Resources.engine}
      }

    Dim typeForClass As New Dictionary(Of AutoPart, Type) From {
       {AutoPart.BodyCar, GetType(BodyCar)},
       {AutoPart.Tire, GetType(Tire)},
       {AutoPart.Engine, GetType(Engine)}
       }


    Private Function createObject() As Object
        If Not source Then
            Return Nothing
        End If
        If selectedType.Equals(AutoPart.BodyCar) Then Return New BodyCar
        If selectedType.Equals(AutoPart.Engine) Then Return New Engine
        If selectedType.Equals(AutoPart.Tire) Then Return New Tire        

        Return Nothing
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.Text.Length > 11 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged

        PictureBox1.Image = getBodyCarFromColor(ComboBox1.SelectedValue)
    End Sub

    Function getBodyCarFromColor(aColor As Color) As Image
        Select Case aColor
            Case Color.GRAY
                Return My.Resources.bodyCarGrey
            Case Color.BLUE
                Return My.Resources.bodyCar
            Case Color.RED
                Return My.Resources.bodyCarRed
            Case Color.WHITE
                Return My.Resources.bodyCarWhite

        End Select

        Return Nothing

    End Function
End Class
