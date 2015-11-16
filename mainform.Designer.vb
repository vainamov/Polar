<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorListContainer = New System.Windows.Forms.Panel()
        Me.cms_ColorListEntry = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyHEXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyRGBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyARGBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHSBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHSLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCMYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCMYKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchTextbox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_floe = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.btn_addColor = New System.Windows.Forms.Button()
        Me.cms_ColorListEntry.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Press Ctrl+N to add an entry."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ColorListContainer
        '
        Me.ColorListContainer.AllowDrop = True
        Me.ColorListContainer.AutoScroll = True
        Me.ColorListContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorListContainer.Location = New System.Drawing.Point(0, 55)
        Me.ColorListContainer.Name = "ColorListContainer"
        Me.ColorListContainer.Size = New System.Drawing.Size(301, 367)
        Me.ColorListContainer.TabIndex = 1
        '
        'cms_ColorListEntry
        '
        Me.cms_ColorListEntry.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyHEXToolStripMenuItem, Me.CopyRGBToolStripMenuItem, Me.CopyARGBToolStripMenuItem, Me.CopyHSBToolStripMenuItem, Me.CopyHSLToolStripMenuItem, Me.CopyHSIToolStripMenuItem, Me.CopyCMYToolStripMenuItem, Me.CopyCMYKToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveToolStripMenuItem})
        Me.cms_ColorListEntry.Name = "cms_ColorListEntry"
        Me.cms_ColorListEntry.ShowImageMargin = False
        Me.cms_ColorListEntry.Size = New System.Drawing.Size(127, 226)
        '
        'CopyHEXToolStripMenuItem
        '
        Me.CopyHEXToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyHEXToolStripMenuItem.Name = "CopyHEXToolStripMenuItem"
        Me.CopyHEXToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyHEXToolStripMenuItem.Text = "Copy HEX"
        '
        'CopyRGBToolStripMenuItem
        '
        Me.CopyRGBToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyRGBToolStripMenuItem.Name = "CopyRGBToolStripMenuItem"
        Me.CopyRGBToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyRGBToolStripMenuItem.Text = "Copy RGB"
        '
        'CopyARGBToolStripMenuItem
        '
        Me.CopyARGBToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyARGBToolStripMenuItem.Name = "CopyARGBToolStripMenuItem"
        Me.CopyARGBToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyARGBToolStripMenuItem.Text = "Copy ARGB"
        '
        'CopyHSBToolStripMenuItem
        '
        Me.CopyHSBToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyHSBToolStripMenuItem.Name = "CopyHSBToolStripMenuItem"
        Me.CopyHSBToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyHSBToolStripMenuItem.Text = "Copy HSB/V"
        '
        'CopyHSLToolStripMenuItem
        '
        Me.CopyHSLToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyHSLToolStripMenuItem.Name = "CopyHSLToolStripMenuItem"
        Me.CopyHSLToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyHSLToolStripMenuItem.Text = "Copy HSL"
        '
        'CopyHSIToolStripMenuItem
        '
        Me.CopyHSIToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyHSIToolStripMenuItem.Name = "CopyHSIToolStripMenuItem"
        Me.CopyHSIToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyHSIToolStripMenuItem.Text = "Copy HSI"
        '
        'CopyCMYToolStripMenuItem
        '
        Me.CopyCMYToolStripMenuItem.Enabled = False
        Me.CopyCMYToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyCMYToolStripMenuItem.Name = "CopyCMYToolStripMenuItem"
        Me.CopyCMYToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyCMYToolStripMenuItem.Text = "Copy CMY"
        '
        'CopyCMYKToolStripMenuItem
        '
        Me.CopyCMYKToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CopyCMYKToolStripMenuItem.Name = "CopyCMYKToolStripMenuItem"
        Me.CopyCMYKToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.CopyCMYKToolStripMenuItem.Text = "Copy CMYK"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'SearchTextbox
        '
        Me.SearchTextbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchTextbox.Location = New System.Drawing.Point(10, 25)
        Me.SearchTextbox.Name = "SearchTextbox"
        Me.SearchTextbox.Size = New System.Drawing.Size(280, 23)
        Me.SearchTextbox.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Controls.Add(Me.btn_floe)
        Me.Panel1.Controls.Add(Me.btn_upload)
        Me.Panel1.Controls.Add(Me.btn_addColor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 422)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 40)
        Me.Panel1.TabIndex = 3
        '
        'btn_home
        '
        Me.btn_home.BackgroundImage = CType(resources.GetObject("btn_home.BackgroundImage"), System.Drawing.Image)
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_home.Location = New System.Drawing.Point(4, 4)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(32, 32)
        Me.btn_home.TabIndex = 3
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_floe
        '
        Me.btn_floe.BackgroundImage = CType(resources.GetObject("btn_floe.BackgroundImage"), System.Drawing.Image)
        Me.btn_floe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_floe.Location = New System.Drawing.Point(118, 4)
        Me.btn_floe.Name = "btn_floe"
        Me.btn_floe.Size = New System.Drawing.Size(32, 32)
        Me.btn_floe.TabIndex = 2
        Me.btn_floe.UseVisualStyleBackColor = True
        '
        'btn_upload
        '
        Me.btn_upload.BackgroundImage = CType(resources.GetObject("btn_upload.BackgroundImage"), System.Drawing.Image)
        Me.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_upload.Location = New System.Drawing.Point(80, 4)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(32, 32)
        Me.btn_upload.TabIndex = 1
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'btn_addColor
        '
        Me.btn_addColor.BackgroundImage = CType(resources.GetObject("btn_addColor.BackgroundImage"), System.Drawing.Image)
        Me.btn_addColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_addColor.Location = New System.Drawing.Point(42, 4)
        Me.btn_addColor.Name = "btn_addColor"
        Me.btn_addColor.Size = New System.Drawing.Size(32, 32)
        Me.btn_addColor.TabIndex = 0
        Me.btn_addColor.UseVisualStyleBackColor = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(301, 462)
        Me.Controls.Add(Me.ColorListContainer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SearchTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(317, 100000)
        Me.MinimumSize = New System.Drawing.Size(317, 300)
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polar"
        Me.cms_ColorListEntry.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ColorListContainer As Panel
    Friend WithEvents cms_ColorListEntry As ContextMenuStrip
    Friend WithEvents CopyHEXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyRGBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyHSBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyARGBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyHSLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyHSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCMYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCMYKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchTextbox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_floe As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents btn_addColor As Button
    Friend WithEvents btn_home As Button
End Class
