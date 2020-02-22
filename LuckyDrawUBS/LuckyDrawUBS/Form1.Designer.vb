Imports System.Data.OleDb
Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.lblWinner = New System.Windows.Forms.Label
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.launchLuckyDraw = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.launchLuckyDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(397, 345)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(497, 72)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 71)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(65, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 71)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(127, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 71)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(189, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 71)
        Me.Label4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(251, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 71)
        Me.Label5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(313, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 71)
        Me.Label6.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(375, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 71)
        Me.Label7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Impact", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(437, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 71)
        Me.Label8.TabIndex = 7
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'Timer7
        '
        '
        'Timer8
        '
        '
        'lblWinner
        '
        Me.lblWinner.BackColor = System.Drawing.Color.Transparent
        Me.lblWinner.Font = New System.Drawing.Font("Constantia", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWinner.Location = New System.Drawing.Point(221, 698)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(879, 72)
        Me.lblWinner.TabIndex = 9
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWinner.Visible = False
        '
        'Timer9
        '
        '
        'launchLuckyDraw
        '
        Me.launchLuckyDraw.Image = CType(resources.GetObject("launchLuckyDraw.Image"), System.Drawing.Image)
        Me.launchLuckyDraw.Location = New System.Drawing.Point(936, 123)
        Me.launchLuckyDraw.Name = "launchLuckyDraw"
        Me.launchLuckyDraw.Size = New System.Drawing.Size(116, 31)
        Me.launchLuckyDraw.TabIndex = 11
        Me.launchLuckyDraw.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(65, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 56)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(1200, 13)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(28, 15)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1272, 766)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.launchLuckyDraw)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Form1"
        Me.Text = "UBS SG IT Annual Gathering Lucky Draw"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.launchLuckyDraw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public names As ArrayList = New ArrayList
    Public gpin As ArrayList = New ArrayList
    Public listofWinGPIN As ArrayList = New ArrayList

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect to database and store data in array
        connectAccessDatabase()
        'MsgBox(gpin.Count.ToString + " gpin have been added")
        'MsgBox(names.Count.ToString + " people added in array")
        'MsgBox(Me.listofWinGPIN.Count.ToString)

        With Me
            .MaximizeBox = False
            .MinimizeBox = False
            .TopMost = True
            .FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            .WindowState = System.Windows.Forms.FormWindowState.Maximized
        End With



    End Sub

    Sub connectAccessDatabase()
        Dim cn As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        Try
            cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=luckydraw.mdb;")
            'provider to be used when working with access database
            cn.Open()
            cmd = New OleDbCommand("select * from employee_list_final", cn)
            dr = cmd.ExecuteReader()

            While dr.Read
                gpin.Add(dr(0))
                names.Add(dr(1))
            End While

            dr.Close()
            cn.Close()

        Catch ex As Exception


        End Try

    End Sub

    Sub showCounter(ByVal wG As String, ByVal wN As String)
        Dim G As Char() = wG.ToCharArray()

        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True

        Me.Timer2.Interval = 100
        Me.Timer2.Enabled = True

        Me.Timer3.Interval = 100
        Me.Timer3.Enabled = True

        Me.Timer4.Interval = 100
        Me.Timer4.Enabled = True

        Me.Timer5.Interval = 100
        Me.Timer5.Enabled = True

        Me.Timer6.Interval = 100
        Me.Timer6.Enabled = True

        Me.Timer7.Interval = 100
        Me.Timer7.Enabled = True

        Me.Timer8.Interval = 100
        Me.Timer8.Enabled = True

    End Sub



    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    Public iloop(8) As Integer
    Public jloop(8) As Integer
    Public winningGPN As String
    Public winningName As String

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If iloop(0) < 5 Then
            Me.Label1.Text = jloop(0).ToString
            jloop(0) = jloop(0) + 1

            If jloop(0) = 9 Then
                jloop(0) = 0
                iloop(0) = iloop(0) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(0))
                Me.Label1.Text = i.ToString
            Next

            'reset
            iloop(0) = 0
            jloop(0) = 0

            'stop the timer
            Me.Timer1.Enabled = False
        End If

    End Sub



    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If iloop(1) < 5 Then
            Me.Label2.Text = jloop(1).ToString
            jloop(1) = jloop(1) + 1

            If jloop(1) = 9 Then
                jloop(1) = 0
                iloop(1) = iloop(1) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(1))
                Me.Label2.Text = i.ToString
            Next

            'reset
            iloop(1) = 0
            jloop(1) = 0

            'stop the timer
            Me.Timer2.Enabled = False
        End If
    End Sub


    Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If iloop(2) < 5 Then
            Me.Label3.Text = jloop(2).ToString
            jloop(2) = jloop(2) + 1

            If jloop(2) = 9 Then
                jloop(2) = 0
                iloop(2) = iloop(2) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(2))
                Me.Label3.Text = i.ToString
            Next

            'reset
            iloop(2) = 0
            jloop(2) = 0

            'stop the timer
            Me.Timer3.Enabled = False
        End If
    End Sub


    Private Sub Timer4_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If iloop(3) < 5 Then
            Me.Label4.Text = jloop(3).ToString
            jloop(3) = jloop(3) + 1

            If jloop(3) = 9 Then
                jloop(3) = 0
                iloop(3) = iloop(3) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(3))
                Me.Label4.Text = i.ToString
            Next

            'reset
            iloop(3) = 0
            jloop(3) = 0

            'stop the timer
            Me.Timer4.Enabled = False
            Me.lblWinner.Visible = True
        End If
    End Sub


    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents Timer8 As System.Windows.Forms.Timer

    Private Sub Timer5_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        If iloop(4) < 5 Then
            Me.Label5.Text = jloop(4).ToString
            jloop(4) = jloop(4) + 1

            If jloop(4) = 9 Then
                jloop(4) = 0
                iloop(4) = iloop(4) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(4))
                Me.Label5.Text = i.ToString
            Next

            'reset
            iloop(4) = 0
            jloop(4) = 0

            'stop the timer
            Me.Timer5.Enabled = False
        End If
    End Sub



    Private Sub Timer6_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If iloop(5) < 5 Then
            Me.Label6.Text = jloop(5).ToString
            jloop(5) = jloop(5) + 1

            If jloop(5) = 9 Then
                jloop(5) = 0
                iloop(5) = iloop(5) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(5))
                Me.Label6.Text = i.ToString
            Next

            'reset
            iloop(5) = 0
            jloop(5) = 0

            'stop the timer
            Me.Timer6.Enabled = False
        End If
    End Sub


    Private Sub Timer7_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If iloop(6) < 5 Then
            Me.Label7.Text = jloop(6).ToString
            jloop(6) = jloop(6) + 1

            If jloop(6) = 9 Then
                jloop(6) = 0
                iloop(6) = iloop(6) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(6))
                Me.Label7.Text = i.ToString
            Next

            'reset
            iloop(6) = 0
            jloop(6) = 0

            'stop the timer
            Me.Timer7.Enabled = False
        End If
    End Sub


    Private Sub Timer8_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        If iloop(7) < 5 Then
            Me.Label8.Text = jloop(7).ToString
            jloop(7) = jloop(7) + 1

            If jloop(7) = 9 Then
                jloop(7) = 0
                iloop(7) = iloop(7) + 1
            End If
        Else
            'show winning digit
            Dim G As Char() = winningGPN.ToCharArray()

            Dim i As Integer
            For i = 0 To Char.GetNumericValue(G(7))
                Me.Label8.Text = i.ToString
            Next

            'reset
            iloop(7) = 0
            jloop(7) = 0

            'stop the timer
            Me.Timer8.Enabled = False
        End If
    End Sub
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents Timer9 As System.Windows.Forms.Timer

    Private Sub Timer9_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer9.Tick

        If Me.Timer1.Enabled = False And Me.Timer2.Enabled = False And Me.Timer3.Enabled = False And Me.Timer4.Enabled = False And Me.Timer5.Enabled = False And Me.Timer6.Enabled = False And Me.Timer7.Enabled = False And Me.Timer8.Enabled = False Then
            Me.lblWinner.Text = Me.winningName

            'stop the timer
            Me.Timer9.Enabled = False
        End If
        
    End Sub
    Friend WithEvents launchLuckyDraw As System.Windows.Forms.PictureBox


    Private Sub launchLuckyDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles launchLuckyDraw.Click

        'launching lucky draw

        Dim r As Random = New Random()
        Dim winningNo As Integer
repeat:
        Try
            winningNo = (r.Next(0, names.Count))


        Catch ex As Exception
            MsgBox(ex.Message.ToString + "  manual error caught" + " index = " + winningNo)
        End Try

        'check if winner is already in list
        If listofWinGPIN.Contains(names(winningNo)) Then
            'MsgBox("we have a repeat")
            'MsgBox("total count" + listofWinGPIN.Count.ToString)
            GoTo repeat
        End If

        'add winningNo in list
        listofWinGPIN.Add(names(winningNo))


        'get winning name and gpin
        winningGPN = gpin(winningNo)
        winningName = names(winningNo)

        'pad winning gpin if required
        Dim pad As Char = "0"
        If winningGPN.Length < 8 Then
            winningGPN = winningGPN.PadLeft(8, pad)
        End If

        'MsgBox(winningGPN + " won lottery, name is " + winningName)
        'MsgBox(listofWinGPIN.Item(0).ToString)
        'MsgBox(listofWinGPIN.Count.ToString)


        'make counter visible
        Me.FlowLayoutPanel1.Visible = True
        Me.lblWinner.Visible = False
        Me.lblWinner.Text = ""

        'show counter
        showCounter(winningGPN, winningName)

        'show name
        Me.Timer9.Interval = 8000
        Me.Timer9.Enabled = True

        'write to file
        writeWinningLog(winningName)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'write to file
        writeWinningEntrytoFile()

        Me.Close()
        Application.Exit()
    End Sub

    Private Sub writeWinningEntrytoFile()
        Dim fs As New FileStream("winninglist.txt", FileMode.Append, FileAccess.Write)
        'declaring a FileStream and creating a word document file named file with 
        'access mode of writing
        Dim s As New StreamWriter(fs)
        'creating a new StreamWriter and passing the filestream object fs as argument
        s.BaseStream.Seek(0, SeekOrigin.End)
        'the seek method is used to move the cursor to next position to avoid text to be
        'overwritten
        Dim i As Integer
        For i = 0 To Me.listofWinGPIN.Count - 1
            s.WriteLine(Me.listofWinGPIN.Item(i).ToString)
        Next
        'writing text to the newly created file
        s.WriteLine("--------Round over ------")
        s.Close()
        'closing the file
    End Sub

    Private Sub writeWinningLog(ByVal winName As String)
        Dim fs As New FileStream("winninglog.txt", FileMode.Append, FileAccess.Write)
        'declaring a FileStream and creating a word document file named file with 
        'access mode of writing
        Dim s As New StreamWriter(fs)
        'creating a new StreamWriter and passing the filestream object fs as argument
        s.BaseStream.Seek(0, SeekOrigin.End)
        'the seek method is used to move the cursor to next position to avoid text to be
        'overwritten
        'writing text to the newly created file
        s.WriteLine(winName)
        s.Close()
        'closing the file
    End Sub

End Class


