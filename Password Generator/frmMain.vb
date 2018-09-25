Imports System.ComponentModel

Public Class frmMain
    Public Generator As System.Random

    Private Enum CharType
        Number = 1
        Letter = 2
        SpecialChar = 3
    End Enum

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Do
            txtOutput.Text = GeneratePassword()
        Loop Until CheckPasswordStrength(txtOutput.Text) = True
    End Sub

    Private Function CheckPasswordStrength(ByVal Password As String) As Boolean
        Dim arrPassword() As Char = Password.ToCharArray
        Dim ContainsSpecialChar As Boolean = False
        Dim ContainsNumber As Boolean = False
        Dim ContainsLowerChar As Boolean = False
        Dim ContainsUpperChar As Boolean = False
        Dim Numbers() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim LCaseLetters() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim UCaseLetters() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim SpecialChars() As String = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "`", "~", "[", "]", "{", "}", ":", ";", "?", ".", ",", "\", "/", "|", "<", ">"}

        For X = 0 To arrPassword.Length - 1
            ' Check if password contains a number.
            If Numbers.Contains(arrPassword(X)) Then
                ContainsNumber = True
            End If
            ' Check if password contains a special character.
            If SpecialChars.Contains(arrPassword(X)) Then
                ContainsSpecialChar = True
                Exit For
            End If
            ' Check if password contains a lowercase character.
            If LCaseLetters.Contains(arrPassword(X)) Then
                ContainsLowerChar = True
            End If
            ' Check if password contains an uppercase character.
            If UCaseLetters.Contains(arrPassword(X)) Then
                ContainsUpperChar = True
            End If
        Next

        If ContainsSpecialChar Then
            lblContainsSpecialChar.Text = "Password contains a special character."
            lblContainsSpecialChar.ForeColor = Color.Green
        Else
            lblContainsSpecialChar.Text = "Password does not contain a special character."
            lblContainsSpecialChar.ForeColor = Color.Red
        End If

        If ContainsNumber Then
            lblContainsNumber.Text = "Password contains a number."
            lblContainsNumber.ForeColor = Color.Green
        Else
            lblContainsNumber.Text = "Password does not contain a number."
            lblContainsNumber.ForeColor = Color.Red
        End If

        If ContainsLowerChar Then
            lblContainsLower.Text = "Password contains a lower case character."
            lblContainsLower.ForeColor = Color.Green
        Else
            lblContainsLower.Text = "Password does not contain a lower case character."
            lblContainsLower.ForeColor = Color.Red
        End If

        If ContainsUpperChar Then
            lblContainsUpper.Text = "Password contains an upper case character."
            lblContainsUpper.ForeColor = Color.Green
        Else
            lblContainsUpper.Text = "Password does not contain an upper case character."
            lblContainsUpper.ForeColor = Color.Red
        End If

        If ContainsNumber And ContainsSpecialChar And ContainsLowerChar And ContainsUpperChar Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GeneratePassword() As String
        Dim intLength As Integer = spinMaxChars.Value
        Dim arrExcludeChars() As Char = txtExclude.Text.ToCharArray
        Dim outputPassword As String = ""
        Dim strNewChar As Char = ""
        Generator = New System.Random

        For i = 1 To intLength
            Do
                strNewChar = GetRandomChar(Generator.Next(1, 4))
            Loop Until Not arrExcludeChars.Contains(strNewChar)

            outputPassword &= strNewChar
        Next

        Return outputPassword
    End Function

    Private Function GetRandomChar(ByVal CharType As CharType) As String
        Dim intRandom As Integer = 0

        Select Case CharType
            Case CharType.Number
                Dim Numbers() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
                intRandom = Generator.Next(0, Numbers.Length)
                Return Numbers(intRandom)
            Case CharType.Letter
                Dim Letters() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
                intRandom = Generator.Next(0, Letters.Length)
                Select Case Generator.Next(1, 3)
                    Case 1
                        Return Letters(intRandom)
                    Case 2
                        Return UCase(Letters(intRandom))
                    Case Else
                        Return UCase(Letters(intRandom))
                End Select
            Case CharType.SpecialChar
                Dim SpecialChars() As String = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "`", "~", "[", "]", "{", "}", ":", ";", "?", ".", ",", "\", "/", "|", "<", ">"}
                intRandom = Generator.Next(0, SpecialChars.Length)
                Return SpecialChars(intRandom)
        End Select

        Return ""
    End Function
End Class
