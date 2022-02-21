Public Class Form1

    Dim rnd As Random = New Random()
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
        Dim kolom As Integer = 6
        Dim baris As Integer = 4

        Panel1.Controls.Clear()

        Dim buttons As Button() = New Button() {}
        For i As Integer = 0 To baris - 1
            For j As Integer = 0 To kolom - 1
                btn = New Button()
                btn.Visible = False
                btn.Size = New Size(60, 55)
                btn.Image = Image.FromFile("tikus2.png")
                btn.Location = New Point(5 + j * 60, 20 + i * 60)
                btn.Name = "btnTikus"
                ReDim Preserve buttons(buttons.Length)
                buttons(buttons.Length - 1) = btn
                Panel1.Controls.Add(btn)
            Next
        Next

        Dim btnshowindex As Integer = rnd.Next(0, buttons.Length)
        buttons(btnshowindex).Visible = True

        lblRandom.Text = "random: " & buttons(btnshowindex).Location.X.ToString & "," &
            buttons(btnshowindex).Location.Y.ToString

        AddHandler buttons(btnshowindex).Click, AddressOf Me.buttonClick

    End Sub

    Private Sub buttonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btnClick As Button
        btnClick = DirectCast(sender, Button)
        skor += 100
        lblSkor.Text = "Skor : " & skor
        Panel1.Controls.Remove(btnClick)
    End Sub
End Class
