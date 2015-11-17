<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_background = New System.Windows.Forms.ComboBox()
        Me.TextTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_foreground = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.lbl_playground = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(455, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Use this playground to combine colors and play with foreground/background colors." &
    ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(8, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Playground"
        '
        'cbx_background
        '
        Me.cbx_background.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_background.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_background.FormattingEnabled = True
        Me.cbx_background.Location = New System.Drawing.Point(11, 83)
        Me.cbx_background.Name = "cbx_background"
        Me.cbx_background.Size = New System.Drawing.Size(160, 25)
        Me.cbx_background.TabIndex = 24
        '
        'TextTextbox
        '
        Me.TextTextbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextTextbox.Location = New System.Drawing.Point(398, 83)
        Me.TextTextbox.Name = "TextTextbox"
        Me.TextTextbox.Size = New System.Drawing.Size(271, 25)
        Me.TextTextbox.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(395, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Text"
        '
        'cbx_foreground
        '
        Me.cbx_foreground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_foreground.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_foreground.FormattingEnabled = True
        Me.cbx_foreground.Location = New System.Drawing.Point(177, 83)
        Me.cbx_foreground.Name = "cbx_foreground"
        Me.cbx_foreground.Size = New System.Drawing.Size(160, 25)
        Me.cbx_foreground.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Background"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(174, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Foreground"
        '
        'UploadButton
        '
        Me.UploadButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.UploadButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UploadButton.Location = New System.Drawing.Point(343, 82)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(49, 27)
        Me.UploadButton.TabIndex = 28
        Me.UploadButton.Text = "Font"
        Me.UploadButton.UseVisualStyleBackColor = True
        '
        'lbl_playground
        '
        Me.lbl_playground.BackColor = System.Drawing.Color.Transparent
        Me.lbl_playground.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_playground.Location = New System.Drawing.Point(12, 126)
        Me.lbl_playground.Name = "lbl_playground"
        Me.lbl_playground.Size = New System.Drawing.Size(657, 248)
        Me.lbl_playground.TabIndex = 0
        Me.lbl_playground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(681, 384)
        Me.Controls.Add(Me.lbl_playground)
        Me.Controls.Add(Me.UploadButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbx_foreground)
        Me.Controls.Add(Me.cbx_background)
        Me.Controls.Add(Me.TextTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_background As ComboBox
    Friend WithEvents TextTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_foreground As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UploadButton As Button
    Friend WithEvents lbl_playground As Label
End Class
