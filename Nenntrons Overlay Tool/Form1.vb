Imports System.Runtime.InteropServices

Public Class Form1

    Public Stringform As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Me.Hide()
        Stringform = 3
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Me.Hide()
        Stringform = 4
        Form6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.close, AudioPlayMode.WaitToComplete)
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Me.Hide()
        Stringform = 5
        Form6.Show()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(30, 30, 30)
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.FromArgb(40, 30, 30)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.FromArgb(30, 30, 30)
    End Sub


    Public Const WM_NCLBUTTONDOWN As Integer = 161  'moveable borderless form
    Public Const HT_CAPTION As Integer = 2  'moveable borderless form

    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer  'moveable borderless form
    End Function

    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean   'moveable borderless form
    End Function

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown   'moveable borderless form
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Hide()

        Dim result3 As DialogResult = MessageBox.Show("Please consider to leave a Like if you found my Tool helpful.", "Did you like it?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Test DialogResult.
        If result3 = DialogResult.Yes Then
            Process.Start("https://forums.mihoyo.com/genshin/accountCenter/postList?id=87317176")
        End If
    End Sub

End Class
