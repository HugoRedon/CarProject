<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LR = New CarFormApplication.CustomPictureBox()
        Me.RR = New CarFormApplication.CustomPictureBox()
        Me.LF = New CarFormApplication.CustomPictureBox()
        Me.RF = New CarFormApplication.CustomPictureBox()
        Me.BC = New CarFormApplication.CustomPictureBox()
        Me.Eng1 = New CarFormApplication.CustomPictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LR
        '
        Me.LR.label = "LR Tire"
        Me.LR.Location = New System.Drawing.Point(3, 3)
        Me.LR.Name = "LR"
        Me.LR.objec = Nothing
        Me.LR.selectedType = CarProject.AutoPart.Tire
        Me.LR.Size = New System.Drawing.Size(101, 140)
        Me.LR.source = False
        Me.LR.TabIndex = 0
        '
        'RR
        '
        Me.RR.label = "RR Tire"
        Me.RR.Location = New System.Drawing.Point(110, 3)
        Me.RR.Name = "RR"
        Me.RR.objec = Nothing
        Me.RR.selectedType = CarProject.AutoPart.Tire
        Me.RR.Size = New System.Drawing.Size(101, 140)
        Me.RR.source = False
        Me.RR.TabIndex = 1
        '
        'LF
        '
        Me.LF.label = "LF Tire"
        Me.LF.Location = New System.Drawing.Point(3, 149)
        Me.LF.Name = "LF"
        Me.LF.objec = Nothing
        Me.LF.selectedType = CarProject.AutoPart.Tire
        Me.LF.Size = New System.Drawing.Size(101, 140)
        Me.LF.source = False
        Me.LF.TabIndex = 2
        '
        'RF
        '
        Me.RF.label = "RF Tire"
        Me.RF.Location = New System.Drawing.Point(110, 149)
        Me.RF.Name = "RF"
        Me.RF.objec = Nothing
        Me.RF.selectedType = CarProject.AutoPart.Tire
        Me.RF.Size = New System.Drawing.Size(101, 140)
        Me.RF.source = False
        Me.RF.TabIndex = 3
        '
        'BC
        '
        Me.BC.label = "Body Car"
        Me.BC.Location = New System.Drawing.Point(255, 17)
        Me.BC.Name = "BC"
        Me.BC.objec = Nothing
        Me.BC.selectedType = CarProject.AutoPart.BodyCar
        Me.BC.Size = New System.Drawing.Size(221, 200)
        Me.BC.source = False
        Me.BC.TabIndex = 4
        '
        'Eng1
        '
        Me.Eng1.label = "Engine"
        Me.Eng1.Location = New System.Drawing.Point(255, 200)
        Me.Eng1.Name = "Eng1"
        Me.Eng1.objec = Nothing
        Me.Eng1.selectedType = CarProject.AutoPart.Engine
        Me.Eng1.Size = New System.Drawing.Size(177, 140)
        Me.Eng1.source = False
        Me.Eng1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CarControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Eng1)
        Me.Controls.Add(Me.BC)
        Me.Controls.Add(Me.RF)
        Me.Controls.Add(Me.LF)
        Me.Controls.Add(Me.RR)
        Me.Controls.Add(Me.LR)
        Me.Name = "CarControl"
        Me.Size = New System.Drawing.Size(489, 368)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LR As CarFormApplication.CustomPictureBox
    Friend WithEvents RR As CarFormApplication.CustomPictureBox
    Friend WithEvents LF As CarFormApplication.CustomPictureBox
    Friend WithEvents RF As CarFormApplication.CustomPictureBox
    Friend WithEvents BC As CarFormApplication.CustomPictureBox
    Friend WithEvents Eng1 As CarFormApplication.CustomPictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
