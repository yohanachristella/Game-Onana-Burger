Public Class FormUtama
    Dim level As Integer
    Dim score As Integer
    Dim waktu As Integer = 7
    Dim waktu2 As Integer = 9
    Dim waktu3 As Integer = 9
    Dim waktu4 As Integer = 12
    Dim waktu5 As Integer = 12
    Dim waktu6 As Integer = 15
    Dim waktu7 As Integer = 15
    Dim waktu8 As Integer = 18
    Dim waktu9 As Integer = 18
    Dim waktu10 As Integer = 18
    Dim waktu0 As Integer = 20
    Dim waktubonus As Integer
    Dim waktubaru As Integer
    Dim highscore As Integer = 0
    Dim inputnama As String
    Dim x As Integer


    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TimerCD.Interval = 800
        'TimerCD.Start()
        Dim fileku As Integer

        BtnBel.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnBel.FlatAppearance.BorderSize = 0
        BtnBel.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBel.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnBel.BackColor = System.Drawing.Color.Transparent
        BtnBel.Parent = Me
        BtnBel.BackColor = Color.Transparent

        BtnBunAtas.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnBunAtas.FlatAppearance.BorderSize = 0
        BtnBunAtas.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBunAtas.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnBunAtas.BackColor = System.Drawing.Color.Transparent
        BtnBunAtas.Parent = Me
        BtnBunAtas.BackColor = Color.Transparent

        BtnSalmon.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnSalmon.FlatAppearance.BorderSize = 0
        BtnSalmon.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnSalmon.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnSalmon.BackColor = System.Drawing.Color.Transparent
        BtnSalmon.Parent = Me
        BtnSalmon.BackColor = Color.Transparent

        BtnJamur.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnJamur.FlatAppearance.BorderSize = 0
        BtnJamur.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnJamur.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnJamur.BackColor = System.Drawing.Color.Transparent
        BtnJamur.Parent = Me
        BtnJamur.BackColor = Color.Transparent

        BtnSelada.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnSelada.FlatAppearance.BorderSize = 0
        BtnSelada.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnSelada.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnSelada.BackColor = System.Drawing.Color.Transparent
        BtnSelada.Parent = Me
        BtnSelada.BackColor = Color.Transparent

        BtnBacon.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnBacon.FlatAppearance.BorderSize = 0
        BtnBacon.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBacon.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnBacon.BackColor = System.Drawing.Color.Transparent
        BtnBacon.Parent = Me
        BtnBacon.BackColor = Color.Transparent

        BtnSaos.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnSaos.FlatAppearance.BorderSize = 0
        BtnSaos.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnSaos.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnSaos.BackColor = System.Drawing.Color.Transparent
        BtnSaos.Parent = Me
        BtnSaos.BackColor = Color.Transparent

        BtnBunBawah.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnBunBawah.FlatAppearance.BorderSize = 0
        BtnBunBawah.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBunBawah.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnBunBawah.BackColor = System.Drawing.Color.Transparent
        BtnBunBawah.Parent = Me
        BtnBunBawah.BackColor = Color.Transparent

        BtnBeef.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnBeef.FlatAppearance.BorderSize = 0
        BtnBeef.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnBeef.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnBeef.BackColor = System.Drawing.Color.Transparent
        BtnBeef.Parent = Me
        BtnBeef.BackColor = Color.Transparent

        BtnTelur.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnTelur.FlatAppearance.BorderSize = 0
        BtnTelur.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnTelur.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnTelur.BackColor = System.Drawing.Color.Transparent
        BtnTelur.Parent = Me
        BtnTelur.BackColor = Color.Transparent

        BtnTomat.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnTomat.FlatAppearance.BorderSize = 0
        BtnTomat.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnTomat.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnTomat.BackColor = System.Drawing.Color.Transparent
        BtnTomat.Parent = Me
        BtnTomat.BackColor = Color.Transparent

        BtnKeju.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnKeju.FlatAppearance.BorderSize = 0
        BtnKeju.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnKeju.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnKeju.BackColor = System.Drawing.Color.Transparent
        BtnKeju.Parent = Me
        BtnKeju.BackColor = Color.Transparent

        BtnAcar.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnAcar.FlatAppearance.BorderSize = 0
        BtnAcar.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnAcar.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnAcar.BackColor = System.Drawing.Color.Transparent
        BtnAcar.Parent = Me
        BtnAcar.BackColor = Color.Transparent

        level = 0
        score = 0

        If level = 0 Then
            TimerPanahKanan.Enabled = True
            LbInstruksi4.Visible = True
            LbInstruksi1.Visible = True
            PicPanahBawah8.Visible = True
            TBLevel.Text = "Level: " & level
            LbMenu.Text = "- Bottom Bun" & vbNewLine & "- Beef" & vbNewLine & "- Cheese" & vbNewLine & "- Top Bun"
            BtnBunBawah.Enabled = True
            BtnBeef.Enabled = True
            BtnKeju.Enabled = True
        End If

        fileku = FreeFile()
        FileOpen(fileku, "score.txt", OpenMode.Input)
        inputnama = LineInput(fileku)
        highscore = LineInput(fileku)
        LbBestPlayer.Text = "Best Player: " & inputnama
        LbHighScore.Text = "High Score: " & highscore
        FileClose(fileku)

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnBel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBel.Click
        'WMP2.URL = "D:\01. Tugas\Visual Studio\Project UTS\ProjectUTS\ProjectUTS\ding ding.wav"
        WMP2.URL = "D:\01. Tugas\Visual Studio\Project UTS_0014\ProjectUTS\ProjectUTS\ding ding.wav "

        If Pic0.Visible = True And level = 0 Then
            TimerPanahAtas.Enabled = False
            TimerKeju.Enabled = False
            TimerBeef.Enabled = False
            PicBeef.Visible = False
            TimerBunAtas.Enabled = False
            Pic0.Visible = False
            Pic0c.Visible = False
            Pic0b.Visible = False
            level = level + 1
            TBLevel.Text = "Level : " & level
            TBScore.Text = "Score : " & score
            LbMenu.Text = "- Bottom Bun" & vbNewLine & "- Beef" & vbNewLine & "- Top Bun"
            BtnBunBawah.Enabled = True
            BtnBeef.Enabled = True

            TimerPanahKanan2.Enabled = False
            PicPanahKanan2.Visible = False
            LbInstruksi7.Visible = False

            TimerPanahAtas.Enabled = False
            TimerPanahBawah2.Enabled = False
            TimerPanahKanan.Enabled = False
            TimerPanahKiri.Enabled = False
            PicPanahAtas.Visible = False
            PicPanahBawah2.Visible = False
            PicPanahBawah5.Visible = False
            PicPanahKanan.Visible = False
            PicPanahKiri.Visible = False
            LbInstruksi1.Visible = False
            LbInstruksi2.Visible = False
            LbInstruksi3.Visible = False
            LbInstruksi4.Visible = False
            LbInstruksi5.Visible = False
            LbInstruksi6.Visible = False

        ElseIf Pic1.Visible = True And level = 1 Then
            Pic1.Visible = False
            PicSelada.Visible = False
            TimerSelada.Enabled = False
            Timerlv1.Enabled = False
            TimerBeef.Enabled = False
            TimerBunAtas.Enabled = False
            PicBunAtas.Visible = False
            Pic0b.Visible = False
            score = score + 5
            TBScore.Text = "Score : " & score
            level = level + 1
            TBLevel.Text = "Level : " & level
            LbMenu.Text = "- Bottom Bun " & vbNewLine & "- Beef" & vbNewLine & "- Lettuce" & vbNewLine & "- Top Bun"
            BtnBunBawah.Enabled = True
            BtnBeef.Enabled = True
        ElseIf Pic2.Visible = True And level = 2 Then
            TimerSelada.Enabled = False
            TimerBeef.Enabled = False
            TimerBunAtas.Enabled = False
            Pic3.Visible = False
            Pic2.Visible = False
            Pic2c.Visible = False
            Pic0b.Visible = False
            Pic3c.Visible = False
            score = score + 5
            TBScore.Text = "Score : " & score
            level = level + 1
            TBLevel.Text = "Level : " & level
            LbMenu.Text = "- Bottom Bun " & vbNewLine & "- Tomato" & vbNewLine & "- Beef" & vbNewLine & "- Letuce" & vbNewLine & "- Top Bun"
            BtnBunBawah.Enabled = True
            BtnBeef.Enabled = True
            BtnTomat.Enabled = True
        ElseIf Pic3.Visible = True And level = 3 Then
            Pic3.Visible = False
            TimerSelada.Enabled = False
            TimerBeef.Enabled = False
            TimerTomat.Enabled = False
            TimerBunAtas.Enabled = False
            Pic4b.Visible = False
            Pic3c.Visible = False
            Pic3d.Visible = False
            Pic3b.Visible = False
            Pic4c.Visible = False
            Pic4d.Visible = False
            Pic4e.Visible = False
            Pic4.Visible = False
            score = score + 5
            TBScore.Text = "Score : " & score
            level = level + 1
            TBLevel.Text = "Level : " & level
            LbMenu.Text = "- Bottom Bun " & vbNewLine & "- Letuce" & vbNewLine & "- Beef" & vbNewLine & "- Tomato" & vbNewLine & "- Cheese" & vbNewLine & "- Top Bun"
            BtnBunBawah.Enabled = True
            BtnSelada.Enabled = True
            BtnBeef.Enabled = True
            BtnTomat.Enabled = True
        ElseIf Pic4.Visible = True And level = 4 Then
            TimerTomat.Enabled = False
            TimerKeju.Enabled = False
            TimerBacon.Enabled = False
            TimerSelada.Enabled = False
            TimerTelur.Enabled = False
            TimerBunAtas.Enabled = False
            Pic4.Visible = False
            Pic4e.Visible = False
            Pic4d.Visible = False
            Pic4c.Visible = False
            Pic4b.Visible = False
            Pic3b.Visible = False
            Pic5c.Visible = False
            Pic5d.Visible = False
            Pic5e.Visible = False
            Pic5f.Visible = False
            Pic5.Visible = False
            score = score + 5
            TBScore.Text = "Score : " & score
            level = level + 1
            TBLevel.Text = "Level : " & level
            LbMenu.Text = "- Bottom Bun " & vbNewLine & "- Tomato" & vbNewLine & "- Cheese" & vbNewLine & "- Bacon" & vbNewLine & "- Letuce" & vbNewLine & "- Egg" & vbNewLine & "- Top Bun"
            BtnBunBawah.Enabled = True
            BtnTomat.Enabled = True
            BtnKeju.Enabled = True
            BtnSelada.Enabled = True
            BtnBacon.Enabled = True
            BtnTelur.Enabled = True
        ElseIf Pic5.Visible = True And level = 5 Then
            TimerBunAtas.Enabled = False
            Pic5.Visible = False
            Pic5c.Visible = False
            Pic5d.Visible = False
            Pic5e.Visible = False
            Pic5f.Visible = False
            Pic3b.Visible = False
            score = score + 10
            TBScore.Text = "Score : " & score
            level = level + 1
            TBLevel.Text = "Level : " & level
            LbMenu.Text = "- Bottom Bun " & vbNewLine & "- Beef" & vbNewLine & "- Letuce" & vbNewLine & "- Champignon" & vbNewLine & "- Tomato" & vbNewLine & "- Cucumber" & vbNewLine & "- Ketchup" & vbNewLine & "- Top Bun"
            BtnBunBawah.Enabled = True
            BtnBeef.Enabled = True
            BtnJamur.Enabled = True
            BtnTomat.Enabled = True
            BtnAcar.Enabled = True
            BtnSaos.Enabled = True
            'ElseIf Pic6h.Visible = True And level = 6 Then
            'Pic6h.Visible = False
            'score = score + 10
            'TBScore.Text = "Score : " & score
            'level = level + 1
            'TBLevel.Text = "Level : " & level
            'LbMenu.Text = "- Bottom Bun " & vbNewLine & "- Tomato" & vbNewLine & "- Cheese" & vbNewLine & "- Salmon" & vbNewLine & "- Letuce" & vbNewLine & "- Egg" & vbNewLine & "- Cucumber" & vbNewLine & "- Ketchup" & vbNewLine & "- Top Bun"
            'BtnBunBawah.Enabled = True
            'BtnTomat.Visible = True
            'BtnSalmon.Enabled = True
            'BtnSelada.Enabled = True
            'BtnTelur.Enabled = True
            'BtnAcar.Enabled = True
            'BtnSaos.Enabled = True
            'ElseIf Pic7i.Visible = True And level = 7 Then
            'Pic7i.Visible = False
            'score = score + 10
            'TBScore.Text = "Score : " & score
            'level = level + 1
            'TBLevel.Text = "Level : " & level
            'LbMenu.Text = "- Bottom Bun " & vbNewLine & "- Salmon" & vbNewLine & "- Egg" & vbNewLine & "- Letuce" & vbNewLine & "- Bacon" & vbNewLine & "- Cucumber" & vbNewLine & "- Cheese" & vbNewLine & "- Tomato" & vbNewLine & "- Ketchup" & vbNewLine & "- Top Bun"
            'BtnBunBawah.Enabled = True
            'BtnTelur.Enabled = True
            'BtnSelada.Enabled = True
            'BtnBacon.Enabled = True
            'BtnAcar.Enabled = True
            'BtnKeju.Enabled = True
            'BtnTomat.Enabled = True
            'BtnSaos.Enabled = True
            'ElseIf Pic8j.Visible = True And level = 8 Then
            'Pic8j.Visible = False
            'score = score + 15
            'TBScore.Text = "Score : " & score
            'level = level + 1
            'TBLevel.Text = "Level : " & level
            'LbMenu.Text = "- Bottom Bun" & vbNewLine & "- Beef" & vbNewLine & "- Tomato" & vbNewLine & "- Bacon" & vbNewLine & "- Champignon" & vbNewLine & "- Cucumber" & vbNewLine & "- Egg" & vbNewLine & "- Salmon" & vbNewLine & "- Ketchup" & vbNewLine & "- Top Bun"
            'BtnBunBawah.Enabled = True
            'BtnBeef.Enabled = True
            'BtnTomat.Enabled = True
            'BtnBacon.Enabled = True
            'BtnJamur.Enabled = True
            'BtnAcar.Enabled = True
            'BtnTelur.Enabled = True
            'BtnSalmon.Enabled = True
            'BtnSaos.Enabled = True
            'ElseIf Pic9j.Visible = True And level = 9 Then
            'Pic9j.Visible = False
            'score = score + 15
            'TBScore.Text = "Score : " & score
            'level = level + 1
            'TBLevel.Text = "Level : " & level
            'LbMenu.Text = "- Bottom Bun" & vbNewLine & "- Beef" & vbNewLine & "- Letuce" & vbNewLine & "- Salmon" & vbNewLine & "- Tomato" & vbNewLine & "- Cheese" & vbNewLine & "- Cucumber" & vbNewLine & "- Egg" & vbNewLine & "- Ketchup" & vbNewLine & "- Top Bun"
            'BtnBunBawah.Enabled = True
            'BtnBeef.Enabled = True
            'BtnSelada.Enabled = True
            'BtnSalmon.Enabled = True
            'BtnTomat.Enabled = True
            'BtnKeju.Enabled = True
            'BtnAcar.Enabled = True
            'BtnTelur.Enabled = True
            'BtnSaos.Enabled = True
            'ElseIf Pic10j.Visible = True And level = 10 Then
            '   Pic10j.Visible = False
            '  score = score + 20
            ' TBScore.Text = "Score: " & score


        End If

    End Sub

    Private Sub BtnBunAtas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBunAtas.Click

        TimerBunAtas.Enabled = True
        TimerBunAtas.Interval = 100


        If level = 0 Then
            PicBunAtas.Visible = True
            PicBunAtas.Height = 130
            Pic0.Visible = True
        ElseIf level = 1 Then
            Timerlv1.Enabled = True
            Timerlv1.Interval = 100
            PicBunAtas.Visible = True
            PicBunAtas.Height = 130
            Pic1.Visible = True
        ElseIf level = 2 Then
            PicBunAtas.Visible = True
            PicBunAtas.Height = 130
            Pic2.Visible = True
        ElseIf level = 3 Then
            PicBunAtas.Visible = True
            PicBunAtas.Height = 130
            Pic3.Visible = True
        ElseIf level = 4 Then
            PicBunAtas.Visible = True
            PicBunAtas.Height = 130
            Pic4.Visible = True
        ElseIf level = 5 Then
            PicBunAtas.Visible = True
            PicBunAtas.Height = 130
            Pic5.Visible = True
        End If
    End Sub

    Private Sub BtnSalmon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalmon.Click

    End Sub

    Private Sub BtnJamur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJamur.Click

    End Sub

    Private Sub BtnSelada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelada.Click
        TimerSelada.Enabled = True
        TimerSelada.Interval = 100

        If level = 2 Then
            PicSelada.Visible = True
            PicSelada.Height = 130
            Pic2c.Visible = True
        ElseIf level = 3 Then
            PicSelada.Visible = True
            PicSelada.Height = 130
            Pic3d.Visible = True
        ElseIf level = 4 Then
            PicSelada.Visible = True
            PicSelada.Height = 130
            Pic4b.Visible = True
        ElseIf level = 5 Then
            PicSelada.Visible = True
            PicSelada.Height = 130
            Pic5e.Visible = True
        End If
    End Sub

    Private Sub BtnBacon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBacon.Click
        TimerBacon.Enabled = True
        TimerBacon.Interval = 100

        If level = 5 Then
            PicBacon.Visible = True
            PicBacon.Height = 130
            Pic5d.Visible = True
        End If

    End Sub

    Private Sub BtnSaos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaos.Click



    End Sub

    Private Sub BtnBunBawah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBunBawah.Click
        TimerBunBawah.Interval = 300
        TimerBunBawah.Enabled = True
        PicBunBawah.Height = 170

        PicBunBawah.Visible = True
        PicBeef.Visible = False
        Pic0b.Visible = False
        If level = 0 Then
            TimerPanahKanan.Enabled = False
            PicPanahBawah8.Visible = False
            LbInstruksi1.Visible = False
            LbInstruksi4.Visible = False
            TimerPanahBawah2.Enabled = True
            LbInstruksi2.Visible = True
        End If






    End Sub

    Private Sub BtnBeef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBeef.Click
        TimerBeef.Enabled = True
        TimerBeef.Interval = 100

        If level = 0 Then
            PicBeef.Visible = True
            PicBeef.Height = 130
            Pic0b.Visible = True
        ElseIf level = 1 Then
            PicBeef.Visible = True
            PicBeef.Height = 130
            Pic0b.Visible = True
        ElseIf level = 2 Then
            PicBeef.Visible = True
            PicBeef.Height = 130
            Pic0b.Visible = True
        ElseIf level = 3 Then
            PicBeef.Visible = True
            PicBeef.Height = 130
            Pic3c.Visible = True
        ElseIf level = 4 Then
            PicBeef.Visible = True
            PicBeef.Height = 130
            Pic4c.Visible = True
        End If

    End Sub

    Private Sub BtnTelur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTelur.Click
        TimerTelur.Enabled = True
        TimerTelur.Interval = 100

        If level = 5 Then
            PicTelur.Visible = True
            PicTelur.Height = 130
            Pic5f.Visible = True
        End If
    End Sub

    Private Sub BtnTomat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTomat.Click
        TimerTomat.Enabled = True
        TimerTomat.Interval = 100

        If level = 3 Then
            PicTomat.Visible = True
            PicTomat.Height = 130
            Pic3b.Visible = True
        ElseIf level = 4 Then
            PicTomat.Visible = True
            PicTomat.Height = 130
            Pic4d.Visible = True
        ElseIf level = 5 Then
            PicTomat.Visible = True
            PicTomat.Height = 130
            Pic3b.Visible = True
        End If

    End Sub

    Private Sub BtnKeju_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeju.Click
        TimerKeju.Enabled = True
        TimerKeju.Interval = 100

        If level = 0 Then
            PicKeju.Visible = True
            PicKeju.Height = 130
            Pic0c.Visible = True
        ElseIf level = 4 Then
            PicKeju.Visible = True
            PicKeju.Height = 130
            Pic4e.Visible = True
        ElseIf level = 5 Then
            PicKeju.Visible = True
            PicKeju.Height = 130
            Pic5c.Visible = True
        End If
    End Sub

    Private Sub BtnAcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAcar.Click

    End Sub

    Private Sub PicBunBawah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBunBawah.Click

    End Sub

    Private Sub TimerBunBawah_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBunBawah.Tick

        If PicBunBawah.Top <= Me.Height Then PicBunBawah.Top = +(PicBunBawah.Height)

    End Sub

    Private Sub TimerBeef_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBeef.Tick
        If PicBeef.Top <= Me.Height Then PicBeef.Top = +(PicBeef.Height)
        If level = 0 And PicBeef.Top = +(PicBeef.Height) Then
            PicBunBawah.Visible = False
            PicBeef.Visible = False
            Pic0b.Visible = True
        ElseIf level = 1 And PicBeef.Top = +(PicBeef.Height) Then
            PicBunBawah.Visible = False
            PicBeef.Visible = False
            Pic0b.Visible = True
        ElseIf level = 2 And PicBeef.Top = +(PicBeef.Height) Then
            PicBunBawah.Visible = False
            PicBeef.Visible = False
            Pic0b.Visible = True
        ElseIf level = 3 And PicBeef.Top = +(PicBeef.Height) Then
            Pic3b.Visible = False
            PicBeef.Visible = False
            Pic3c.Visible = True
        ElseIf level = 4 And PicBeef.Top = +(PicBeef.Height) Then
            Pic4b.Visible = False
            PicBeef.Visible = False
            Pic4c.Visible = True

        End If
    End Sub

    Private Sub Timer2b_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Timer2c_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer3b_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TimerCD_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCD.Tick
        Dim fileku As Integer


        If level = 0 Then
            waktu0 = waktu0 - 1
            LbTimer.Text = waktu0.ToString
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
            End If
        End If
        If level = 1 Then
            waktu = waktu - 1
            LbTimer.Text = waktu.ToString
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
            End If
        End If


        If level = 2 Then
            waktu2 = waktu2 - 1
            LbTimer.Text = waktu2.ToString
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If

        If level = 3 Then
            waktu3 = waktu3 - 1
            LbTimer.Text = waktu3.ToString
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If

        If level = 4 Then
            waktu4 = waktu4 - 1
            LbTimer.Text = waktu4.ToString
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If


        If level = 5 Then
            PicBonus.Visible = True
            waktu5 = waktu5 - 1
            LbTimer.Text = waktu5.ToString
            If TimerBonus.Enabled = True Then
                PicBonus.Visible = False
                waktubonus = waktu5 + 3
                LbTimer.Text = waktubonus.ToString
            End If
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If


        If level = 6 Then
            PicBonus.Visible = False
            PicBonus2.Visible = True
            waktu6 = waktu6 - 1
            LbTimer.Text = waktu6.ToString
            If TimerBonus2.Enabled = True Then
                PicBonus2.Visible = False
                waktubonus = waktu6 + 3
                LbTimer.Text = waktubonus.ToString
            End If
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If

        If level = 7 Then
            waktu7 = waktu7 - 1
            LbTimer.Text = waktu7.ToString
            PicBonus2.Visible = False
            PicBonus3.Visible = True
            If TimerBonus3.Enabled = True Then
                PicBonus3.Visible = False
                waktubonus = waktu7 + 3
                LbTimer.Text = waktubonus.ToString
            End If
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If

        If level = 8 Then
            waktu8 = waktu8 - 1
            LbTimer.Text = waktu8.ToString
            PicBonus3.Visible = False
            PicBonus4.Visible = True
            If TimerBonus4.Enabled = True Then
                PicBonus4.Visible = False
                waktubonus = waktu8 + 3
                LbTimer.Text = waktubonus.ToString
            End If
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times Up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If

        If level = 9 Then
            waktu9 = waktu9 - 1
            LbTimer.Text = waktu9.ToString
            PicBonus4.Visible = False
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Times Up!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If

        If level = 10 Then
            waktu10 = waktu10 - 1
            LbTimer.Text = waktu10.ToString
            If LbTimer.Text = "0" Then
                TimerCD.Stop()
                MsgBox("Congrats, You Win!")
                BtnBel.Enabled = False
                If score > highscore Then
                    highscore = score
                    LbHighScore.Text = "High Score: " & highscore
                    inputnama = InputBox("Enter your name: ", "Enter your name")
                    If Len(Trim(inputnama)) > 0 Then
                        LbBestPlayer.Text = "Best Player: " & inputnama
                        fileku = FreeFile()
                        FileOpen(fileku, "score.txt", OpenMode.Output)
                        PrintLine(fileku, inputnama)
                        PrintLine(fileku, highscore)
                        FileClose(fileku)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub LbTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbTimer.Click

    End Sub

    Private Sub TimerBonus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBonus.Tick
        TimerBonus.Enabled = True
        TimerBonus.Interval = 300
        PicBonus.Top = PicBonus.Top - 3

    End Sub

    Private Sub PicBonus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBonus.Click
        TimerBonus.Enabled = True

    End Sub

    Private Sub TimerBonus2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBonus2.Tick
        TimerBonus2.Enabled = True
        TimerBonus2.Interval = 300
        PicBonus2.Top = PicBonus2.Top - 3
    End Sub

    Private Sub PicBonus2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBonus2.Click
        TimerBonus2.Enabled = True
    End Sub

    Private Sub TimerBonus3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBonus3.Tick
        TimerBonus3.Enabled = True
        TimerBonus3.Interval = 300
        PicBonus3.Top = PicBonus3.Top - 3
    End Sub

    Private Sub PicBonus3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBonus3.Click
        TimerBonus3.Enabled = True
    End Sub

    Private Sub TimerBonus4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBonus4.Tick
        TimerBonus4.Enabled = True
        TimerBonus4.Interval = 300
        PicBonus4.Top = PicBonus4.Top - 3
    End Sub

    Private Sub PicBonus4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBonus4.Click
        TimerBonus4.Enabled = True
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormHome.Show()

        TimerCD.Stop()
        If level = 1 Then
            waktu = 6
        ElseIf level = 2 Then
            waktu2 = 9
        ElseIf level = 3 Then
            waktu3 = 9
        ElseIf level = 4 Then
            waktu4 = 12
        ElseIf level = 5 Then
            waktu5 = 12
        ElseIf level = 6 Then
            waktu6 = 15
        ElseIf level = 7 Then
            waktu7 = 15
        ElseIf level = 8 Then
            waktu8 = 18
        ElseIf level = 9 Then
            waktu9 = 18
        ElseIf level = 10 Then
            waktu10 = 18
        End If

    End Sub

    Private Sub BtnBack_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnBack.MouseMove
        BtnBack.BackColor = Color.Violet
    End Sub

    Private Sub TimerPanahAtas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanahAtas.Tick
        x = x + 1
        If x = 2 Then
            x = 0
        End If
        If x Mod 2 = 0 Then
            PicPanahAtas.Visible = True
        Else
            PicPanahAtas.Visible = False
        End If

    End Sub

    Private Sub TimerKeju_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerKeju.Tick
        If PicKeju.Top <= Me.Height Then PicKeju.Top = +(PicKeju.Height)
        If level = 0 And PicKeju.Top = +(PicKeju.Height) Then
            Pic0b.Visible = False
            PicKeju.Visible = False
            Pic0c.Visible = True
        ElseIf level = 4 And PicKeju.Top = +(PicKeju.Height) Then
            Pic4d.Visible = False
            PicKeju.Visible = False
            Pic4e.Visible = True
        ElseIf level = 5 And PicKeju.Top = +(PicKeju.Height) Then
            Pic3b.Visible = False
            PicKeju.Visible = False
            Pic5c.Visible = True
        End If
    End Sub

    Private Sub TimerBunAtas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBunAtas.Tick
        If PicBunAtas.Top <= Me.Height Then PicBunAtas.Top = +(PicBunAtas.Height)
        If level = 0 And PicBunAtas.Top = +(PicBunAtas.Height) Then
            Pic0c.Visible = False
            PicBunAtas.Visible = False
            Pic0.Visible = True
        ElseIf level = 2 And PicBunAtas.Top = +(PicBunAtas.Height) Then
            Pic2c.Visible = False
            PicBunAtas.Visible = False
            Pic2.Visible = True
        ElseIf level = 3 And PicBunAtas.Top = +(PicBunAtas.Height) Then
            Pic3d.Visible = False
            PicBunAtas.Visible = False
            Pic3.Visible = True
        ElseIf level = 4 And PicBunAtas.Top = +(PicBunAtas.Height) Then
            Pic4e.Visible = False
            PicBunAtas.Visible = False
            Pic4.Visible = True
        ElseIf level = 5 And PicBunAtas.Top = +(PicBunAtas.Height) Then
            Pic5f.Visible = False
            PicBunAtas.Visible = False
            Pic5.Visible = True
        End If
    End Sub

    Private Sub TimerPanahBawah2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanahBawah2.Tick
        x = x + 1
        If x = 2 Then
            x = 0
        End If
        If x Mod 2 = 0 Then
            PicPanahBawah2.Visible = True
        Else
            PicPanahBawah2.Visible = False
        End If
    End Sub

    Private Sub TimerPanahKiri_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanahKiri.Tick
        x = x + 1
        If x = 2 Then
            x = 0
        End If
        If x Mod 2 = 0 Then
            PicPanahKiri.Visible = True
        Else
            PicPanahKiri.Visible = False
        End If
    End Sub


    Private Sub TimerPanahKanan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanahKanan.Tick
        x = x + 1
        If x = 2 Then
            x = 0
        End If
        If x Mod 2 = 0 Then
            PicPanahKanan.Visible = True
        Else
            PicPanahKanan.Visible = False
        End If
    End Sub

    Private Sub TimerPanahKanan2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPanahKanan2.Tick
        x = x + 1
        If x = 2 Then
            x = 0
        End If
        If x Mod 2 = 0 Then
            PicPanahKanan2.Visible = True
        Else
            PicPanahKanan2.Visible = False
        End If
    End Sub

    
    Private Sub Timerlv1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerlv1.Tick
        If PicBunAtas.Top <= Me.Height Then PicBunAtas.Top = +(PicBunAtas.Height)
        If level = 1 And PicBunAtas.Top = +(PicBunAtas.Height) Then
            PicBeef.Visible = False
            PicBunAtas.Visible = False
            Pic1.Visible = True
        End If
    End Sub

    Private Sub TimerSelada_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSelada.Tick
        If PicSelada.Top <= Me.Height Then PicSelada.Top = +(PicSelada.Height)
        If level = 2 And PicSelada.Top = +(PicSelada.Height) Then
            PicBeef.Visible = False
            PicSelada.Visible = False
            Pic2c.Visible = True
        ElseIf level = 3 And PicSelada.Top = +(PicSelada.Height) Then
            Pic3c.Visible = False
            PicSelada.Visible = False
            Pic3d.Visible = True
        ElseIf level = 4 And PicSelada.Top = +(PicSelada.Height) Then
            PicBunBawah.Visible = False
            PicSelada.Visible = False
            Pic4b.Visible = True
        ElseIf level = 5 And PicSelada.Top = +(PicSelada.Height) Then
            Pic5d.Visible = False
            PicSelada.Visible = False
            Pic5e.Visible = True
        End If
    End Sub

    Private Sub TimerTomat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTomat.Tick
        If PicTomat.Top <= Me.Height Then PicTomat.Top = +(PicTomat.Height)
        If level = 3 And PicTomat.Top = +(PicTomat.Height) Then
            PicBunBawah.Visible = False
            PicTomat.Visible = False
            Pic3b.Visible = True
        ElseIf level = 4 And PicTomat.Top = +(PicTomat.Height) Then
            Pic4c.Visible = False
            PicTomat.Visible = False
            Pic4d.Visible = True
        ElseIf level = 5 And PicTomat.Top = +(PicTomat.Height) Then
            PicBunBawah.Visible = False
            PicTomat.Visible = False
            Pic3b.Visible = True
        End If
    End Sub

    Private Sub TimerSalmon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSalmon.Tick
    End Sub

    Private Sub TimerBacon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBacon.Tick
        If PicBacon.Top <= Me.Height Then PicBacon.Top = +(PicBacon.Height)
        If level = 5 And PicBacon.Top = +(PicBacon.Height) Then
            PicBunBawah.Visible = False
            PicBacon.Visible = False
            Pic5d.Visible = True
        End If
    End Sub

    Private Sub TimerTelur_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTelur.Tick
        If PicTelur.Top <= Me.Height Then PicTelur.Top = +(PicTelur.Height)
        If level = 5 And PicTelur.Top = +(PicTelur.Height) Then
            Pic5e.Visible = False
            PicTelur.Visible = False
            Pic5f.Visible = True
        End If
    End Sub
End Class