<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.apino = New System.Windows.Forms.TextBox()
        Me.sndnm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.msg = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(173, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "API ID"
        '
        'apino
        '
        Me.apino.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apino.Location = New System.Drawing.Point(280, 99)
        Me.apino.Name = "apino"
        Me.apino.Size = New System.Drawing.Size(359, 34)
        Me.apino.TabIndex = 2
        '
        'sndnm
        '
        Me.sndnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sndnm.Location = New System.Drawing.Point(280, 171)
        Me.sndnm.Name = "sndnm"
        Me.sndnm.Size = New System.Drawing.Size(359, 34)
        Me.sndnm.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(86, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sender Name"
        '
        'cnum
        '
        Me.cnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnum.Location = New System.Drawing.Point(280, 223)
        Me.cnum.Name = "cnum"
        Me.cnum.Size = New System.Drawing.Size(359, 34)
        Me.cnum.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(91, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phone number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(139, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Message"
        '
        'msg
        '
        Me.msg.Location = New System.Drawing.Point(287, 282)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(351, 79)
        Me.msg.TabIndex = 8
        Me.msg.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(262, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 56)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(280, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(358, 22)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "Mzk2YzY5NjIzODcyNDMzMjY1NjU2NjU1NjY2MzQ1NzU="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(209, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ref ID"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 73)
        Me.Panel1.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sndnm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.apino)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents apino As Windows.Forms.TextBox
    Friend WithEvents sndnm As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cnum As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents msg As Windows.Forms.RichTextBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
End Class
