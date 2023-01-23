Public Class FormPetunjuk

    Private Sub FormPetunjuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBJudulPetunjuk.Text = ""
        TimerJdlPetunjuk.Start()

        LbInstruksi.Text = "1. Select the burger stuffing based on the menu display." & vbNewLine & "2. Click on each of the burger stuffing pictures to select." & vbNewLine & "3. Click the bell in the lower right corner to serve the burgers." & vbNewLine & "4. Pay attention to the running time." & vbNewLine & "5. Finish the burgers before the times runs out." & vbNewLine & "6. Click this mini burger" & vbNewLine & vbNewLine & "when it appears, this mini burger will help increase your time." & vbNewLine & "7. Have a nice play!"

    End Sub

    Private Sub TimerJdlPetunjuk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerJdlPetunjuk.Tick
        Select Case LBJudulPetunjuk.Text
            Case ""
                LBJudulPetunjuk.Text = "H"
            Case "H"
                LBJudulPetunjuk.Text = "HO"
            Case "HO"
                LBJudulPetunjuk.Text = "HOW"
            Case "HOW"
                LBJudulPetunjuk.Text = "HOW "
            Case "HOW "
                LBJudulPetunjuk.Text = "HOW T"
            Case "HOW T"
                LBJudulPetunjuk.Text = "HOW TO"
            Case "HOW TO"
                LBJudulPetunjuk.Text = "HOW TO "
            Case "HOW TO "
                LBJudulPetunjuk.Text = "HOW TO P"
            Case "HOW TO P"
                LBJudulPetunjuk.Text = "HOW TO PL"
            Case "HOW TO PL"
                LBJudulPetunjuk.Text = "HOW TO PLA"
            Case "HOW TO PLA"
                LBJudulPetunjuk.Text = "HOW TO PLAY"
            Case "HOW TO PLAY"
                LBJudulPetunjuk.Text = "HOW TO PLAY "
            Case "HOW TO PLAY "
                LBJudulPetunjuk.Text = "HOW TO PLAY T"
            Case "HOW TO PLAY T"
                LBJudulPetunjuk.Text = "HOW TO PLAY TH"
            Case "HOW TO PLAY TH"
                LBJudulPetunjuk.Text = "HOW TO PLAY THI"
            Case "HOW TO PLAY THI"
                LBJudulPetunjuk.Text = "HOW TO PLAY THIS"
            Case "HOW TO PLAY THIS"
                LBJudulPetunjuk.Text = "HOW TO PLAY THIS "
            Case "HOW TO PLAY THIS "
                LBJudulPetunjuk.Text = "HOW TO PLAY THIS G"
            Case "HOW TO PLAY THIS G"
                LBJudulPetunjuk.Text = "HOW TO PLAY THIS GA"
            Case "HOW TO PLAY THIS GA"
                LBJudulPetunjuk.Text = "HOW TO PLAY THIS GAM"
            Case "HOW TO PLAY THIS GAM"
                LBJudulPetunjuk.Text = "HOW TO PLAY THIS GAME"
            Case "HOW TO PLAY THIS GAME"
                LBJudulPetunjuk.Text = "HOW TO PLAY THIS GAME?"
            Case "HOW TO PLAY THIS GAME?"
                LBJudulPetunjuk.Text = ""
        End Select
    End Sub

    
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbInstruksi.Click

    End Sub

    Private Sub BtnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlay.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPlay_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnPlay.MouseMove
        BtnPlay.BackColor = Color.Aquamarine
    End Sub
End Class