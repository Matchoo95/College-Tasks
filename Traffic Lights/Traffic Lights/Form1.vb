Module Module1
    Public TrafficLightsDraw As System.Drawing.Graphics
End Module

Public Class Form1
    Dim DrawLightsHousing As System.Drawing.Graphics
    Dim HousingColor As New SolidBrush(Color.Black)
    Dim LightColorGreen As New SolidBrush(Color.Green)
    Dim LightColorAmber As New SolidBrush(Color.Orange)
    Dim LightColorRed As New SolidBrush(Color.Red)
    Dim StickColor As New SolidBrush(Color.LightGray)
    Dim PenColor As Pen
    Dim Counter, Counter2 As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Counter = 1


    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        TrafficLightsDraw = Me.CreateGraphics

        TrafficLightsDraw.FillRectangle(HousingColor, 60, 20, 50, 110)
        TrafficLightsDraw.FillRectangle(StickColor, 83, 130, 10, 130)
        TrafficLightsDraw.FillEllipse(LightColorRed, 68, 22, 33, 33)
        TrafficLightsDraw.FillEllipse(HousingColor, 68, 56, 33, 33)
        TrafficLightsDraw.FillEllipse(HousingColor, 68, 91, 33, 33)



    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Select Case Counter
            Case 1

                TrafficLightsDraw.FillEllipse(LightColorRed, 68, 22, 33, 33)
                TrafficLightsDraw.FillEllipse(HousingColor, 68, 56, 33, 33)
                TrafficLightsDraw.FillEllipse(HousingColor, 68, 56, 33, 33)
                txtGetReady.Text = ""
                txtStop.Text = "Stop!"
                txtGO.Text = ""
            Case 2
                TrafficLightsDraw.FillEllipse(LightColorRed, 68, 22, 33, 33)
                TrafficLightsDraw.FillEllipse(LightColorAmber, 68, 56, 33, 33)
                TrafficLightsDraw.FillEllipse(HousingColor, 68, 91, 33, 33)
                txtStop.Text = "Stop!"
                txtGetReady.Text = "Get Ready..."
            Case 3
                TrafficLightsDraw.FillEllipse(HousingColor, 68, 22, 33, 33)
                TrafficLightsDraw.FillEllipse(HousingColor, 68, 56, 33, 33)
                TrafficLightsDraw.FillEllipse(LightColorGreen, 68, 91, 33, 33)
                txtStop.Text = ""
                txtGO.Text = "GO!"
                txtGetReady.Text = ""
            Case 4
                TrafficLightsDraw.FillEllipse(LightColorAmber, 68, 56, 33, 33)
                TrafficLightsDraw.FillEllipse(HousingColor, 68, 91, 33, 33)
                txtGO.Text = ""
                txtGetReady.Text = "Get Ready..."
                txtStop.Text = ""



        End Select

        Counter = Counter + 1

        If Counter >= 5 Then Counter = 1


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick_1000(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
