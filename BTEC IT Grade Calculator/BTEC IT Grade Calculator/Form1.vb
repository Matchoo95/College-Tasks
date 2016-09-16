Public Class FrmGrades
    Dim CountPass As Integer
    Dim CountMerit As Integer
    Dim CountDistin As Integer
    Dim FinalGrade As Integer

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblFinalGrade.Click

    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Public Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        CountPass = 0
        CountMerit = 0
        CountDistin = 0
        FinalGrade = 0
        LblPassCount.Text = 0
        LblMeritCount.Text = 0
        LblDistinCount.Text = 0
        LblGrade.Text = ""
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Dim theResponse As Integer
        theResponse = MsgBox("Do you want to quit?", vbQuestion + vbYesNo, "")
        If theResponse = vbYes Then
            Close()
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblGrade.Click

    End Sub

    Private Function ButUp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButUp1.Click
        If CountPass >= 0 Then
            If CountPass + CountMerit + CountDistin < 18 Then
                CountPass = CountPass + 1
                LblPassCount.Text = CountPass
            End If
        End If
        DisplayScore.Text = "Current Score = " & (CountPass * 70) + (CountMerit * 80) + (CountDistin * 90)
        Return CountPass
    End Function

    Private Function ButUp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButUp2.Click
        If CountPass >= 0 Then
            If CountPass + CountMerit + CountDistin < 18 Then
                CountMerit = CountMerit + 1
                LblMeritCount.Text = CountMerit
            End If
        End If
        DisplayScore.Text = "Current Score = " & (CountPass * 70) + (CountMerit * 80) + (CountDistin * 90)
        Return CountMerit
    End Function

    Private Function ButUp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButUp3.Click
        If CountPass >= 0 Then
            If CountPass + CountMerit + CountDistin < 18 Then
                CountDistin = CountDistin + 1
                LblDistinCount.Text = CountDistin
            End If
        End If
        DisplayScore.Text = "Current Score = " & (CountPass * 70) + (CountMerit * 80) + (CountDistin * 90)
        Return CountDistin
    End Function

    Private Function ButDwn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDwn1.Click
        If CountPass <= 18 And CountPass > 0 Then
            If CountPass + CountMerit + CountDistin < 18 Then
                CountPass = CountPass - 1
                LblPassCount.Text = CountPass
            End If
        End If
        DisplayScore.Text = "Current Score = " & (CountPass * 70) + (CountMerit * 80) + (CountDistin * 90)
        Return CountPass
    End Function

    Private Function ButDwn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDwn2.Click
        If CountMerit <= 18 And CountMerit > 0 Then
            If CountPass + CountMerit + CountDistin < 18 Then
                CountMerit = CountMerit - 1
                LblMeritCount.Text = CountMerit
            End If
        End If
        DisplayScore.Text = "Current Score = " & (CountPass * 70) + (CountMerit * 80) + (CountDistin * 90)
        Return CountMerit
    End Function

    Private Function ButDwn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDwn3.Click
        If CountDistin <= 18 And CountDistin > 0 Then
            If CountPass + CountMerit + CountDistin < 18 Then
                CountDistin = CountDistin - 1
                LblDistinCount.Text = CountDistin
            End If
        End If
        DisplayScore.Text = "Current Score = " & (CountPass * 70) + (CountMerit * 80) + (CountDistin * 90)
        Return CountDistin
    End Function

    Private Sub ButCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCalc.Click
        Dim CalcPass As Integer
        Dim CalcMerit As Integer
        Dim CalcDistin As Integer

        CalcPass = CountPass * 70
        CalcMerit = CountMerit * 80
        CalcDistin = CountDistin * 90

        FinalGrade = CalcPass + CalcMerit + CalcDistin
        If FinalGrade < 1260 Then
            LblGrade.Text = "Fail"
        ElseIf FinalGrade > 1260 And FinalGrade < 1299 Then
            LblGrade.Text = "PPP"
        ElseIf FinalGrade > 1300 And FinalGrade < 1339 Then
            LblGrade.Text = "MPP"
        ElseIf FinalGrade > 1340 And FinalGrade < 1379 Then
            LblGrade.Text = "MMP"
        ElseIf FinalGrade > 1380 And FinalGrade < 1419 Then
            LblGrade.Text = "MMM"
        ElseIf FinalGrade > 1420 And FinalGrade < 1459 Then
            LblGrade.Text = "DMM"
        ElseIf FinalGrade > 1460 And FinalGrade < 1499 Then
            LblGrade.Text = "DDM"
        ElseIf FinalGrade > 1500 And FinalGrade < 1529 Then
            LblGrade.Text = "DDD"
        ElseIf FinalGrade > 1530 And FinalGrade < 1559 Then
            LblGrade.Text = "D*DD"
        ElseIf FinalGrade > 1560 And FinalGrade < 1589 Then
            LblGrade.Text = "D*D*D"
        ElseIf FinalGrade > 1590 Then
            LblGrade.Text = "D*D*D*"
        End If



    End Sub

    Private Sub FrmGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HelpPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpPageToolStripMenuItem.Click
        Me.Hide()
        FrmHelp.Show()
    End Sub

    Private Sub SearchOnlineForHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOnlineForHelpToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.google.co.uk/search?site=&source=hp&q=BTEC+IT+level+3+grade+calculator+help&oq=BTEC+IT+level+3+grade+calculator+help&gs_l=hp.3...3412.19802.0.21409.40.34.1.5.5.0.93.2198.34.34.0....0...1c.1.42.hp..3.37.2135.0.wc4dZYR4GBI")
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DisplayScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayScore.Click

    End Sub
End Class
