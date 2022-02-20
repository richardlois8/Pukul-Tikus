Public Class Form1

    Dim rnd As Random = New Random()
    Dim arrayPosKolom() As Integer = New Integer() {8, 79, 150, 221, 292}
    Dim arrayPosBaris() As Integer = New Integer() {6, 70, 131, 195}
    Dim btn As New Button()
    Dim skor As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            btnStart.Text = "Stop"
            TimerTikus.Enabled = True
        Else
            btnStart.Text = "Start"
            TimerTikus.Enabled = False
            MsgBox(lblSkor.Text,, "Hasil Game")
            Me.Close()
        End If
    End Sub

    Private Sub TimerTikus_Tick(sender As Object, e As EventArgs) Handles TimerTikus.Tick
        Dim posKolom As Integer = arrayPosKolom(rnd.Next(0, arrayPosKolom.Count))
        Dim posBaris As Integer = arrayPosBaris(rnd.Next(0, arrayPosBaris.Count))

        btn = New Button()
        btn.Name = "btnTikus"
        btn.Location = New Point(posKolom, posBaris)
        btn.Size = New Size(65, 58)
        btn.Image = Image.FromFile("tikus2.png")
        btn.BringToFront()
        lblRandom.Text = "Random: " & CStr(posKolom) & "," & CStr(posBaris)
        Panel1.Controls.Add(btn)
        AddHandler btn.Click, AddressOf Me.buttonClick
    End Sub

    Private Sub buttonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btnClick As Button
        btnClick = DirectCast(sender, Button)
        skor += 100
        lblSkor.Text = "Skor : " & skor
        Panel1.Controls.Remove(btnClick)
    End Sub
End Class
