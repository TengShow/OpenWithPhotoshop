<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Ps = New System.Windows.Forms.TextBox()
        Me.TextBox_Dir = New System.Windows.Forms.TextBox()
        Me.Button_SelPs = New System.Windows.Forms.Button()
        Me.Button_SelDir = New System.Windows.Forms.Button()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.ListBox_Log = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.FB = New System.Windows.Forms.FolderBrowserDialog()
        Me.FS = New System.IO.FileSystemWatcher()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_Start = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Stop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Ext = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_State = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_FileSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckBox_AutoRun = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AutoMin = New System.Windows.Forms.CheckBox()
        CType(Me.FS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Photoshop"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pic Dir"
        '
        'TextBox_Ps
        '
        Me.TextBox_Ps.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox_Ps.Location = New System.Drawing.Point(73, 17)
        Me.TextBox_Ps.Name = "TextBox_Ps"
        Me.TextBox_Ps.ReadOnly = True
        Me.TextBox_Ps.Size = New System.Drawing.Size(363, 21)
        Me.TextBox_Ps.TabIndex = 2
        '
        'TextBox_Dir
        '
        Me.TextBox_Dir.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox_Dir.Location = New System.Drawing.Point(73, 44)
        Me.TextBox_Dir.Name = "TextBox_Dir"
        Me.TextBox_Dir.ReadOnly = True
        Me.TextBox_Dir.Size = New System.Drawing.Size(363, 21)
        Me.TextBox_Dir.TabIndex = 3
        '
        'Button_SelPs
        '
        Me.Button_SelPs.Location = New System.Drawing.Point(445, 15)
        Me.Button_SelPs.Name = "Button_SelPs"
        Me.Button_SelPs.Size = New System.Drawing.Size(75, 23)
        Me.Button_SelPs.TabIndex = 4
        Me.Button_SelPs.Text = "选择"
        Me.Button_SelPs.UseVisualStyleBackColor = True
        '
        'Button_SelDir
        '
        Me.Button_SelDir.Location = New System.Drawing.Point(445, 42)
        Me.Button_SelDir.Name = "Button_SelDir"
        Me.Button_SelDir.Size = New System.Drawing.Size(75, 23)
        Me.Button_SelDir.TabIndex = 5
        Me.Button_SelDir.Text = "选择"
        Me.Button_SelDir.UseVisualStyleBackColor = True
        '
        'Button_Start
        '
        Me.Button_Start.Enabled = False
        Me.Button_Start.Location = New System.Drawing.Point(253, 107)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 38)
        Me.Button_Start.TabIndex = 0
        Me.Button_Start.Text = "开始监控"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Enabled = False
        Me.Button_Stop.Location = New System.Drawing.Point(350, 107)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(75, 38)
        Me.Button_Stop.TabIndex = 1
        Me.Button_Stop.Text = "停止监控"
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'ListBox_Log
        '
        Me.ListBox_Log.FormattingEnabled = True
        Me.ListBox_Log.ItemHeight = 12
        Me.ListBox_Log.Location = New System.Drawing.Point(73, 159)
        Me.ListBox_Log.Name = "ListBox_Log"
        Me.ListBox_Log.Size = New System.Drawing.Size(363, 112)
        Me.ListBox_Log.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Log"
        '
        'Button_Clear
        '
        Me.Button_Clear.Enabled = False
        Me.Button_Clear.Location = New System.Drawing.Point(445, 159)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 10
        Me.Button_Clear.Text = "清空目录"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(445, 69)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 11
        Me.Button_Save.Text = "保存设置"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'FS
        '
        Me.FS.EnableRaisingEvents = True
        Me.FS.IncludeSubdirectories = True
        Me.FS.NotifyFilter = CType((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.Size), System.IO.NotifyFilters)
        Me.FS.SynchronizingObject = Me
        '
        'OFD
        '
        Me.OFD.FileName = "Photoshop.exe"
        Me.OFD.Filter = "可执行文件|*.exe"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Tag = "Open With Photoshop"
        Me.NotifyIcon1.Text = "Open With Photoshop"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Start, Me.ToolStripMenuItem_Stop, Me.ToolStripMenuItem_Exit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 70)
        '
        'ToolStripMenuItem_Start
        '
        Me.ToolStripMenuItem_Start.Enabled = False
        Me.ToolStripMenuItem_Start.Name = "ToolStripMenuItem_Start"
        Me.ToolStripMenuItem_Start.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem_Start.Text = "开始监控"
        '
        'ToolStripMenuItem_Stop
        '
        Me.ToolStripMenuItem_Stop.Enabled = False
        Me.ToolStripMenuItem_Stop.Name = "ToolStripMenuItem_Stop"
        Me.ToolStripMenuItem_Stop.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem_Stop.Text = "停止监控"
        '
        'ToolStripMenuItem_Exit
        '
        Me.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit"
        Me.ToolStripMenuItem_Exit.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem_Exit.Text = "退出"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Extension"
        '
        'TextBox_Ext
        '
        Me.TextBox_Ext.Location = New System.Drawing.Point(73, 71)
        Me.TextBox_Ext.Name = "TextBox_Ext"
        Me.TextBox_Ext.Size = New System.Drawing.Size(363, 21)
        Me.TextBox_Ext.TabIndex = 14
        Me.TextBox_Ext.Text = ".jpeg.jpg.png.bmp.gif.psd"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_State, Me.ToolStripStatusLabel_FileSize})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 284)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(532, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_State
        '
        Me.ToolStripStatusLabel_State.AutoSize = False
        Me.ToolStripStatusLabel_State.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel_State.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel_State.Name = "ToolStripStatusLabel_State"
        Me.ToolStripStatusLabel_State.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel_State.Text = "服务未启动"
        '
        'ToolStripStatusLabel_FileSize
        '
        Me.ToolStripStatusLabel_FileSize.Name = "ToolStripStatusLabel_FileSize"
        Me.ToolStripStatusLabel_FileSize.Size = New System.Drawing.Size(187, 17)
        Me.ToolStripStatusLabel_FileSize.Text = "目录共 0 个文件，总大小 0.00KB"
        '
        'CheckBox_AutoRun
        '
        Me.CheckBox_AutoRun.AutoSize = True
        Me.CheckBox_AutoRun.Location = New System.Drawing.Point(73, 107)
        Me.CheckBox_AutoRun.Name = "CheckBox_AutoRun"
        Me.CheckBox_AutoRun.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_AutoRun.TabIndex = 17
        Me.CheckBox_AutoRun.Text = "自动运行"
        Me.CheckBox_AutoRun.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoMin
        '
        Me.CheckBox_AutoMin.AutoSize = True
        Me.CheckBox_AutoMin.Location = New System.Drawing.Point(151, 107)
        Me.CheckBox_AutoMin.Name = "CheckBox_AutoMin"
        Me.CheckBox_AutoMin.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox_AutoMin.TabIndex = 18
        Me.CheckBox_AutoMin.Text = "运行后最小化"
        Me.CheckBox_AutoMin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 306)
        Me.Controls.Add(Me.CheckBox_AutoMin)
        Me.Controls.Add(Me.CheckBox_AutoRun)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBox_Ext)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox_Log)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.Button_SelDir)
        Me.Controls.Add(Me.Button_SelPs)
        Me.Controls.Add(Me.TextBox_Dir)
        Me.Controls.Add(Me.TextBox_Ps)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open With Photoshop"
        CType(Me.FS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Ps As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Dir As System.Windows.Forms.TextBox
    Friend WithEvents Button_SelPs As System.Windows.Forms.Button
    Friend WithEvents Button_SelDir As System.Windows.Forms.Button
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Button_Stop As System.Windows.Forms.Button
    Friend WithEvents ListBox_Log As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents FB As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FS As System.IO.FileSystemWatcher
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TextBox_Ext As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel_State As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_FileSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_Start As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Stop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox_AutoMin As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_AutoRun As System.Windows.Forms.CheckBox

End Class
