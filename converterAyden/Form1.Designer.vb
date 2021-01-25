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
        Me.btnCalculateFeet = New System.Windows.Forms.Button()
        Me.lblArrow2 = New System.Windows.Forms.Label()
        Me.lblMeter = New System.Windows.Forms.Label()
        Me.lblFoot = New System.Windows.Forms.Label()
        Me.lblArrow1 = New System.Windows.Forms.Label()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtMeters = New System.Windows.Forms.TextBox()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.lblMeters = New System.Windows.Forms.Label()
        Me.lblConverter = New System.Windows.Forms.Label()
        Me.btnCalculateMeters = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculateFeet
        '
        Me.btnCalculateFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateFeet.Location = New System.Drawing.Point(53, 296)
        Me.btnCalculateFeet.Name = "btnCalculateFeet"
        Me.btnCalculateFeet.Size = New System.Drawing.Size(225, 38)
        Me.btnCalculateFeet.TabIndex = 19
        Me.btnCalculateFeet.Text = "Calculate Meters to Feet"
        Me.btnCalculateFeet.UseVisualStyleBackColor = True
        '
        'lblArrow2
        '
        Me.lblArrow2.AutoSize = True
        Me.lblArrow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrow2.Location = New System.Drawing.Point(330, 172)
        Me.lblArrow2.Name = "lblArrow2"
        Me.lblArrow2.Size = New System.Drawing.Size(29, 24)
        Me.lblArrow2.TabIndex = 18
        Me.lblArrow2.Text = "→"
        '
        'lblMeter
        '
        Me.lblMeter.AutoSize = True
        Me.lblMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeter.Location = New System.Drawing.Point(416, 172)
        Me.lblMeter.Name = "lblMeter"
        Me.lblMeter.Size = New System.Drawing.Size(87, 24)
        Me.lblMeter.TabIndex = 17
        Me.lblMeter.Text = "Meters: 0"
        '
        'lblFoot
        '
        Me.lblFoot.AutoSize = True
        Me.lblFoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoot.Location = New System.Drawing.Point(416, 124)
        Me.lblFoot.Name = "lblFoot"
        Me.lblFoot.Size = New System.Drawing.Size(68, 24)
        Me.lblFoot.TabIndex = 16
        Me.lblFoot.Text = "Feet: 0"
        '
        'lblArrow1
        '
        Me.lblArrow1.AutoSize = True
        Me.lblArrow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrow1.Location = New System.Drawing.Point(330, 124)
        Me.lblArrow1.Name = "lblArrow1"
        Me.lblArrow1.Size = New System.Drawing.Size(29, 24)
        Me.lblArrow1.TabIndex = 15
        Me.lblArrow1.Text = "→"
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(173, 172)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(100, 20)
        Me.txtFeet.TabIndex = 14
        '
        'txtMeters
        '
        Me.txtMeters.Location = New System.Drawing.Point(173, 124)
        Me.txtMeters.Name = "txtMeters"
        Me.txtMeters.Size = New System.Drawing.Size(100, 20)
        Me.txtMeters.TabIndex = 13
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeet.Location = New System.Drawing.Point(49, 172)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(53, 24)
        Me.lblFeet.TabIndex = 12
        Me.lblFeet.Text = "Feet:"
        '
        'lblMeters
        '
        Me.lblMeters.AutoSize = True
        Me.lblMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeters.Location = New System.Drawing.Point(49, 124)
        Me.lblMeters.Name = "lblMeters"
        Me.lblMeters.Size = New System.Drawing.Size(72, 24)
        Me.lblMeters.TabIndex = 11
        Me.lblMeters.Text = "Meters:"
        '
        'lblConverter
        '
        Me.lblConverter.AutoSize = True
        Me.lblConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverter.Location = New System.Drawing.Point(12, 9)
        Me.lblConverter.Name = "lblConverter"
        Me.lblConverter.Size = New System.Drawing.Size(134, 31)
        Me.lblConverter.TabIndex = 10
        Me.lblConverter.Text = "Converter"
        '
        'btnCalculateMeters
        '
        Me.btnCalculateMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateMeters.Location = New System.Drawing.Point(334, 296)
        Me.btnCalculateMeters.Name = "btnCalculateMeters"
        Me.btnCalculateMeters.Size = New System.Drawing.Size(225, 38)
        Me.btnCalculateMeters.TabIndex = 20
        Me.btnCalculateMeters.Text = "Calculate Feet to Meters"
        Me.btnCalculateMeters.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 448)
        Me.Controls.Add(Me.btnCalculateMeters)
        Me.Controls.Add(Me.btnCalculateFeet)
        Me.Controls.Add(Me.lblArrow2)
        Me.Controls.Add(Me.lblMeter)
        Me.Controls.Add(Me.lblFoot)
        Me.Controls.Add(Me.lblArrow1)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtMeters)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.lblMeters)
        Me.Controls.Add(Me.lblConverter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculateFeet As System.Windows.Forms.Button
    Friend WithEvents lblArrow2 As System.Windows.Forms.Label
    Friend WithEvents lblMeter As System.Windows.Forms.Label
    Friend WithEvents lblFoot As System.Windows.Forms.Label
    Friend WithEvents lblArrow1 As System.Windows.Forms.Label
    Friend WithEvents txtFeet As System.Windows.Forms.TextBox
    Friend WithEvents txtMeters As System.Windows.Forms.TextBox
    Friend WithEvents lblFeet As System.Windows.Forms.Label
    Friend WithEvents lblMeters As System.Windows.Forms.Label
    Friend WithEvents lblConverter As System.Windows.Forms.Label
    Friend WithEvents btnCalculateMeters As System.Windows.Forms.Button

End Class
