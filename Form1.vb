Imports Scripting
Imports System.IO

Public Class Form1
    Dim AutoRun As Boolean = False
    Dim AutoMin As Boolean = False
    '读ini API函数
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    '写ini API函数
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    '读取ini文件内容
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function
    '写ini文件操作
    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function

    Private Sub Button_SelPs_Click(sender As Object, e As EventArgs) Handles Button_SelPs.Click
        OFD.ShowDialog()
        TextBox_Ps.Text = OFD.FileName
    End Sub

    Private Sub Button_SelDir_Click(sender As Object, e As EventArgs) Handles Button_SelDir.Click
        FB.ShowDialog()
        TextBox_Dir.Text = FB.SelectedPath
        If TextBox_Dir.Text <> "" Then
            Button_Start.Enabled = True
            Button_Clear.Enabled = True
            ToolStripMenuItem_Start.Enabled = True
            GetFNumAndFSize(TextBox_Dir.Text)
            If AutoRun = True Then
                Call Button_Start_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        If TextBox_Ps.Text <> "" Then
            If TextBox_Dir.Text <> "" Then
                If My.Computer.FileSystem.FileExists(TextBox_Ps.Text) = True Then
                    If My.Computer.FileSystem.DirectoryExists(TextBox_Dir.Text) = True Then
                        FS.Path = TextBox_Dir.Text
                        FS.EnableRaisingEvents = True
                        Button_Stop.Enabled = True
                        ToolStripMenuItem_Stop.Enabled = True
                        ToolStripMenuItem_Start.Enabled = False
                        Button_Start.Enabled = False
                        Button_SelDir.Enabled = False
                        Button_SelPs.Enabled = False
                        Button_Clear.Enabled = False
                        ToolStripStatusLabel_State.Text = "服务已启动"
                        ToolStripStatusLabel_State.ForeColor = Color.Green
                        If AutoMin = True Then
                            Me.WindowState = FormWindowState.Minimized
                        End If
                    Else
                        MsgBox("目录不存在，请重新选择！", MsgBoxStyle.OkOnly, "注意")
                    End If
                Else
                    MsgBox("Photoshop路径设置错误，请重新选择！", MsgBoxStyle.OkOnly, "注意")
                End If
            Else
                MsgBox("请选择图片目录！！！", MsgBoxStyle.OkOnly, "注意")
            End If
        Else
            MsgBox("请选择Photoshop路径！！！", MsgBoxStyle.OkOnly, "注意")
        End If

    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        FS.EnableRaisingEvents = False
        Button_Stop.Enabled = False
        Button_Start.Enabled = True
        Button_SelDir.Enabled = True
        Button_SelPs.Enabled = True
        Button_Clear.Enabled = True
        ToolStripMenuItem_Start.Enabled = True
        ToolStripMenuItem_Stop.Enabled = False
        ToolStripStatusLabel_State.Text = "服务未启动"
        ToolStripStatusLabel_State.ForeColor = Color.Red
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTheConfig()
        If TextBox_Ps.Text <> "" Then
            If TextBox_Dir.Text <> "" Then
                Button_Start.Enabled = True
                Button_Clear.Enabled = True
                ToolStripMenuItem_Start.Enabled = True
                GetFNumAndFSize(TextBox_Dir.Text)
                If AutoRun = True Then
                    Call Button_Start_Click(Nothing, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If CheckBox_AutoMin.Checked = True Then
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub FS_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FS.Created
        Dim FExt As String
        FExt = GetFileExt(e.Name)
        Dim PicExt As String = TextBox_Ext.Text
        If InStr(PicExt, FExt, Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
            ListBox_Log.Items.Add("文件：" & e.Name & "  " & "时间：" & My.Computer.Clock.LocalTime)
            GetFNumAndFSize(TextBox_Dir.Text)
            NotifyIcon1.ShowBalloonTip(3000, "Open With Photoshop", "正在打开" & e.Name, ToolTipIcon.Info)
            Dim PsPath As String = TextBox_Ps.Text
            Dim PicPath As String = e.FullPath
            Shell(PsPath & " " & PicPath)
        End If
    End Sub

    Sub GetFNumAndFSize(FPath As String)
        If FPath.Length <= 3 Then
            Button_Start.Enabled = False
            Button_Clear.Enabled = False
            TextBox_Dir.Text = ""
            MsgBox("请勿选择驱动器！", MsgBoxStyle.OkOnly, "注意")
        Else
            Dim Fso As New FileSystemObject
            Dim FNum As Integer = 0
            Dim FSize As Double = 0
            FNum = Fso.GetFolder(FPath).Files.Count
            FSize = (Fso.GetFolder(FPath).Size) / 1024
            If FSize >= 1000 Then
                FSize = FSize / 1024
                If FSize >= 1000 Then
                    FSize = FSize / 1024
                    ToolStripStatusLabel_FileSize.Text = "目录共 " & FNum & " 个文件，总大小 " & Format(FSize, "0.00") & "GB"
                Else
                    ToolStripStatusLabel_FileSize.Text = "目录共 " & FNum & " 个文件，总大小 " & Format(FSize, "0.00") & "MB"
                End If
            Else
                ToolStripStatusLabel_FileSize.Text = "目录共 " & FNum & " 个文件，总大小 " & Format(FSize, "0.00") & "KB"
            End If

        End If
    End Sub

    Function GetFileExt(FileName As String) As String
        Dim L As Integer = FileName.Length
        Dim b As Integer = 0
        Dim a As String = ""
        For i = L To 1 Step -1
            a = Mid(FileName, i, 1)
            If a = "." Then
                b = i
                Exit For
            End If
        Next
        If b = 0 Then
            GetFileExt = "NoExtension"
        Else
            GetFileExt = Mid(FileName, b + 1, L - b)
        End If

    End Function

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        If MsgBox("是否删除所选目录下所有文件（不包括文件夹）？" & Chr(10) & "删除的文件将被移入回收站中！", MsgBoxStyle.OkCancel, "删除") = MsgBoxResult.Ok Then
            Dim curDir As New DirectoryInfo(TextBox_Dir.Text)
            Dim fileInfo As FileInfo()
            fileInfo = curDir.GetFiles()
            For Each FilePath In fileInfo
                Dim fullpath As String = TextBox_Dir.Text & "\" & (FilePath).ToString
                If IO.File.Exists(fullpath) = True Then
                    My.Computer.FileSystem.DeleteFile(fullpath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                End If
            Next
            ListBox_Log.Items.Clear()
        End If
        GetFNumAndFSize(TextBox_Dir.Text)
    End Sub

    Sub LoadTheConfig()
        If Dir(Application.StartupPath & "\Config.ini") = "" Then
            MsgBox("配置文件Config.ini丢失，将自动创建！")
            Dim b() As Byte = My.Resources.Config  '将资源文件转换为Byte()
            Dim s As IO.Stream = System.IO.File.Create("Config.ini")   '设定文件创建位置
            s.Write(b, 0, b.Length)    '文件写入
            s.Close()     '关闭文件
        Else
            Dim ConfigPath As String = Application.StartupPath & "\Config.ini"
            TextBox_Ps.Text = GetINI("Config", "PsPath", "", ConfigPath)
            TextBox_Dir.Text = GetINI("Config", "TempDir", "", ConfigPath)
            TextBox_Ext.Text = GetINI("Config", "Extension", "", ConfigPath)
            If GetINI("Config", "AutoRun", "", ConfigPath) = 1 Then
                CheckBox_AutoRun.Checked = True
            ElseIf GetINI("Config", "AutoRun", "", ConfigPath) = 0 Then
                CheckBox_AutoRun.Checked = False
            Else
                CheckBox_AutoRun.Checked = False
            End If
            If GetINI("Config", "AutoMin", "", ConfigPath) = 1 Then
                CheckBox_AutoMin.Checked = True
            ElseIf GetINI("Config", "AutoMin", "", ConfigPath) = 0 Then
                CheckBox_AutoMin.Checked = False
            Else
                CheckBox_AutoMin.Checked = False
            End If
        End If

    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Try
            Dim ConfigPath As String
            ConfigPath = Application.StartupPath + "\Config.ini"
            WriteINI("Config", "PsPath", TextBox_Ps.Text, ConfigPath)
            WriteINI("Config", "TempDir", TextBox_Dir.Text, ConfigPath)
            WriteINI("Config", "Extension", TextBox_Ext.Text, ConfigPath)
            If CheckBox_AutoRun.Checked = True Then
                WriteINI("Config", "AutoRun", 1, ConfigPath)
            Else
                WriteINI("Config", "AutoRun", 0, ConfigPath)
            End If
            If CheckBox_AutoMin.Checked = True Then
                WriteINI("Config", "AutoMin", 1, ConfigPath)
            Else
                WriteINI("Config", "AutoMin", 0, ConfigPath)
            End If
            MsgBox("配置保存完毕！", MsgBoxStyle.OkOnly, "成功")
        Catch ex As Exception
            MsgBox("发生未知错误，请手动编辑！", MsgBoxStyle.OkOnly, "失败")
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Start_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Start.Click
        Call Button_Start_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem_Stop_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Stop.Click
        Call Button_Stop_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem_Exit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Exit.Click
        Call Button_Stop_Click(Nothing, Nothing)
        Me.Close()
    End Sub

    Private Sub CheckBox_AutoRun_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AutoRun.CheckedChanged
        If CheckBox_AutoRun.Checked = True Then
            AutoRun = True
        Else
            AutoRun = False
        End If
    End Sub

    Private Sub CheckBox_AutoMin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AutoMin.CheckedChanged
        If CheckBox_AutoMin.Checked = True Then
            AutoMin = True
        Else
            AutoMin = False
        End If
    End Sub
End Class
