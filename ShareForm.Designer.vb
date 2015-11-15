<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShareForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShareForm))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AuthorTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(10, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Share your colorset via Floe."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name"
        '
        'NameTextbox
        '
        Me.NameTextbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NameTextbox.Location = New System.Drawing.Point(14, 134)
        Me.NameTextbox.Name = "NameTextbox"
        Me.NameTextbox.Size = New System.Drawing.Size(273, 25)
        Me.NameTextbox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Author"
        '
        'AuthorTextbox
        '
        Me.AuthorTextbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AuthorTextbox.Location = New System.Drawing.Point(14, 188)
        Me.AuthorTextbox.Name = "AuthorTextbox"
        Me.AuthorTextbox.Size = New System.Drawing.Size(273, 25)
        Me.AuthorTextbox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 60)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'UploadButton
        '
        Me.UploadButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.UploadButton.Enabled = False
        Me.UploadButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UploadButton.Location = New System.Drawing.Point(193, 239)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(95, 23)
        Me.UploadButton.TabIndex = 21
        Me.UploadButton.Text = "Upload to Floe"
        Me.UploadButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CancelButton.Location = New System.Drawing.Point(94, 239)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(95, 23)
        Me.CancelButton.TabIndex = 20
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ShareForm
        '
        Me.AcceptButton = Me.UploadButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(301, 277)
        Me.Controls.Add(Me.UploadButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AuthorTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameTextbox)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShareForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Share"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AuthorTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UploadButton As Button
    Friend WithEvents CancelButton As Button
End Class
