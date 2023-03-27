<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MOP))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.upil = New System.Windows.Forms.Label()
        Me.upitxt = New System.Windows.Forms.TextBox()
        Me.expdate = New System.Windows.Forms.DateTimePicker()
        Me.crdn = New System.Windows.Forms.Label()
        Me.crdtxt = New System.Windows.Forms.TextBox()
        Me.expl = New System.Windows.Forms.Label()
        Me.cvv = New System.Windows.Forms.TextBox()
        Me.cvvl = New System.Windows.Forms.Label()
        Me.UPI = New System.Windows.Forms.Button()
        Me.Card = New System.Windows.Forms.Button()
        Me.Cash = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.UPI)
        Me.Panel1.Controls.Add(Me.Card)
        Me.Panel1.Controls.Add(Me.Cash)
        Me.Panel1.Location = New System.Drawing.Point(51, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 406)
        Me.Panel1.TabIndex = 0
        '
        'upil
        '
        Me.upil.AutoSize = True
        Me.upil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.upil.Location = New System.Drawing.Point(25, 18)
        Me.upil.Name = "upil"
        Me.upil.Size = New System.Drawing.Size(61, 22)
        Me.upil.TabIndex = 9
        Me.upil.Text = "UPI ID"
        '
        'upitxt
        '
        Me.upitxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upitxt.Location = New System.Drawing.Point(88, 16)
        Me.upitxt.Name = "upitxt"
        Me.upitxt.Size = New System.Drawing.Size(247, 27)
        Me.upitxt.TabIndex = 4
        '
        'expdate
        '
        Me.expdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.expdate.Location = New System.Drawing.Point(101, 39)
        Me.expdate.Name = "expdate"
        Me.expdate.Size = New System.Drawing.Size(107, 22)
        Me.expdate.TabIndex = 8
        '
        'crdn
        '
        Me.crdn.AutoSize = True
        Me.crdn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crdn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.crdn.Location = New System.Drawing.Point(9, 6)
        Me.crdn.Name = "crdn"
        Me.crdn.Size = New System.Drawing.Size(78, 20)
        Me.crdn.TabIndex = 6
        Me.crdn.Text = "Card No"
        '
        'crdtxt
        '
        Me.crdtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crdtxt.Location = New System.Drawing.Point(101, 0)
        Me.crdtxt.MaxLength = 14
        Me.crdtxt.Name = "crdtxt"
        Me.crdtxt.Size = New System.Drawing.Size(227, 27)
        Me.crdtxt.TabIndex = 3
        '
        'expl
        '
        Me.expl.AutoSize = True
        Me.expl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.expl.Location = New System.Drawing.Point(8, 37)
        Me.expl.Name = "expl"
        Me.expl.Size = New System.Drawing.Size(87, 25)
        Me.expl.TabIndex = 7
        Me.expl.Text = "exp.date"
        '
        'cvv
        '
        Me.cvv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvv.Location = New System.Drawing.Point(264, 36)
        Me.cvv.MaxLength = 3
        Me.cvv.Name = "cvv"
        Me.cvv.Size = New System.Drawing.Size(64, 27)
        Me.cvv.TabIndex = 5
        '
        'cvvl
        '
        Me.cvvl.AutoSize = True
        Me.cvvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cvvl.Location = New System.Drawing.Point(215, 37)
        Me.cvvl.Name = "cvvl"
        Me.cvvl.Size = New System.Drawing.Size(42, 25)
        Me.cvvl.TabIndex = 5
        Me.cvvl.Text = "cvv"
        '
        'UPI
        '
        Me.UPI.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.UPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPI.ForeColor = System.Drawing.SystemColors.Control
        Me.UPI.Location = New System.Drawing.Point(52, 269)
        Me.UPI.Name = "UPI"
        Me.UPI.Size = New System.Drawing.Size(350, 62)
        Me.UPI.TabIndex = 2
        Me.UPI.Text = "UPI"
        Me.UPI.UseVisualStyleBackColor = False
        '
        'Card
        '
        Me.Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Card.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Card.ForeColor = System.Drawing.SystemColors.Control
        Me.Card.Location = New System.Drawing.Point(52, 125)
        Me.Card.Name = "Card"
        Me.Card.Size = New System.Drawing.Size(350, 62)
        Me.Card.TabIndex = 1
        Me.Card.Text = "Card"
        Me.Card.UseVisualStyleBackColor = False
        '
        'Cash
        '
        Me.Cash.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.ForeColor = System.Drawing.SystemColors.Control
        Me.Cash.Location = New System.Drawing.Point(52, 20)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(350, 62)
        Me.Cash.TabIndex = 0
        Me.Cash.Text = "Cash"
        Me.Cash.UseCompatibleTextRendering = True
        Me.Cash.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel2.Controls.Add(Me.X)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-8, -9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(660, 71)
        Me.Panel2.TabIndex = 1
        '
        'X
        '
        Me.X.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.X.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X.ForeColor = System.Drawing.SystemColors.Control
        Me.X.Location = New System.Drawing.Point(513, 0)
        Me.X.Margin = New System.Windows.Forms.Padding(0)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(60, 80)
        Me.X.TabIndex = 4
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(170, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mode Of Payment"
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.SystemColors.Control
        Me.OK.Location = New System.Drawing.Point(192, 560)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(192, 55)
        Me.OK.TabIndex = 3
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.expdate)
        Me.Panel3.Controls.Add(Me.crdtxt)
        Me.Panel3.Controls.Add(Me.cvvl)
        Me.Panel3.Controls.Add(Me.crdn)
        Me.Panel3.Controls.Add(Me.cvv)
        Me.Panel3.Controls.Add(Me.expl)
        Me.Panel3.Location = New System.Drawing.Point(53, 185)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(347, 67)
        Me.Panel3.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.upil)
        Me.Panel4.Controls.Add(Me.upitxt)
        Me.Panel4.Location = New System.Drawing.Point(53, 331)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(347, 58)
        Me.Panel4.TabIndex = 13
        '
        'MOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(561, 768)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents UPI As Windows.Forms.Button
    Friend WithEvents Card As Windows.Forms.Button
    Friend WithEvents Cash As Windows.Forms.Button
    Friend WithEvents X As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents OK As Windows.Forms.Button
    Friend WithEvents upitxt As Windows.Forms.TextBox
    Friend WithEvents crdtxt As Windows.Forms.TextBox
    Friend WithEvents cvv As Windows.Forms.TextBox
    Friend WithEvents expl As Windows.Forms.Label
    Friend WithEvents crdn As Windows.Forms.Label
    Friend WithEvents cvvl As Windows.Forms.Label
    Friend WithEvents upil As Windows.Forms.Label
    Friend WithEvents expdate As Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
End Class
