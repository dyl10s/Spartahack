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
        'InputBoxUpdated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 276)
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
End Class
