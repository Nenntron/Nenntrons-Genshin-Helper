Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Form6_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    'The Code below is all Code to extract the dlls and exes needed for the CEFSharp Browser. You can google that if you don't trust me.

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\CefSharp.BrowserSubprocess.exe") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\CefSharp.BrowserSubprocess.exe", My.Resources.CefSharp_BrowserSubprocess)
        End If
        Me.ProgressBar1.Value = 5
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\CefSharp.BrowserSubprocess.Core.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\CefSharp.BrowserSubprocess.Core.dll", My.Resources.CefSharp_BrowserSubprocess_Core)
        End If
        Me.ProgressBar1.Value = 11
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\CefSharp.Core.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\CefSharp.Core.dll", My.Resources.CefSharp_Core)
        End If
        Me.ProgressBar1.Value = 16
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\CefSharp.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\CefSharp.dll", My.Resources.CefSharp)
        End If
        Me.ProgressBar1.Value = 22
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\CefSharp.WinForms.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\CefSharp.WinForms.dll", My.Resources.CefSharp_WinForms)
        End If
        Me.ProgressBar1.Value = 27
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\chrome_elf.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\chrome_elf.dll", My.Resources.chrome_elf)
        End If
        Me.ProgressBar1.Value = 33
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\d3dcompiler_47.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\d3dcompiler_47.dll", My.Resources.d3dcompiler_47)
        End If
        Me.ProgressBar1.Value = 38
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\libcef.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\libcef.dll", My.Resources.libcef)
        End If
        Me.ProgressBar1.Value = 44
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\libEGL.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\libEGL.dll", My.Resources.libEGL)
        End If
        Me.ProgressBar1.Value = 49
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\libGLESv2.dll") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\libGLESv2.dll", My.Resources.libGLESv2)
        End If
        Me.ProgressBar1.Value = 55
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\snapshot_blob.bin") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\snapshot_blob.bin", My.Resources.snapshot_blob)
        End If
        Me.ProgressBar1.Value = 60
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\v8_context_snapshot.bin") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\v8_context_snapshot.bin", My.Resources.v8_context_snapshot)
        End If
        Me.ProgressBar1.Value = 66
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\icudtl.dat") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\icudtl.dat", My.Resources.icudtl)
        End If
        Me.ProgressBar1.Value = 71
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\cef.pak") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\cef.pak", My.Resources.cef)
        End If
        Me.ProgressBar1.Value = 77
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\cef_100_percent.pak") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\cef_100_percent.pak", My.Resources.cef_100_percent)
        End If
        Me.ProgressBar1.Value = 82
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\cef_200_percent.pak") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\cef_200_percent.pak", My.Resources.cef_200_percent)
        End If
        Me.ProgressBar1.Value = 88
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\cef_extensions.pak") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\cef_extensions.pak", My.Resources.cef_extensions)
        End If
        Me.ProgressBar1.Value = 93
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\devtools_resources.pak") Then
            System.IO.File.WriteAllBytes(Application.StartupPath & "\devtools_resources.pak", My.Resources.devtools_resources)
        End If
        Me.ProgressBar1.Value = 100
        Threading.Thread.Sleep(1000)
        Me.Close()
    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Form1.Stringform = 3 Then
            Form3.Show()
        ElseIf Form1.Stringform = 4 Then
            Form4.Show()
        ElseIf Form1.Stringform = 5 Then
            Form5.Show()
        End If
    End Sub
End Class