<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadCompletedDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadCompletedDialog))
        Me.btn_open = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_dismiss = New System.Windows.Forms.Button()
        Me.btn_dir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_open
        '
        Me.btn_open.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btn_open.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_open.Location = New System.Drawing.Point(237, 100)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(75, 23)
        Me.btn_open.TabIndex = 25
        Me.btn_open.Text = "Open"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(300, 25)
        Me.TextBox1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(9, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Download completed."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "The colorset has been downloaded to"
        '
        'btn_dismiss
        '
        Me.btn_dismiss.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.btn_dismiss.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_dismiss.Location = New System.Drawing.Point(156, 100)
        Me.btn_dismiss.Name = "btn_dismiss"
        Me.btn_dismiss.Size = New System.Drawing.Size(75, 23)
        Me.btn_dismiss.TabIndex = 27
        Me.btn_dismiss.Text = "Dismiss"
        Me.btn_dismiss.UseVisualStyleBackColor = True
        '
        'btn_dir
        '
        Me.btn_dir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_dir.Location = New System.Drawing.Point(287, 60)
        Me.btn_dir.Name = "btn_dir"
        Me.btn_dir.Size = New System.Drawing.Size(24, 23)
        Me.btn_dir.TabIndex = 28
        Me.btn_dir.Text = "..."
        Me.btn_dir.UseVisualStyleBackColor = True
        '
        'DownloadCompletedDialog
        '
        Me.AcceptButton = Me.btn_open
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.btn_dismiss
        Me.ClientSize = New System.Drawing.Size(327, 135)
        Me.Controls.Add(Me.btn_dir)
        Me.Controls.Add(Me.btn_dismiss)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DownloadCompletedDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_open As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_dismiss As Button
    Friend WithEvents btn_dir As Button
End Class
