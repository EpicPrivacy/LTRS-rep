<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainHome
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Me.Guna2Panel1.Location = New System.Drawing.Point(454, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Me.Guna2Panel1.Size = New System.Drawing.Size(525, 633)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = Global.LTRS.My.Resources.Resources.logo_no_background1
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(28, 172)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(381, 281)
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'MainHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 631)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainHome"
        Me.Text = "MainHome"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
