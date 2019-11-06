Public Class Form1
    Public Structure Jogadores

        Dim Jogador As String
        Dim Rank As String
        Dim Score As Integer

    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 1 To 6
            'Dim TB As New TextBox With {.Name = "TBox_" & i}
            Dim TB As New TextBox

            TB.Name = "TBox_" & i
            TB.Location = New Point(Button1.Location.X + 50 + (i * 20), Button1.Location.Y + 50 + (i * 20))

            Me.Controls.Add(TB)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To 6
            Dim TB = DirectCast(Controls("TBox_" & i), TextBox)
            'Dim TB = Me.Controls.Find("TBox_" & i, True).FirstOrDefault()

            If TB IsNot Nothing Then TB.Location = New Point(TB.Location.X + (i * 20), TB.Location.Y + (i * 20))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim Jogador As Jogadores

        'Dim Registos As List(Of Jogadores)

        'Jogador.Jogador = "Pai"
        'Jogador.Rank = "Monstro"
        'Jogador.Score = 3500

        'Registos.Add(Jogador)

    End Sub
End Class
