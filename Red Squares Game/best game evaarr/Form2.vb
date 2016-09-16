Public Class FrmGame

    Private Sub FrmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Get name given in previous form to display loading this form
        Me.Text = FrmSeclection.txtName.Text()

    End Sub

    Private Sub TMR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR.Tick
        'When bar reaches the maximum 100 then stop the timer
        If PBar1.Value = 100 Then
            TMR.Enabled = False
            PBar1.Value = PBar1.Value
            'This message display on two lines courtesy of vbCrLf
            MessageBox.Show("You have lost the game" & vbCrLf & "Play again?")
        Else
            'Otherwise increase the value of the progress bar timer
            PBar1.Value = PBar1.Value + 2
        End If

    End Sub

    Private Sub PBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBar1.Click

    End Sub

    'Button1 will also handle all other buttons
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button2.Click, Button10.Click, Button14.Click

        'When all three of the hidden squares have been clicked/disabled
        If Button2.Enabled = False And Button10.Enabled = False And Button14.Enabled = False Then
            'Stop timer
            TMR.Enabled = False
            'Stop progress bar incrementing
            PBar1.Value = PBar1.Value
            MessageBox.Show(FrmSeclection.txtName.Text & " you win!")
        Else

            'A CASE statement to remove boxes that are clicked
            Select Case DirectCast(sender, Button).Name
                'If button 2. 10 or 14 selected, change to red and disable
                Case Button2.Name
                    Button2.BackColor = Color.Red
                    Button2.Enabled = False
                Case Button10.Name
                    Button10.BackColor = Color.Red
                    Button10.Enabled = False
                Case Button14.Name
                    Button14.BackColor = Color.Red
                    Button14.Enabled = False
                Case Button1.Name
                    Button1.Visible = False
                Case Button3.Name
                    Button3.Visible = False
                Case Button4.Name
                    Button4.Visible = False
                Case Button5.Name
                    Button5.Visible = False
                Case Button6.Name
                    Button6.Visible = False
                Case Button7.Name
                    Button7.Visible = False
                Case Button8.Name
                    Button8.Visible = False
                Case Button9.Name
                    Button9.Visible = False
                Case Button11.Name
                    Button11.Visible = False
                Case Button12.Name
                    Button12.Visible = False
                Case Button13.Name
                    Button13.Visible = False
                Case Button15.Name
                    Button15.Visible = False
                Case Button16.Name
                    Button16.Visible = False
            End Select
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub
End Class