<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBusinessBcode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusinessBcode))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblBus = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtCode = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblBCODE = New System.Windows.Forms.Label()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'lblBus
        '
        Me.lblBus.AutoSize = True
        Me.lblBus.BackColor = System.Drawing.Color.Transparent
        Me.lblBus.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBus.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBus.Location = New System.Drawing.Point(119, 132)
        Me.lblBus.Name = "lblBus"
        Me.lblBus.Size = New System.Drawing.Size(132, 31)
        Me.lblBus.TabIndex = 36
        Me.lblBus.Text = "Business"
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(-54, 14)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(489, 193)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 35
        Me.pbLogo.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmit.BorderRadius = 7
        Me.btnSubmit.ButtonText = "Submit"
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.DisabledColor = System.Drawing.Color.Gray
        Me.btnSubmit.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSubmit.Iconimage = Nothing
        Me.btnSubmit.Iconimage_right = Nothing
        Me.btnSubmit.Iconimage_right_Selected = Nothing
        Me.btnSubmit.Iconimage_Selected = Nothing
        Me.btnSubmit.IconMarginLeft = 0
        Me.btnSubmit.IconMarginRight = 0
        Me.btnSubmit.IconRightVisible = True
        Me.btnSubmit.IconRightZoom = 0R
        Me.btnSubmit.IconVisible = True
        Me.btnSubmit.IconZoom = 90.0R
        Me.btnSubmit.IsTab = False
        Me.btnSubmit.Location = New System.Drawing.Point(70, 332)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmit.OnHovercolor = System.Drawing.SystemColors.Highlight
        Me.btnSubmit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSubmit.selected = False
        Me.btnSubmit.Size = New System.Drawing.Size(241, 48)
        Me.btnSubmit.TabIndex = 38
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSubmit.Textcolor = System.Drawing.Color.White
        Me.btnSubmit.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.White
        Me.txtCode.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtCode.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtCode.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtCode.BorderThickness = 3
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.isPassword = False
        Me.txtCode.Location = New System.Drawing.Point(48, 270)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(293, 54)
        Me.txtCode.TabIndex = 37
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblBCODE
        '
        Me.lblBCODE.AutoSize = True
        Me.lblBCODE.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCODE.ForeColor = System.Drawing.Color.Gray
        Me.lblBCODE.Location = New System.Drawing.Point(161, 246)
        Me.lblBCODE.Name = "lblBCODE"
        Me.lblBCODE.Size = New System.Drawing.Size(59, 19)
        Me.lblBCODE.TabIndex = 39
        Me.lblBCODE.Text = "bCode"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageActive = Nothing
        Me.btnBack.Location = New System.Drawing.Point(2, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 31)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 40
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(320, 5)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 30)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 42
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(359, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 41
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Address Book"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(70, 426)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton1.TabIndex = 43
        Me.BunifuFlatButton1.Text = "Address Book"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmBusinessBcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 522)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblBCODE)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblBus)
        Me.Controls.Add(Me.pbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBusinessBcode"
        Me.Text = "frmBusinessBcode"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblBus As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtCode As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblBCODE As Label
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
