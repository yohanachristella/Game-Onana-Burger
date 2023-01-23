<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.TimerJudul = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnPetunjuk = New System.Windows.Forms.Button()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.WMP1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WMP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.burger_122
        Me.PictureBox1.Location = New System.Drawing.Point(141, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.BackColor = System.Drawing.Color.Transparent
        Me.LbJudul.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(231, 23)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(361, 48)
        Me.LbJudul.TabIndex = 1
        Me.LbJudul.Text = "ONANA BURGER"
        Me.LbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerJudul
        '
        Me.TimerJudul.Enabled = True
        Me.TimerJudul.Interval = 200
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Violet
        Me.BtnLogin.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(484, 359)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(154, 43)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "QUIT"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnPetunjuk
        '
        Me.BtnPetunjuk.BackColor = System.Drawing.Color.Violet
        Me.BtnPetunjuk.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPetunjuk.Location = New System.Drawing.Point(119, 359)
        Me.BtnPetunjuk.Name = "BtnPetunjuk"
        Me.BtnPetunjuk.Size = New System.Drawing.Size(154, 43)
        Me.BtnPetunjuk.TabIndex = 3
        Me.BtnPetunjuk.Text = "HOW TO PLAY"
        Me.BtnPetunjuk.UseVisualStyleBackColor = False
        '
        'BtnPlay
        '
        Me.BtnPlay.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnPlay.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlay.Location = New System.Drawing.Point(303, 357)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(161, 52)
        Me.BtnPlay.TabIndex = 5
        Me.BtnPlay.Text = "PLAY GAME!"
        Me.BtnPlay.UseVisualStyleBackColor = False
        '
        'WMP1
        '
        Me.WMP1.Enabled = True
        Me.WMP1.Location = New System.Drawing.Point(727, 397)
        Me.WMP1.Name = "WMP1"
        Me.WMP1.OcxState = CType(resources.GetObject("WMP1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP1.Size = New System.Drawing.Size(43, 32)
        Me.WMP1.TabIndex = 6
        Me.WMP1.Visible = False
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(782, 441)
        Me.Controls.Add(Me.WMP1)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.BtnPetunjuk)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LbJudul)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormHome"
        Me.Text = "Form Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WMP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents TimerJudul As System.Windows.Forms.Timer
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnPetunjuk As System.Windows.Forms.Button
    Friend WithEvents BtnPlay As System.Windows.Forms.Button
    Friend WithEvents WMP1 As AxWMPLib.AxWindowsMediaPlayer

End Class
