<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBox))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnOK = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.bunGradPan = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bunGradPan.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnOK
        '
        Me.btnOK.Activecolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOK.BackColor = System.Drawing.Color.Gray
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOK.BorderRadius = 7
        Me.btnOK.ButtonText = "Okay"
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.DisabledColor = System.Drawing.Color.Gray
        Me.btnOK.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOK.Iconimage = Nothing
        Me.btnOK.Iconimage_right = Nothing
        Me.btnOK.Iconimage_right_Selected = Nothing
        Me.btnOK.Iconimage_Selected = Nothing
        Me.btnOK.IconMarginLeft = 0
        Me.btnOK.IconMarginRight = 0
        Me.btnOK.IconRightVisible = True
        Me.btnOK.IconRightZoom = 0R
        Me.btnOK.IconVisible = True
        Me.btnOK.IconZoom = 90.0R
        Me.btnOK.IsTab = False
        Me.btnOK.Location = New System.Drawing.Point(159, 211)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Normalcolor = System.Drawing.Color.Gray
        Me.btnOK.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOK.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnOK.selected = False
        Me.btnOK.Size = New System.Drawing.Size(121, 48)
        Me.btnOK.TabIndex = 36
        Me.btnOK.Text = "Okay"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOK.Textcolor = System.Drawing.Color.Black
        Me.btnOK.TextFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(419, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 25
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'lblFile
        '
        Me.lblFile.BackColor = System.Drawing.Color.Transparent
        Me.lblFile.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(13, 74)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(441, 125)
        Me.lblFile.TabIndex = 33
        Me.lblFile.Text = "What would you like your link to be called? Ex: LinkedIn, Personal Website, etc."
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bunGradPan
        '
        Me.bunGradPan.BackColor = System.Drawing.Color.Silver
        Me.bunGradPan.BackgroundImage = CType(resources.GetObject("bunGradPan.BackgroundImage"), System.Drawing.Image)
        Me.bunGradPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.bunGradPan.TabIndex = 32
        '
        'MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(460, 280)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.bunGradPan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MessageBox"
        Me.Text = "MessageBox"
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bunGradPan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnOK As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblFile As Label
    Friend WithEvents bunGradPan As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
End Class
