<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CustomPictureBox4 = New CarFormApplication.CustomPictureBox()
        Me.CustomPictureBox1 = New CarFormApplication.CustomPictureBox()
        Me.CustomPictureBox6 = New CarFormApplication.CustomPictureBox()
        Me.CarControl1 = New CarFormApplication.CarControl()
        Me.SuspendLayout()
        '
        'CustomPictureBox4
        '
        Me.CustomPictureBox4.label = Nothing
        Me.CustomPictureBox4.Location = New System.Drawing.Point(12, 115)
        Me.CustomPictureBox4.Name = "CustomPictureBox4"
        Me.CustomPictureBox4.selectedType = CarProject.AutoPart.BodyCar
        Me.CustomPictureBox4.Size = New System.Drawing.Size(101, 113)
        Me.CustomPictureBox4.source = True
        Me.CustomPictureBox4.TabIndex = 3
        '
        'CustomPictureBox1
        '
        Me.CustomPictureBox1.label = Nothing
        Me.CustomPictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.CustomPictureBox1.Name = "CustomPictureBox1"
        Me.CustomPictureBox1.selectedType = CarProject.AutoPart.Tire
        Me.CustomPictureBox1.Size = New System.Drawing.Size(101, 112)
        Me.CustomPictureBox1.source = True
        Me.CustomPictureBox1.TabIndex = 0
        '
        'CustomPictureBox6
        '
        Me.CustomPictureBox6.label = Nothing
        Me.CustomPictureBox6.Location = New System.Drawing.Point(12, 217)
        Me.CustomPictureBox6.Name = "CustomPictureBox6"
        Me.CustomPictureBox6.selectedType = CarProject.AutoPart.Engine
        Me.CustomPictureBox6.Size = New System.Drawing.Size(101, 105)
        Me.CustomPictureBox6.source = True
        Me.CustomPictureBox6.TabIndex = 5
        '
        'CarControl1
        '
        Me.CarControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CarControl1.Location = New System.Drawing.Point(190, 10)
        Me.CarControl1.Name = "CarControl1"
        Me.CarControl1.Size = New System.Drawing.Size(489, 368)
        Me.CarControl1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 390)
        Me.Controls.Add(Me.CarControl1)
        Me.Controls.Add(Me.CustomPictureBox6)
        Me.Controls.Add(Me.CustomPictureBox4)
        Me.Controls.Add(Me.CustomPictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomPictureBox1 As CarFormApplication.CustomPictureBox
    Friend WithEvents CustomPictureBox4 As CarFormApplication.CustomPictureBox
    Friend WithEvents CustomPictureBox6 As CarFormApplication.CustomPictureBox
    Friend WithEvents CarControl1 As CarFormApplication.CarControl
End Class
