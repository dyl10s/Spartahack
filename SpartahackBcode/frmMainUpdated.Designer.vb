<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainUpdated
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainUpdated))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pLink = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtInfoLink = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.bunGradPan = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblConnectLink = New System.Windows.Forms.Label()
        Me.lblUploadFile = New System.Windows.Forms.Label()
        Me.btnLink = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnFileUpload = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSignOut = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pFile = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnFindFile = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtFileLink = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pLink.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bunGradPan.SuspendLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFileUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSignOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pFile.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'pLink
        '
        Me.pLink.BackColor = System.Drawing.Color.Silver
        Me.pLink.BackgroundImage = CType(resources.GetObject("pLink.BackgroundImage"), System.Drawing.Image)
        Me.pLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pLink.Controls.Add(Me.BunifuImageButton1)
        Me.pLink.Controls.Add(Me.btnSubmit)
        Me.pLink.Controls.Add(Me.txtInfoLink)
        Me.pLink.Controls.Add(Me.lblLink)
        Me.pLink.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pLink.GradientBottomLeft = System.Drawing.Color.White
        Me.pLink.GradientBottomRight = System.Drawing.Color.White
        Me.pLink.GradientTopLeft = System.Drawing.Color.White
        Me.pLink.GradientTopRight = System.Drawing.Color.White
        Me.pLink.Location = New System.Drawing.Point(0, 474)
        Me.pLink.Name = "pLink"
        Me.pLink.Quality = 10
        Me.pLink.Size = New System.Drawing.Size(861, 72)
        Me.pLink.TabIndex = 1
        Me.pLink.Visible = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.SpartahackBcode.My.Resources.Resources.Garbage
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(802, 15)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(45, 45)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmit.BackColor = System.Drawing.Color.Silver
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
        Me.btnSubmit.Location = New System.Drawing.Point(654, 15)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Normalcolor = System.Drawing.Color.Silver
        Me.btnSubmit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmit.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnSubmit.selected = False
        Me.btnSubmit.Size = New System.Drawing.Size(121, 48)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSubmit.Textcolor = System.Drawing.Color.Black
        Me.btnSubmit.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtInfoLink
        '
        Me.txtInfoLink.BackColor = System.Drawing.Color.White
        Me.txtInfoLink.BorderColorFocused = System.Drawing.Color.Black
        Me.txtInfoLink.BorderColorIdle = System.Drawing.Color.Black
        Me.txtInfoLink.BorderColorMouseHover = System.Drawing.Color.Black
        Me.txtInfoLink.BorderThickness = 3
        Me.txtInfoLink.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInfoLink.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoLink.ForeColor = System.Drawing.Color.Black
        Me.txtInfoLink.isPassword = False
        Me.txtInfoLink.Location = New System.Drawing.Point(93, 21)
        Me.txtInfoLink.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtInfoLink.Name = "txtInfoLink"
        Me.txtInfoLink.Size = New System.Drawing.Size(538, 30)
        Me.txtInfoLink.TabIndex = 19
        Me.txtInfoLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.BackColor = System.Drawing.Color.Transparent
        Me.lblLink.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLink.Location = New System.Drawing.Point(12, 26)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(62, 21)
        Me.lblLink.TabIndex = 0
        Me.lblLink.Text = "Link:"
        '
        'bunGradPan
        '
        Me.bunGradPan.BackgroundImage = CType(resources.GetObject("bunGradPan.BackgroundImage"), System.Drawing.Image)
        Me.bunGradPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunGradPan.Controls.Add(Me.Label1)
        Me.bunGradPan.Controls.Add(Me.btnMin)
        Me.bunGradPan.Controls.Add(Me.btnExit)
        Me.bunGradPan.Controls.Add(Me.lblConnectLink)
        Me.bunGradPan.Controls.Add(Me.lblUploadFile)
        Me.bunGradPan.Controls.Add(Me.btnLink)
        Me.bunGradPan.Controls.Add(Me.btnFileUpload)
        Me.bunGradPan.Controls.Add(Me.btnSignOut)
        Me.bunGradPan.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunGradPan.GradientBottomLeft = System.Drawing.Color.White
        Me.bunGradPan.GradientBottomRight = System.Drawing.Color.White
        Me.bunGradPan.GradientTopLeft = System.Drawing.Color.White
        Me.bunGradPan.GradientTopRight = System.Drawing.Color.White
        Me.bunGradPan.Location = New System.Drawing.Point(0, 0)
        Me.bunGradPan.Name = "bunGradPan"
        Me.bunGradPan.Quality = 10
        Me.bunGradPan.Size = New System.Drawing.Size(861, 62)
        Me.bunGradPan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Sign Out"
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(786, 4)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 30)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 24
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(825, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 23
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'lblConnectLink
        '
        Me.lblConnectLink.AutoSize = True
        Me.lblConnectLink.BackColor = System.Drawing.Color.Transparent
        Me.lblConnectLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblConnectLink.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectLink.Location = New System.Drawing.Point(217, 21)
        Me.lblConnectLink.Name = "lblConnectLink"
        Me.lblConnectLink.Size = New System.Drawing.Size(141, 21)
        Me.lblConnectLink.TabIndex = 22
        Me.lblConnectLink.Text = "Connect Link"
        '
        'lblUploadFile
        '
        Me.lblUploadFile.AutoSize = True
        Me.lblUploadFile.BackColor = System.Drawing.Color.Transparent
        Me.lblUploadFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUploadFile.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUploadFile.Location = New System.Drawing.Point(424, 21)
        Me.lblUploadFile.Name = "lblUploadFile"
        Me.lblUploadFile.Size = New System.Drawing.Size(122, 21)
        Me.lblUploadFile.TabIndex = 21
        Me.lblUploadFile.Text = "Upload File"
        '
        'btnLink
        '
        Me.btnLink.BackColor = System.Drawing.Color.Transparent
        Me.btnLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLink.Image = CType(resources.GetObject("btnLink.Image"), System.Drawing.Image)
        Me.btnLink.ImageActive = Nothing
        Me.btnLink.Location = New System.Drawing.Point(181, 16)
        Me.btnLink.Name = "btnLink"
        Me.btnLink.Size = New System.Drawing.Size(30, 30)
        Me.btnLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLink.TabIndex = 2
        Me.btnLink.TabStop = False
        Me.btnLink.Zoom = 10
        '
        'btnFileUpload
        '
        Me.btnFileUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnFileUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFileUpload.Image = CType(resources.GetObject("btnFileUpload.Image"), System.Drawing.Image)
        Me.btnFileUpload.ImageActive = Nothing
        Me.btnFileUpload.Location = New System.Drawing.Point(388, 16)
        Me.btnFileUpload.Name = "btnFileUpload"
        Me.btnFileUpload.Size = New System.Drawing.Size(30, 30)
        Me.btnFileUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFileUpload.TabIndex = 1
        Me.btnFileUpload.TabStop = False
        Me.btnFileUpload.Zoom = 10
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.Color.Transparent
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.Image = Global.SpartahackBcode.My.Resources.Resources._Exit
        Me.btnSignOut.ImageActive = Nothing
        Me.btnSignOut.Location = New System.Drawing.Point(8, 16)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(30, 30)
        Me.btnSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSignOut.TabIndex = 0
        Me.btnSignOut.TabStop = False
        Me.btnSignOut.Zoom = 10
        '
        'pFile
        '
        Me.pFile.BackColor = System.Drawing.Color.Silver
        Me.pFile.BackgroundImage = CType(resources.GetObject("pFile.BackgroundImage"), System.Drawing.Image)
        Me.pFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pFile.Controls.Add(Me.btnFindFile)
        Me.pFile.Controls.Add(Me.BunifuImageButton2)
        Me.pFile.Controls.Add(Me.BunifuFlatButton1)
        Me.pFile.Controls.Add(Me.txtFileLink)
        Me.pFile.Controls.Add(Me.lblFile)
        Me.pFile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pFile.GradientBottomLeft = System.Drawing.Color.White
        Me.pFile.GradientBottomRight = System.Drawing.Color.White
        Me.pFile.GradientTopLeft = System.Drawing.Color.White
        Me.pFile.GradientTopRight = System.Drawing.Color.White
        Me.pFile.Location = New System.Drawing.Point(0, 402)
        Me.pFile.Name = "pFile"
        Me.pFile.Quality = 10
        Me.pFile.Size = New System.Drawing.Size(861, 72)
        Me.pFile.TabIndex = 2
        Me.pFile.Visible = False
        '
        'btnFindFile
        '
        Me.btnFindFile.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFindFile.BackColor = System.Drawing.Color.Silver
        Me.btnFindFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindFile.BorderRadius = 7
        Me.btnFindFile.ButtonText = "..."
        Me.btnFindFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindFile.DisabledColor = System.Drawing.Color.Gray
        Me.btnFindFile.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindFile.ForeColor = System.Drawing.Color.White
        Me.btnFindFile.Iconcolor = System.Drawing.Color.Transparent
        Me.btnFindFile.Iconimage = Nothing
        Me.btnFindFile.Iconimage_right = Nothing
        Me.btnFindFile.Iconimage_right_Selected = Nothing
        Me.btnFindFile.Iconimage_Selected = Nothing
        Me.btnFindFile.IconMarginLeft = 0
        Me.btnFindFile.IconMarginRight = 0
        Me.btnFindFile.IconRightVisible = True
        Me.btnFindFile.IconRightZoom = 0R
        Me.btnFindFile.IconVisible = True
        Me.btnFindFile.IconZoom = 90.0R
        Me.btnFindFile.IsTab = False
        Me.btnFindFile.Location = New System.Drawing.Point(565, 17)
        Me.btnFindFile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFindFile.Name = "btnFindFile"
        Me.btnFindFile.Normalcolor = System.Drawing.Color.Silver
        Me.btnFindFile.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFindFile.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnFindFile.selected = False
        Me.btnFindFile.Size = New System.Drawing.Size(81, 39)
        Me.btnFindFile.TabIndex = 20
        Me.btnFindFile.Text = "..."
        Me.btnFindFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFindFile.Textcolor = System.Drawing.Color.Black
        Me.btnFindFile.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.SpartahackBcode.My.Resources.Resources.Garbage
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(802, 15)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(45, 45)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 1
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Submit"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(654, 12)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(121, 48)
        Me.BunifuFlatButton1.TabIndex = 4
        Me.BunifuFlatButton1.Text = "Submit"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtFileLink
        '
        Me.txtFileLink.BackColor = System.Drawing.Color.White
        Me.txtFileLink.BorderColorFocused = System.Drawing.Color.Black
        Me.txtFileLink.BorderColorIdle = System.Drawing.Color.Black
        Me.txtFileLink.BorderColorMouseHover = System.Drawing.Color.Black
        Me.txtFileLink.BorderThickness = 3
        Me.txtFileLink.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileLink.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileLink.ForeColor = System.Drawing.Color.Black
        Me.txtFileLink.isPassword = False
        Me.txtFileLink.Location = New System.Drawing.Point(93, 21)
        Me.txtFileLink.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFileLink.Name = "txtFileLink"
        Me.txtFileLink.Size = New System.Drawing.Size(463, 30)
        Me.txtFileLink.TabIndex = 19
        Me.txtFileLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.BackColor = System.Drawing.Color.Transparent
        Me.lblFile.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(12, 26)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(53, 21)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "File:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 62)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(861, 340)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMainUpdated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 546)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.pFile)
        Me.Controls.Add(Me.pLink)
        Me.Controls.Add(Me.bunGradPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainUpdated"
        Me.Text = "frmMainUpdated"
        Me.pLink.ResumeLayout(False)
        Me.pLink.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bunGradPan.ResumeLayout(False)
        Me.bunGradPan.PerformLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFileUpload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSignOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pFile.ResumeLayout(False)
        Me.pFile.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bunGradPan As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pLink As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnSignOut As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblLink As Label
    Friend WithEvents txtInfoLink As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pFile As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtFileLink As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblFile As Label
    Friend WithEvents btnFindFile As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblConnectLink As Label
    Friend WithEvents lblUploadFile As Label
    Friend WithEvents btnLink As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnFileUpload As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
