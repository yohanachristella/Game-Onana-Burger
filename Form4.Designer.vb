<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPetunjuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPetunjuk))
        Me.LBJudulPetunjuk = New System.Windows.Forms.Label()
        Me.TimerJdlPetunjuk = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbInstruksi = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBJudulPetunjuk
        '
        Me.LBJudulPetunjuk.AutoSize = True
        Me.LBJudulPetunjuk.BackColor = System.Drawing.Color.Transparent
        Me.LBJudulPetunjuk.Font = New System.Drawing.Font("Lucida Handwriting", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBJudulPetunjuk.Location = New System.Drawing.Point(181, 24)
        Me.LBJudulPetunjuk.Name = "LBJudulPetunjuk"
        Me.LBJudulPetunjuk.Size = New System.Drawing.Size(458, 37)
        Me.LBJudulPetunjuk.TabIndex = 0
        Me.LBJudulPetunjuk.Text = "HOW TO PLAY THIS GAME?"
        '
        'TimerJdlPetunjuk
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnPlay)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.LbInstruksi)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(179, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Game Instructions"
        '
        'BtnPlay
        '
        Me.BtnPlay.BackColor = System.Drawing.Color.Violet
        Me.BtnPlay.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlay.Location = New System.Drawing.Point(146, 274)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(154, 43)
        Me.BtnPlay.TabIndex = 5
        Me.BtnPlay.Text = "PLAY GAME!"
        Me.BtnPlay.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(183, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LbInstruksi
        '
        Me.LbInstruksi.Location = New System.Drawing.Point(9, 34)
        Me.LbInstruksi.Name = "LbInstruksi"
        Me.LbInstruksi.Size = New System.Drawing.Size(445, 299)
        Me.LbInstruksi.TabIndex = 0
        '
        'FormPetunjuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(782, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBJudulPetunjuk)
        Me.Name = "FormPetunjuk"
        Me.Text = "Form Petunjuk "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBJudulPetunjuk As System.Windows.Forms.Label
    Friend WithEvents TimerJdlPetunjuk As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbInstruksi As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnPlay As System.Windows.Forms.Button
End Class
