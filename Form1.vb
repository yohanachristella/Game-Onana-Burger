Public Class FormHome

    Dim level As Integer
    Dim waktu As Integer = 6

    Private Sub PicTruck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FormHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LbJudul.Text = ""
        TimerJudul.Start()

        WMP1.URL = "D:\01. Tugas\Visual Studio\Project UTS_0014\ProjectUTS\ProjectUTS\sugar cookie.wav"

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LbJudul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbJudul.Click

    End Sub

    Private Sub TimerJudul_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerJudul.Tick
        Select Case LbJudul.Text
            Case ""
                LbJudul.Text = "O"
            Case "O"
                LbJudul.Text = "ON"
            Case "ON"
                LbJudul.Text = "ONA"
            Case "ONA"
                LbJudul.Text = "ONAN"
            Case "ONAN"
                LbJudul.Text = "ONANA"
            Case "ONANA"
                LbJudul.Text = "ONANA "
            Case "ONANA "
                LbJudul.Text = "ONANA B"
            Case "ONANA B"
                LbJudul.Text = "ONANA BU"
            Case "ONANA BU"
                LbJudul.Text = "ONANA BUR"
            Case "ONANA BUR"
                LbJudul.Text = "ONANA BURG"
            Case "ONANA BURG"
                LbJudul.Text = "ONANA BURGE"
            Case "ONANA BURGE"
                LbJudul.Text = "ONANA BURGER"
            Case "ONANA BURGER"
                LbJudul.Text = ""
        End Select

    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Me.Hide()
    End Sub

    Private Sub BtnPlay_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnLogin.MouseMove
        BtnLogin.BackColor = Color.Aquamarine
    End Sub

    Private Sub BtnPetunjuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPetunjuk.Click
        FormPetunjuk.Show()
        Me.Hide()

    End Sub

    Private Sub BtnPetunjuk_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnPetunjuk.MouseMove
        BtnPetunjuk.BackColor = Color.Aquamarine
    End Sub

    Private Sub BtnHighScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlay.Click
        FormUtama.Show()
        Me.Hide()

        'FormUtama.TimerCD.Interval = 800
        'FormUtama.TimerCD.Start()

        
    End Sub

    
    Private Sub BtnPlay_MouseMove_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnPlay.MouseMove
        BtnPlay.BackColor = Color.Violet
    End Sub

    Private Sub WMP1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMP1.Enter

    End Sub
End Class


