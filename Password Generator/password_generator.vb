Imports System.Text

Public Class password_generator

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim strChars As String
        Dim chrSingle As Char
        Dim intRand As Integer
        Dim Generator As System.Random = New System.Random()
        Dim intTotalChars As Integer
        Dim strNewPass As New StringBuilder
        Dim intCharacters As Integer




        strChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        If chkEasyChars.Checked Then
            For intIter As Integer = 1 To 2
                strChars &= "#-_=?"
            Next
        End If

        If chkHardChars.Checked Then
            strChars &= "!|$%&/()*[].:,;<>"
        End If

        intCharacters = strChars.Length

        'MessageBox.Show(strChars, "Password Generator")
        ' MessageBox.Show(Generator.Next(0, 2).ToString, "Password Generator")

        intTotalChars = CInt(nudPassSize.Value)
        'For itTotalChars
        For intIter As Integer = 1 To intTotalChars

            intRand = Generator.Next(0, intCharacters)
            'MessageBox.Show("Iteration: " & intIter.ToString, "Password Generator")
            'MessageBox.Show("Random Number: " & intRand.ToString, "Password Generator")
            chrSingle = strChars.Chars(intRand)
            strNewPass.Append(chrSingle.ToString)
        Next

        strNewPass.AppendLine().AppendLine()
        txtPasswords.Text &= strNewPass.ToString
        txtPasswords.SelectionStart = txtPasswords.Text.Length
        txtPasswords.ScrollToCaret()


    End Sub

    Private Sub menuCopy_Click(sender As Object, e As EventArgs) Handles menuCopy.Click
        txtPasswords.Copy()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPasswords.Clear()
    End Sub
End Class
