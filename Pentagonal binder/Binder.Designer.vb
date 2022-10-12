<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Binder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Binder))
        Me.L1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.penis = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Button2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.penis.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AllowDrop = True
        Me.L1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.L1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.L1.ContextMenuStrip = Me.penis
        Me.L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.L1.ForeColor = System.Drawing.Color.White
        Me.L1.FullRowSelect = True
        Me.L1.HideSelection = False
        Me.L1.Location = New System.Drawing.Point(0, 0)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(572, 283)
        Me.L1.TabIndex = 34
        Me.L1.UseCompatibleStateImageBehavior = False
        Me.L1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Path"
        Me.ColumnHeader1.Width = 107
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        Me.ColumnHeader2.Width = 101
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Run"
        Me.ColumnHeader3.Width = 123
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Run Once"
        Me.ColumnHeader4.Width = 1090
        '
        'penis
        '
        Me.penis.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.penis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.penis.ImageScalingSize = New System.Drawing.Size(29, 29)
        Me.penis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem6, Me.ToolStripMenuItem9})
        Me.penis.Margin = New System.Windows.Forms.Padding(3)
        Me.penis.Name = "guna2ContextMenuStrip1"
        Me.penis.RenderStyle.ArrowColor = System.Drawing.Color.DimGray
        Me.penis.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.penis.RenderStyle.ColorTable = Nothing
        Me.penis.RenderStyle.RoundedEdges = True
        Me.penis.RenderStyle.SelectionArrowColor = System.Drawing.Color.DimGray
        Me.penis.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.penis.RenderStyle.SelectionForeColor = System.Drawing.Color.DimGray
        Me.penis.RenderStyle.SeparatorColor = System.Drawing.Color.Silver
        Me.penis.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.penis.Size = New System.Drawing.Size(130, 114)
        Me.penis.Text = "Сбросить логи"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem1.Text = "Add"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem2.Text = "Delete"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem3.Text = "Run Once"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem4.Text = "Run"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem5.Text = "Upload + delete"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8})
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem6.Text = "Run"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem7.Text = "Run"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem8.Text = "Upload + delete"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem9.Text = "Clear"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(572, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 283)
        Me.Panel1.TabIndex = 35
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(64, 21)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(103, 71)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 165
        Me.Guna2PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button2.BorderThickness = 1
        Me.Button2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Button2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button2.HoverState.ForeColor = System.Drawing.Color.LightGray
        Me.Button2.Location = New System.Drawing.Point(0, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 39)
        Me.Button2.TabIndex = 164
        Me.Button2.Text = "Build"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"%Temp%", "%AppData%", "%Userprofile%", "%Allusersprofile%", "%Public%", "%ProgramData%", "%LocalAppdata%", "%Current%"})
        Me.ComboBox2.Location = New System.Drawing.Point(55, 107)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox2.TabIndex = 31
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(55, 147)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Properties"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Path : "
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(55, 164)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "Icon"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(135, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(20, 20)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'VisualStyler1
        '
        Me.VisualStyler1.HostForm = Me
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.TargetControls = SkinSoft.VisualStyler.TargetControls.Forms
        Me.VisualStyler1.LoadVisualStyle(Nothing, "Sustenance (Ergo).vssf")
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(195, 218)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(21, 20)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 208
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2HtmlToolTip1.SetToolTip(Me.Guna2PictureBox2, "Please enter an empty name for the linked file, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "otherwise the properties may sh" &
        "ow that the file's initial name was ""your file name""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.AutoPopDelay = 15000
        Me.Guna2HtmlToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2HtmlToolTip1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2HtmlToolTip1.InitialDelay = 500
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Guna2HtmlToolTip1.ReshowDelay = 100
        Me.Guna2HtmlToolTip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.Guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.LightGray
        '
        'Binder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 283)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Binder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Binder"
        Me.penis.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents L1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Private WithEvents Button2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Private WithEvents penis As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
