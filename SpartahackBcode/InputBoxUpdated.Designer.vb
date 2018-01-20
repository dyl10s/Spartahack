<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBoxUpdated
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputBoxUpdated))
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bunGradPan = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.txtFileLink = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bunGradPan.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(379, 12)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 30)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 26
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(418, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 25
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'bunGradPan
        '
        Me.bunGradPan.BackColor = System.Drawing.Color.White
        Me.bunGradPan.BackgroundImage = CType(resources.GetObject("bunGradPan.BackgroundImage"), System.Drawing.Image)
        Me.bunGradPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunGradPan.Controls.Add(Me.btnMin)
        Me.bunGradPan.Controls.Add(Me.btnExit)
        Me.bunGradPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunGradPan.GradientBottomLeft = System.Drawing.Color.White
        Me.bunGradPan.GradientBottomRight = System.Drawing.Color.White
        Me.bunGradPan.GradientTopLeft = System.Drawing.Color.White
        Me.bunGradPan.GradientTopRight = System.Drawing.Color.White
        Me.bunGradPan.Location = New System.Drawing.Point(0, 0)
        Me.bunGradPan.Name = "bunGradPan"
        Me.bunGradPan.Quality = 10
        Me.bunGradPan.Size = New System.Drawing.Size(460, 51)
        Me.bunGradPan.TabIndex = 27
        '
        'lblFile
        '
        Me.lblFile.BackColor = System.Drawing.Color.Transparent
        Me.lblFile.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(12, 54)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(441, 76)
        Me.lblFile.TabIndex = 28
        Me.lblFile.Text = "What would you like your link to be called? Ex: LinkedIn, Personal Website, etc."
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFileLink
        '
        Me.txtFileLink.BackColor = System.Drawing.Color.Silver
        Me.txtFileLink.BorderColorFocused = System.Drawing.Color.Black
        Me.txtFileLink.BorderColorIdle = System.Drawing.Color.Black
        Me.txtFileLink.BorderColorMouseHover = System.Drawing.Color.Black
        Me.txtFileLink.BorderThickness = 3
        Me.txtFileLink.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileLink.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileLink.ForeColor = System.Drawing.Color.Black
        Me.txtFileLink.isPassword = False
        Me.txtFileLink.Location = New System.Drawing.Point(50, 135)
        Me.txtFileLink.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtFileLink.Name = "txtFileLink"
        Me.txtFileLink.Size = New System.Drawing.Size(347, 48)
        Me.txtFileLink.TabIndex = 29
        Me.txtFileLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Create"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(50, 201)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(121, 48)
        Me.BunifuFlatButton1.TabIndex = 30
        Me.BunifuFlatButton1.Text = "Create"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 7
        Me.BunifuFlatButton2.ButtonText = "Exit"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(276, 201)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(121, 48)
        Me.BunifuFlatButton2.TabIndex = 31
        Me.BunifuFlatButton2.Text = "Exit"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InputBoxUpdated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(460, 280)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.txtFileLink)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.bunGradPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InputBoxUpdated"
        Me.Text = "InputBox"
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bunGradPan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bunGradPan As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lblFile As Label
    Friend WithEvents txtFileLink As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
End Class
