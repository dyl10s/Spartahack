<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginUpdated
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginUpdated))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblBusiness = New System.Windows.Forms.Label()
        Me.pbLoader = New System.Windows.Forms.PictureBox()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
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
        'txtEmail
        '
        Me.txtEmail.BorderColorFocused = System.Drawing.Color.White
        Me.txtEmail.BorderColorIdle = System.Drawing.Color.White
        Me.txtEmail.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtEmail.BorderThickness = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Transparent
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(51, 178)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(293, 54)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.BorderColorFocused = System.Drawing.Color.White
        Me.txtPassword.BorderColorIdle = System.Drawing.Color.White
        Me.txtPassword.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtPassword.BorderThickness = 3
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Transparent
        Me.txtPassword.isPassword = True
        Me.txtPassword.Location = New System.Drawing.Point(51, 258)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(293, 54)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.White
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
        Me.btnLogin.Location = New System.Drawing.Point(73, 358)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.White
        Me.btnLogin.OnHovercolor = System.Drawing.Color.Silver
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(241, 48)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.Black
        Me.btnLogin.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRegister
        '
        Me.btnRegister.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRegister.BackColor = System.Drawing.Color.White
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
        Me.btnRegister.Location = New System.Drawing.Point(73, 413)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Normalcolor = System.Drawing.Color.White
        Me.btnRegister.OnHovercolor = System.Drawing.Color.Silver
        Me.btnRegister.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.selected = False
        Me.btnRegister.Size = New System.Drawing.Size(241, 48)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegister.Textcolor = System.Drawing.Color.Black
        Me.btnRegister.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblBusiness
        '
        Me.lblBusiness.AutoSize = True
        Me.lblBusiness.BackColor = System.Drawing.Color.Transparent
        Me.lblBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBusiness.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusiness.ForeColor = System.Drawing.Color.White
        Me.lblBusiness.Location = New System.Drawing.Point(137, 478)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(111, 15)
        Me.lblBusiness.TabIndex = 23
        Me.lblBusiness.Text = "Business Client"
        '
        'pbLoader
        '
        Me.pbLoader.Image = CType(resources.GetObject("pbLoader.Image"), System.Drawing.Image)
        Me.pbLoader.Location = New System.Drawing.Point(140, 318)
        Me.pbLoader.Name = "pbLoader"
        Me.pbLoader.Size = New System.Drawing.Size(100, 34)
        Me.pbLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLoader.TabIndex = 7
        Me.pbLoader.TabStop = False
        Me.pbLoader.Visible = False
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(318, 6)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 30)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 6
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(357, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 5
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(-50, 14)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(489, 193)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 9
        Me.pbLogo.TabStop = False
        '
        'frmLoginUpdated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(397, 522)
        Me.Controls.Add(Me.lblBusiness)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbLoader)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.pbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoginUpdated"
        Me.Text = "frmLoginUpdated"
        CType(Me.pbLoader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pbLoader As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblBusiness As Label
End Class
