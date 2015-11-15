<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_load = New System.Windows.Forms.Panel()
        Me.btn_new = New System.Windows.Forms.Panel()
        Me.btn_about = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(604, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Version 1"
        '
        'btn_load
        '
        Me.btn_load.BackColor = System.Drawing.Color.Transparent
        Me.btn_load.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_load.Location = New System.Drawing.Point(12, 348)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(189, 52)
        Me.btn_load.TabIndex = 1
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.Transparent
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.Location = New System.Drawing.Point(250, 348)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(189, 52)
        Me.btn_new.TabIndex = 2
        '
        'btn_about
        '
        Me.btn_about.BackColor = System.Drawing.Color.Transparent
        Me.btn_about.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_about.Location = New System.Drawing.Point(478, 348)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(189, 52)
        Me.btn_about.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(684, 412)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_load As Panel
    Friend WithEvents btn_new As Panel
    Friend WithEvents btn_about As Panel
End Class
