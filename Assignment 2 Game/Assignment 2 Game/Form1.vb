

Public Class levels
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call setPlayerPosition()
        Call setVehicleSpeeds()
        Call resetVehiclePositions()


        Timer.Interval = 10
        Timer.Enabled = True

        Timer2.Interval = 1
        Timer2.Enabled = True

        carSpeedTimer.Interval = 10000
        Timer.Enabled = True

    End Sub

    Private Sub setPlayerPosition()

        player.Top = 665
        player.Left = 648

    End Sub
    Private Sub resetVehiclePositions()
        Dim car As Integer

        car1.Top = 254
        car1.Left = 1301
        car1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone
        car2.Top = 138
        car2.Left = 12
        car3.Top = 379
        car3.Left = 4
        truck1.Top = 490
        truck1.Left = 1301
        truck1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)

    End Sub
    Public Sub setVehicleSpeeds()

        Dim rndNumber As Integer

        Randomize()
        ' Used selection instead of iteraction to make sure that the random speed generated for each car is the same during the level other whys their speeds will fluctuate
        If GlobalVariables.level = 1 Then
            GlobalVariables.vehicle1Speed = rndNumber + ((Rnd() * 5) + 3)
            GlobalVariables.vehicle2Speed = rndNumber + ((Rnd() * 5) + 3)
            GlobalVariables.vehicle3Speed = rndNumber + ((Rnd() * 5) + 3)
            GlobalVariables.vehicle4Speed = rndNumber + ((Rnd() * 5) + 3)
        ElseIf GlobalVariables.level = 2 Then
            GlobalVariables.vehicle1Speed = rndNumber + ((Rnd() * 10) + 3)
            GlobalVariables.vehicle2Speed = rndNumber + ((Rnd() * 10) + 3)
            GlobalVariables.vehicle3Speed = rndNumber + ((Rnd() * 10) + 3)
            GlobalVariables.vehicle4Speed = rndNumber + ((Rnd() * 10) + 3)
        ElseIf GlobalVariables.level = 3 Then
            GlobalVariables.vehicle1Speed = rndNumber + ((Rnd() * 15) + 3)
            GlobalVariables.vehicle2Speed = rndNumber + ((Rnd() * 15) + 3)
            GlobalVariables.vehicle3Speed = rndNumber + ((Rnd() * 15) + 3)
            GlobalVariables.vehicle4Speed = rndNumber + ((Rnd() * 15) + 3)
        End If

    End Sub


    Public Sub New()                                    'gets rid of white blinking when images move

        MyBase.New()                                    'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()                               'Add any initialization after the InitializeComponent() call

    End Sub
    Public Sub setLitterPositions()

        GlobalVariables.litterCount = 3
        litterLabel.Text = GlobalVariables.litterCount
        ' Used selection instead of iteration as the locations only need to be set once not multiple times
        If GlobalVariables.level = 1 Then
            litter1.Top = 325
            litter1.Left = 57
            litter2.Top = 398
            litter2.Left = 1225
            litter3.Top = 138
            litter3.Left = 693
        ElseIf GlobalVariables.level = 2 Then
            litter1.Top = 469
            litter1.Left = 343
            litter2.Top = 224
            litter2.Left = 1470
            litter3.Top = 224
            litter3.Left = 343
        ElseIf GlobalVariables.level = 3 Then
            litter1.Top = 465
            litter1.Left = 4
            litter2.Top = 224
            litter2.Left = 1470
            litter3.Top = 224
            litter3.Left = 12
        End If


    End Sub


    Public Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        ' When the game is running the timer acts as a giant loop which will loop through all the code within the subroutine once every tick
        ' I've decided to not use any loops within the timer subroutine due to the possibility of getting stuck within one loop

        Dim timerValue As Decimal

        livesLabel.Text = GlobalVariables.lives

        ' Use of IF selection statement instead of iteration to prevent getting stuck within one loop
        If GlobalVariables.lives < 0 Then
            gameover.Show()
            Me.Close()
            Timer.Enabled = False
            MsgBox("Game Over, you have run out of lives!
        End If
        ' Use of nested IF selection statement instead of iteration to prevent getting stuck within one loop
        If GlobalVariables.litterCount = 0 Then
            If player.Bounds.IntersectsWith(bin.Bounds) Then
                Call setPlayerPosition()
                GlobalVariables.totalScore = GlobalVariables.totalScore + 300
                timerValue = timerLabel.Text
                GlobalVariables.totalScore = GlobalVariables.totalScore + timerValue
                scoreLabel.Text = GlobalVariables.totalScore
                If GlobalVariables.level = 3 Then
                    gameover.Show()
                    Me.Close()
                ElseIf GlobalVariables.litterCount = 0 And GlobalVariables.level < 3 Then
                    GlobalVariables.level = GlobalVariables.level + 1
                    levelLabel.Text = GlobalVariables.level
                    Call setLitterPositions()
                End If
                levelLabel.Text = GlobalVariables.level
            End If
        ElseIf player.Bounds.IntersectsWith(bin.Bounds) Then
            Call setPlayerPosition()
            MsgBox("You have not gotten all of the litter, go get the rest of the litter to get your score!")
        End If
        ' Use of ELSEIF selection statement instead of iteration to prevent getting stuck within one loop
        If player.Bounds.IntersectsWith(barrier1.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You hit a wall! Stay within the map! lives remaining: " & GlobalVariables.lives)
        ElseIf player.Bounds.IntersectsWith(barrier2.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You hit a wall! Stay within the map! lives remaining: " & GlobalVariables.lives)
        ElseIf player.Bounds.IntersectsWith(barrier3.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You hit a wall! Stay within the map! lives remaining: " & GlobalVariables.lives)
        ElseIf player.Bounds.IntersectsWith(barrier4.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You hit a wall! Stay within the map! lives remaining: " & GlobalVariables.lives)
        End If

        livesLabel.Text = GlobalVariables.lives
        ' Use of ELSEIF selection statement instead of iteration to prevent getting stuck within one loop
        If GlobalVariables.level = 1 Then
            car1.Left = car1.Left - GlobalVariables.vehicle1Speed
            car2.Left = car2.Left + GlobalVariables.vehicle2Speed
            car3.Left = car3.Left + GlobalVariables.vehicle3Speed
            truck1.Left = truck1.Left - GlobalVariables.vehicle4Speed
        ElseIf GlobalVariables.level = 2 Then
            car1.Left = car1.Left - GlobalVariables.vehicle1Speed - GlobalVariables.vehicle1Speed
            car2.Left = car2.Left + GlobalVariables.vehicle2Speed + GlobalVariables.vehicle2Speed
            car3.Left = car3.Left + GlobalVariables.vehicle3Speed + GlobalVariables.vehicle2Speed
            truck1.Left = truck1.Left - GlobalVariables.vehicle4Speed - GlobalVariables.vehicle1Speed
        ElseIf GlobalVariables.level = 3 Then
            car1.Left = car1.Left - GlobalVariables.vehicle1Speed - GlobalVariables.vehicle1Speed - GlobalVariables.vehicle1Speed
            car2.Left = car2.Left + GlobalVariables.vehicle2Speed + GlobalVariables.vehicle2Speed + GlobalVariables.vehicle2Speed
            car3.Left = car3.Left + GlobalVariables.vehicle3Speed + GlobalVariables.vehicle2Speed + GlobalVariables.vehicle2Speed
            truck1.Left = truck1.Left - GlobalVariables.vehicle4Speed - GlobalVariables.vehicle1Speed - GlobalVariables.vehicle1Speed
        End If

        timerLabel.Text = GlobalVariables.timeLeft
        GlobalVariables.timeLeft = GlobalVariables.timeLeft - 0.01
        ' Use of IF selection statement instead of iteration to prevent getting stuck within one loop
        If (GlobalVariables.timeLeft = 0) Then
            gameover.Show()
            Me.Close()
            Timer.Enabled = False
            MsgBox("Game over, you failed to collect all the rubbish within the specificed time limit")
        End If
        ' Use of IF selection statement instead of iteration to prevent getting stuck within one loop
        If car1.Bounds.IntersectsWith(boundary3.Bounds) Then
            car1.Top = 254
            car1.Left = 1301
            car1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If
        ' Use of IF selection statement instead of iteration to prevent getting stuck within one loop
        If car2.Bounds.IntersectsWith(boundary2.Bounds) Then
            car2.Top = 138
            car2.Left = 12
        End If
        ' Use of IF selection statement instead of iteration to prevent getting stuck within one loop
        If car3.Bounds.IntersectsWith(boundary2.Bounds) Then
            car3.Top = 379
            car3.Left = 4
        End If
        ' Use of IF selection statement instead of iteration to prevent getting stuck within one loop
        If truck1.Bounds.IntersectsWith(boundary3.Bounds) Then
            truck1.Top = 490
            truck1.Left = 1301
            truck1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If
        ' Use of ELSEIF selection statement instead of iteration to prevent getting stuck within one loop
        If player.Bounds.IntersectsWith(litter1.Bounds) Then
            litter1.Left = 9999
            litter1.Top = 9999
            GlobalVariables.litterCount = GlobalVariables.litterCount - 1
        ElseIf player.Bounds.IntersectsWith(litter2.Bounds) Then
            litter2.Left = 9999
            litter2.Top = 9999
            GlobalVariables.litterCount = GlobalVariables.litterCount - 1
        ElseIf player.Bounds.IntersectsWith(litter3.Bounds) Then
            litter3.Left = 9999
            litter3.Top = 9999
            GlobalVariables.litterCount = GlobalVariables.litterCount - 1
        End If
        litterLabel.Text = GlobalVariables.litterCount
        ' Use of ELSEIF selection statement instead of iteration to prevent getting stuck within one loop
        If player.Bounds.IntersectsWith(car1.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You where hit by a car! lives Remaining: " & GlobalVariables.lives)
        ElseIf player.Bounds.IntersectsWith(car2.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You where hit by a car! lives Remaining: " & GlobalVariables.lives)
        ElseIf player.Bounds.IntersectsWith(car3.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You where hit by a car! lives Remaining: " & GlobalVariables.lives)
        ElseIf player.Bounds.IntersectsWith(truck1.Bounds) Then
            Call setPlayerPosition()
            GlobalVariables.lives = GlobalVariables.lives - 1
            MsgBox("Oh no! You where hit by a car! lives Remaining: " & GlobalVariables.lives)
        End If

        livesLabel.Text = GlobalVariables.lives



    End Sub
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ' As with the other time it is better to use selection within the timer itself other whys it could cause complications
        If GetAsyncKeyState(Convert.ToInt32(Keys.D)) Then
            player.Left = player.Left + 8
        ElseIf GetAsyncKeyState(Convert.ToInt32(Keys.W)) Then
            player.Top = player.Top - 8
        ElseIf GetAsyncKeyState(Convert.ToInt32(Keys.A)) Then
            player.Left = player.Left - 8
        ElseIf GetAsyncKeyState(Convert.ToInt32(Keys.S)) Then
            player.Top = player.Top + 8

        End If
    End Sub

    Private Sub player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles carSpeedTimer.Tick


    End Sub

    Private Sub bin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bin.Click

    End Sub

    Private Sub safeArea1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles safeArea1.Click

    End Sub
End Class
Public Class GlobalVariables
    Public Shared level As Integer = 1
    Public Shared timeLeft As Decimal = 300
    Public Shared lives As Integer = 3
    Public Shared litterCount As Integer = 3
    Public Shared vehicle1Speed As Integer
    Public Shared vehicle2Speed As Integer
    Public Shared vehicle3Speed As Integer
    Public Shared vehicle4Speed As Integer
    Public Shared totalScore As Decimal
End Class
