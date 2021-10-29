Imports System.ComponentModel

Public Class Form1




    Private Sub txt107s_TextChanged(sender As Object, e As EventArgs) Handles txt107s.TextChanged

    End Sub

    Private Sub txt106s_TextChanged(sender As Object, e As EventArgs) Handles txt106s.TextChanged

    End Sub

    Private Sub txt108s_TextChanged(sender As Object, e As EventArgs) Handles txt108s.TextChanged

    End Sub

    Private Sub txt105s_TextChanged(sender As Object, e As EventArgs) Handles txt105s.TextChanged

    End Sub



    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        Dim sit104, sit105, sit106, sit107, sit108, total, average As Double
        Dim mgrade As Char

        sit104 = txt104s.Text
        sit105 = txt105s.Text
        sit106 = txt106s.Text
        sit107 = txt107s.Text
        sit108 = txt108s.Text
        total = sit104 + sit105 + sit106 + sit107 + sit108
        average = total / 5
        txttotal.Text = total
        txtaverage.Text = average
        mgrade = grade(average)
        txtmgrade.Text = mgrade
    End Sub

    Private Sub txtaverage_TextChanged(sender As Object, e As EventArgs) Handles txtaverage.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub txt104s_TextChanged(sender As Object, e As EventArgs) Handles txt104s.TextChanged

    End Sub

    Public Function grade(mk As Integer) As Char
        If (mk >= 70 And mk <= 100) Then
            grade = "A"
        ElseIf (mk >= 60 And mk <= 69) Then
            grade = "B"
        ElseIf (mk >= 50 And mk <= 59) Then
            grade = "C"
        ElseIf (mk >= 40 And mk <= 49) Then
            grade = "D"
        ElseIf (mk >= 0 And mk <= 39) Then
            grade = "E"
        Else
            grade = "F"
        End If
    End Function
    Public Function comment(grade As Char) As String
        If (grade = "A") Then
            comment = "Excellent performance"
        ElseIf (grade = "B") Then
            comment = "Good work"
        ElseIf (grade = "C") Then
            comment = "Fair performance"
        ElseIf (grade = "D") Then
            comment = "Low performance"
        ElseIf (grade = "E") Then
            comment = "Poor performance"
        ElseIf (grade = "F") Then
            comment = "See your class teacher for guidance"




        End If
    End Function


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt104s_Validating(sender As Object, e As EventArgs) Handles txt104s.Validating
        txt104g.Text = grade(txt104s.Text)
        txt104c.Text = comment(txt104g.Text)
    End Sub

    Private Sub txt105s_Validating(sender As Object, e As CancelEventArgs) Handles txt105s.Validating
        txt105g.Text = grade(txt105s.Text)
        txt105c.Text = comment(txt105g.Text)
    End Sub

    Private Sub txt106s_Validating(sender As Object, e As CancelEventArgs) Handles txt106s.Validating
        txt106g.Text = grade(txt106s.Text)
        txt106c.Text = comment(txt106g.Text)
    End Sub

    Private Sub txt107s_Validating(sender As Object, e As CancelEventArgs) Handles txt107s.Validating
        txt107g.Text = grade(txt107s.Text)
        txt107c.Text = comment(txt107g.Text)
    End Sub

    Private Sub txt108s_Validating(sender As Object, e As CancelEventArgs) Handles txt108s.Validating
        txt108g.Text = grade(txt108s.Text)
        txt108c.Text = comment(txt108g.Text)
    End Sub

    Private Sub txt104s_KeyDown(sender As Object, e As KeyEventArgs) Handles txt104s.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txt105s_KeyDown(sender As Object, e As KeyEventArgs) Handles txt105s.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt106s_KeyDown(sender As Object, e As KeyEventArgs) Handles txt106s.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt107s_KeyDown(sender As Object, e As KeyEventArgs) Handles txt107s.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt108s_KeyDown(sender As Object, e As KeyEventArgs) Handles txt108s.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


End Class
