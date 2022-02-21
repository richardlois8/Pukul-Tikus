Public Class Form1

    Dim rnd As Random = New Random()
    Dim arrayPosKolom() As Integer = New Integer() {8, 79, 150, 221, 292}
    Dim arrayPosBaris() As Integer = New Integer() {6, 70, 131, 195}
    Dim skor As Integer = 0
    Dim new_btn As New Button

    Private Sub create_button()
        Dim posKolom As Integer = arrayPosKolom(rnd.Next(0, arrayPosKolom.Count))
        Dim posBaris As Integer = arrayPosBaris(rnd.Next(0, arrayPosBaris.Count))

        new_btn.Name = "btnTikus"
        new_btn.Location = New Point(posKolom, posBaris)
        new_btn.Size = New Size(65, 58)
        new_btn.Image = Image.FromFile("tikus2.png")
        new_btn.BringToFront()
        lblRandom.Text = "Random: " & CStr(posKolom) & "," & CStr(posBaris)
        Panel1.Controls.Add(new_btn)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            btnStart.Text = "Stop"
            skor = 0
            lblSkor.Text = "Skor : " & skor
            create_button()
            TimerTikus.Enabled = True
        Else
            btnStart.Text = "Start"
            TimerTikus.Enabled = False
            MsgBox(lblSkor.Text,, "Hasil Game")
            new_btn.Visible = False
        End If
    End Sub

    Private Sub TimerTikus_Tick(sender As Object, e As EventArgs) Handles TimerTikus.Tick
        Dim posKolom As Integer = arrayPosKolom(rnd.Next(0, arrayPosKolom.Count))
        Dim posBaris As Integer = arrayPosBaris(rnd.Next(0, arrayPosBaris.Count))

        new_btn.Visible = True
        new_btn.Location = New Point(posKolom, posBaris)
        lblRandom.Text = "Random: " & CStr(posKolom) & "," & CStr(posBaris)

        AddHandler new_btn.Click, AddressOf Me.buttonClick
    End Sub

    Private Sub buttonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btnClick As Button
        btnClick = DirectCast(sender, Button)
        skor += 1
        lblSkor.Text = "Skor : " & skor
        new_btn.Visible = False
    End Sub

End Class
