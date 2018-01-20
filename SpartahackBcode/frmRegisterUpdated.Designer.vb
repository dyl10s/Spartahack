<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterUpdated
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterUpdated))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblRptPass = New System.Windows.Forms.Label()
        Me.txtRetryPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtBCODE = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblBCODE = New System.Windows.Forms.Label()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(448, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(489, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 7
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageActive = Nothing
        Me.btnBack.Location = New System.Drawing.Point(3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(51, 54)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 9
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'txtEmail
        '
        Me.txtEmail.BorderColorFocused = System.Drawing.Color.White
        Me.txtEmail.BorderColorIdle = System.Drawing.Color.White
        Me.txtEmail.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtEmail.BorderThickness = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Transparent
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(141, 85)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(235, 30)
        Me.txtEmail.TabIndex = 10
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Silver
        Me.lblEmail.Location = New System.Drawing.Point(221, 62)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 19)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Silver
        Me.lblPassword.Location = New System.Drawing.Point(97, 120)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(90, 19)
        Me.lblPassword.TabIndex = 13
        Me.lblPassword.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.BorderColorFocused = System.Drawing.Color.White
        Me.txtPass.BorderColorIdle = System.Drawing.Color.White
        Me.txtPass.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtPass.BorderThickness = 3
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Transparent
        Me.txtPass.isPassword = True
        Me.txtPass.Location = New System.Drawing.Point(3, 140)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(235, 30)
        Me.txtPass.TabIndex = 12
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblRptPass
        '
        Me.lblRptPass.AutoSize = True
        Me.lblRptPass.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptPass.ForeColor = System.Drawing.Color.Silver
        Me.lblRptPass.Location = New System.Drawing.Point(323, 120)
        Me.lblRptPass.Name = "lblRptPass"
        Me.lblRptPass.Size = New System.Drawing.Size(149, 19)
        Me.lblRptPass.TabIndex = 15
        Me.lblRptPass.Text = "Repeat Password"
        '
        'txtRetryPass
        '
        Me.txtRetryPass.BorderColorFocused = System.Drawing.Color.White
        Me.txtRetryPass.BorderColorIdle = System.Drawing.Color.White
        Me.txtRetryPass.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtRetryPass.BorderThickness = 3
        Me.txtRetryPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRetryPass.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetryPass.ForeColor = System.Drawing.Color.Transparent
        Me.txtRetryPass.isPassword = True
        Me.txtRetryPass.Location = New System.Drawing.Point(252, 140)
        Me.txtRetryPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtRetryPass.Name = "txtRetryPass"
        Me.txtRetryPass.Size = New System.Drawing.Size(235, 30)
        Me.txtRetryPass.TabIndex = 14
        Me.txtRetryPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Silver
        Me.lblLastName.Location = New System.Drawing.Point(352, 185)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(92, 19)
        Me.lblLastName.TabIndex = 19
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BorderColorFocused = System.Drawing.Color.White
        Me.txtLastName.BorderColorIdle = System.Drawing.Color.White
        Me.txtLastName.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtLastName.BorderThickness = 3
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Transparent
        Me.txtLastName.isPassword = False
        Me.txtLastName.Location = New System.Drawing.Point(252, 205)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(235, 30)
        Me.txtLastName.TabIndex = 18
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Silver
        Me.lblFirstName.Location = New System.Drawing.Point(93, 185)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(99, 19)
        Me.lblFirstName.TabIndex = 17
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColorFocused = System.Drawing.Color.White
        Me.txtFirstName.BorderColorIdle = System.Drawing.Color.White
        Me.txtFirstName.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtFirstName.BorderThickness = 3
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Transparent
        Me.txtFirstName.isPassword = False
        Me.txtFirstName.Location = New System.Drawing.Point(3, 205)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(235, 30)
        Me.txtFirstName.TabIndex = 16
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtBCODE
        '
        Me.txtBCODE.BorderColorFocused = System.Drawing.Color.White
        Me.txtBCODE.BorderColorIdle = System.Drawing.Color.White
        Me.txtBCODE.BorderColorMouseHover = System.Drawing.Color.White
        Me.txtBCODE.BorderThickness = 3
        Me.txtBCODE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBCODE.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBCODE.ForeColor = System.Drawing.Color.Transparent
        Me.txtBCODE.isPassword = False
        Me.txtBCODE.Location = New System.Drawing.Point(82, 283)
        Me.txtBCODE.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtBCODE.Name = "txtBCODE"
        Me.txtBCODE.Size = New System.Drawing.Size(342, 75)
        Me.txtBCODE.TabIndex = 20
        Me.txtBCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBCODE
        '
        Me.lblBCODE.AutoSize = True
        Me.lblBCODE.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCODE.ForeColor = System.Drawing.Color.Silver
        Me.lblBCODE.Location = New System.Drawing.Point(216, 259)
        Me.lblBCODE.Name = "lblBCODE"
        Me.lblBCODE.Size = New System.Drawing.Size(59, 19)
        Me.lblBCODE.TabIndex = 21
        Me.lblBCODE.Text = "bCode"
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
        Me.btnRegister.Location = New System.Drawing.Point(141, 380)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Normalcolor = System.Drawing.Color.White
        Me.btnRegister.OnHovercolor = System.Drawing.Color.Silver
        Me.btnRegister.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnRegister.selected = False
        Me.btnRegister.Size = New System.Drawing.Size(241, 48)
        Me.btnRegister.TabIndex = 22
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegister.Textcolor = System.Drawing.Color.Black
        Me.btnRegister.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmRegisterUpdated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(528, 462)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblBCODE)
        Me.Controls.Add(Me.txtBCODE)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblRptPass)
        Me.Controls.Add(Me.txtRetryPass)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegisterUpdated"
        Me.Text = "frmRegisterUpdated"
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblRptPass As Label
    Friend WithEvents txtRetryPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblBCODE As Label
    Friend WithEvents txtBCODE As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuFlatButton
End Class
