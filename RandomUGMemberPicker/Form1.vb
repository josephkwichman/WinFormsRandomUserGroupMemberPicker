Public Class Form1
    Public MemberArrayList As New ArrayList
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NewestMember As String
        NewestMember = TextBox1.Text.ToString()
        MemberArrayList.Add(NewestMember)
        TextBox1.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MemberArrayList.Count > 0 Then
            Dim randomInt As New Random
            Dim winnerName As String
            winnerName = MemberArrayList.Item(randomInt.Next(0, MemberArrayList.Count))
            Label2.Text = winnerName
            MemberArrayList.Remove(winnerName)
        End If

    End Sub
End Class
