<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusinessLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusinessLogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblBusiness = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblBus = New System.Windows.Forms.Label()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pbLoader = New System.Windows.Forms.PictureBox()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        CType(Me.pbLoader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'lblBusiness
        '
        Me.lblBusiness.AutoSize = True
        Me.lblBusiness.BackColor = System.Drawing.Color.Transparent
        Me.lblBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBusiness.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusiness.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBusiness.Location = New System.Drawing.Point(130, 487)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(121, 15)
        Me.lblBusiness.TabIndex = 6
        Me.lblBusiness.Text = "Consumer Client"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 48)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRegister.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.BorderRadius = 7
        Me.btnRegister.ButtonText = "Register"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.DisabledColor = System.Drawing.Color.Gray
        Me.btnRegister.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegister.Iconimage = Nothing
        Me.btnRegister.Iconimage_right = Nothing
        Me.btnRegister.Iconimage_right_Selected = Nothing
        Me.btnRegister.Iconimage_Selected = Nothing
        Me.btnRegister.IconMarginLeft = 0
        Me.btnRegister.IconMarginRight = 0
        Me.btnRegister.IconRightVisible = True
        Me.btnRegister.IconRightZoom = 0R
        Me.btnRegister.IconVisible = True
        Me.btnRegister.IconZoom = 90.0R
        Me.btnRegister.IsTab = False
        Me.btnRegister.Location = New System.Drawing.Point(201, 365)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.btnRegister.OnHovercolor = System.Drawing.SystemColors.Highlight
        Me.btnRegister.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegister.selected = False
        Me.btnRegister.Size = New System.Drawing.Size(115, 48)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegister.Textcolor = System.Drawing.Color.White
        Me.btnRegister.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 7
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = Nothing
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0R
        Me.btnLogin.IconVisible = True
        Me.btnLogin.IconZoom = 90.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(75, 365)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.btnLogin.OnHovercolor = System.Drawing.SystemColors.Highlight
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(118, 48)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtEmail.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtEmail.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtEmail.BorderThickness = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(53, 180)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(293, 54)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBus
        '
        Me.lblBus.AutoSize = True
        Me.lblBus.BackColor = System.Drawing.Color.Transparent
        Me.lblBus.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBus.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBus.Location = New System.Drawing.Point(127, 125)
        Me.lblBus.Name = "lblBus"
        Me.lblBus.Size = New System.Drawing.Size(132, 31)
        Me.lblBus.TabIndex = 34
        Me.lblBus.Text = "Business"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BorderColorFocused = System.Drawing.SystemColors.HotTrack
        Me.txtPass.BorderColorIdle = System.Drawing.SystemColors.HotTrack
        Me.txtPass.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack
        Me.txtPass.BorderThickness = 3
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.isPassword = True
        Me.txtPass.Location = New System.Drawing.Point(53, 263)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(293, 54)
        Me.txtPass.TabIndex = 2
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Continue as guest"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(75, 419)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.Highlight
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(241, 48)
        Me.BunifuFlatButton1.TabIndex = 5
        Me.BunifuFlatButton1.Text = "Continue as guest"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pbLoader
        '
        Me.pbLoader.Image = CType(resources.GetObject("pbLoader.Image"), System.Drawing.Image)
        Me.pbLoader.Location = New System.Drawing.Point(142, 325)
        Me.pbLoader.Name = "pbLoader"
        Me.pbLoader.Size = New System.Drawing.Size(100, 34)
        Me.pbLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLoader.TabIndex = 30
        Me.pbLoader.TabStop = False
        Me.pbLoader.Visible = False
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(320, 4)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 30)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 29
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(359, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 28
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(-46, 7)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(489, 193)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 32
        Me.pbLogo.TabStop = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(170, 161)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 19)
        Me.lblEmail.TabIndex = 35
        Me.lblEmail.Text = "Email"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.Black
        Me.lblPass.Location = New System.Drawing.Point(158, 246)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(90, 19)
        Me.lblPass.TabIndex = 36
        Me.lblPass.Text = "Password"
        '
        'frmBusinessLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 522)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblBus)
        Me.Controls.Add(Me.lblBusiness)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbLoader)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.pbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBusinessLogin"
        Me.Text = "frmBusinessLogin"
        CType(Me.pbLoader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblBusiness As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pbLoader As PictureBox
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblBus As Label
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblPass As Label
    Friend WithEvents lblEmail As Label
End Class
