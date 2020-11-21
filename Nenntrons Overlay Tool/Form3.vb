Imports System.Runtime.InteropServices

Public Class Form3
    Inherits Form

    Dim clicktrough As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChromiumWebBrowser1.Load("https://mapgenie.io/genshin-impact/maps/teyvat")
        Label2.Text = "Opacity"
        NotifyIcon1.Visible = True
    End Sub


    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.close, AudioPlayMode.WaitToComplete)
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.FromArgb(100, 50, 50)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.FromArgb(39, 39, 39)
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

    Private Sub TrackBar1_MouseEnter(sender As Object, e As EventArgs) Handles TrackBar1.MouseEnter
        TrackBar1.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub TrackBar1_MouseLeave(sender As Object, e As EventArgs) Handles TrackBar1.MouseLeave
        TrackBar1.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Me.Opacity = TrackBar1.Value / 100
        Label2.Text = TrackBar1.Value.ToString + "%"
    End Sub

    Private Sub CheckBox1_MouseEnter(sender As Object, e As EventArgs) Handles CheckBox1.MouseEnter
        CheckBox1.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub CheckBox1_MouseLeave(sender As Object, e As EventArgs) Handles CheckBox1.MouseLeave
        CheckBox1.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub CheckBox2_MouseEnter(sender As Object, e As EventArgs) Handles CheckBox2.MouseEnter
        CheckBox2.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub CheckBox2_MouseLeave(sender As Object, e As EventArgs) Handles CheckBox2.MouseLeave
        CheckBox2.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub CheckBox3_MouseEnter(sender As Object, e As EventArgs) Handles CheckBox3.MouseEnter
        CheckBox3.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub CheckBox3_MouseLeave(sender As Object, e As EventArgs) Handles CheckBox3.MouseLeave
        CheckBox3.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        If CheckBox2.Checked Then
            MessageBox.Show("You activated 'ClickTrough' which allows you to click trough the Form." & vbCrLf & vbCrLf & "You won't be able to click at the Form until you disabled it again!" & vbCrLf & vbCrLf & "You can disable it by rightclicking the Notification Icon and choosing 'disable clicktrough' in your Windows Bar.")
            NotifyIcon1.BalloonTipTitle = "Nenntrons Overlay Tool"
            NotifyIcon1.BalloonTipText = "Rightclick this Notify Icon at the bottom windows bar and choose 'disable clicktrough' to disable it."
            NotifyIcon1.ShowBalloonTip(20000)
            If Me.Opacity = 1 Then
                Me.Opacity = 0.99
                Label2.Text = "99%"
            End If
            clicktrough = True
            Me.RecreateHandle()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        If CheckBox1.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub EnableClicktroughToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableClicktroughToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        MessageBox.Show("You activated 'ClickTrough' which allows you to click trough the Form." & vbCrLf & vbCrLf & "You won't be able to click at the Form until you disabled it again!" & vbCrLf & vbCrLf & "You can disable it by rightclicking the Notification Icon and choosing 'disable clicktrough' in your Windows Bar.")
        NotifyIcon1.BalloonTipTitle = "Nenntrons Overlay Tool"
        NotifyIcon1.BalloonTipText = "Rightclick this Notify Icon at the bottom windows bar and choose 'disable clicktrough' to disable it."
        NotifyIcon1.ShowBalloonTip(20000)
        If Me.Opacity = 1 Then
            Me.Opacity = 0.99
            Label2.Text = "99%"
        End If
        clicktrough = True
        CheckBox2.Checked = True
        Me.RecreateHandle()
    End Sub

    Private Sub DisableClicktroughToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableClicktroughToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        clicktrough = False
        CheckBox2.Checked = False
        If Me.Opacity = 0.99 Then
            Me.Opacity = 1
            Label2.Text = "100%"
        End If
        Me.RecreateHandle()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.close, AudioPlayMode.WaitToComplete)
        Me.Close()
    End Sub

    Private Const WS_EX_TRANSPARENT As Integer = &H20

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If clicktrough = True Then
                cp.ExStyle = cp.ExStyle Or WS_EX_TRANSPARENT
            End If
            Return cp
        End Get
    End Property

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        If CheckBox3.Checked Then
            Me.ChromiumWebBrowser1.Size = New Size(1000, 820)
            Me.ChromiumWebBrowser1.Location = New Size(0, -145)
        Else
            Me.ChromiumWebBrowser1.Size = New Size(767, 600)
            Me.ChromiumWebBrowser1.Location = New Size(0, -30)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Process.Start("https://mapgenie.io/genshin-impact/maps/teyvat")
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.BackColor = Color.FromArgb(30, 50, 50)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Computer.Audio.Play(My.Resources.hover, AudioPlayMode.WaitToComplete)
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.FromArgb(50, 100, 50)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.FromArgb(39, 39, 39)
    End Sub
End Class