<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloeListItem
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_identifier = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnl_color1 = New System.Windows.Forms.Panel()
        Me.pnl_color2 = New System.Windows.Forms.Panel()
        Me.pnl_color3 = New System.Windows.Forms.Panel()
        Me.pnl_color4 = New System.Windows.Forms.Panel()
        Me.pnl_color5 = New System.Windows.Forms.Panel()
        Me.pnl_color6 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_info.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lbl_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.lbl_info.Location = New System.Drawing.Point(8, 30)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Padding = New System.Windows.Forms.Padding(3)
        Me.lbl_info.Size = New System.Drawing.Size(135, 25)
        Me.lbl_info.TabIndex = 0
        Me.lbl_info.Text = "Testset by Vainamo"
        '
        'lbl_identifier
        '
        Me.lbl_identifier.AutoSize = True
        Me.lbl_identifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbl_identifier.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_identifier.ForeColor = System.Drawing.Color.White
        Me.lbl_identifier.Location = New System.Drawing.Point(8, 6)
        Me.lbl_identifier.Name = "lbl_identifier"
        Me.lbl_identifier.Padding = New System.Windows.Forms.Padding(3)
        Me.lbl_identifier.Size = New System.Drawing.Size(175, 21)
        Me.lbl_identifier.TabIndex = 1
        Me.lbl_identifier.Text = "floe:author:vainamo:set:testset"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(174, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(270, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Download"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pnl_color1
        '
        Me.pnl_color1.Location = New System.Drawing.Point(8, 6)
        Me.pnl_color1.Name = "pnl_color1"
        Me.pnl_color1.Size = New System.Drawing.Size(49, 49)
        Me.pnl_color1.TabIndex = 4
        Me.pnl_color1.Visible = False
        '
        'pnl_color2
        '
        Me.pnl_color2.Location = New System.Drawing.Point(68, 6)
        Me.pnl_color2.Name = "pnl_color2"
        Me.pnl_color2.Size = New System.Drawing.Size(49, 49)
        Me.pnl_color2.TabIndex = 5
        Me.pnl_color2.Visible = False
        '
        'pnl_color3
        '
        Me.pnl_color3.Location = New System.Drawing.Point(128, 6)
        Me.pnl_color3.Name = "pnl_color3"
        Me.pnl_color3.Size = New System.Drawing.Size(49, 49)
        Me.pnl_color3.TabIndex = 6
        Me.pnl_color3.Visible = False
        '
        'pnl_color4
        '
        Me.pnl_color4.Location = New System.Drawing.Point(189, 6)
        Me.pnl_color4.Name = "pnl_color4"
        Me.pnl_color4.Size = New System.Drawing.Size(49, 49)
        Me.pnl_color4.TabIndex = 7
        Me.pnl_color4.Visible = False
        '
        'pnl_color5
        '
        Me.pnl_color5.Location = New System.Drawing.Point(250, 6)
        Me.pnl_color5.Name = "pnl_color5"
        Me.pnl_color5.Size = New System.Drawing.Size(49, 49)
        Me.pnl_color5.TabIndex = 8
        Me.pnl_color5.Visible = False
        '
        'pnl_color6
        '
        Me.pnl_color6.Location = New System.Drawing.Point(311, 6)
        Me.pnl_color6.Name = "pnl_color6"
        Me.pnl_color6.Size = New System.Drawing.Size(49, 49)
        Me.pnl_color6.TabIndex = 9
        Me.pnl_color6.Visible = False
        '
        'FloeListItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Controls.Add(Me.pnl_color6)
        Me.Controls.Add(Me.pnl_color5)
        Me.Controls.Add(Me.pnl_color4)
        Me.Controls.Add(Me.pnl_color3)
        Me.Controls.Add(Me.pnl_color2)
        Me.Controls.Add(Me.pnl_color1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_identifier)
        Me.Controls.Add(Me.lbl_info)
        Me.Name = "FloeListItem"
        Me.Size = New System.Drawing.Size(367, 95)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_identifier As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pnl_color1 As Panel
    Friend WithEvents pnl_color2 As Panel
    Friend WithEvents pnl_color3 As Panel
    Friend WithEvents pnl_color4 As Panel
    Friend WithEvents pnl_color5 As Panel
    Friend WithEvents pnl_color6 As Panel
End Class
