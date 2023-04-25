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
        Me.upipanel = New System.Windows.Forms.Panel()
        Me.upil = New System.Windows.Forms.Label()
        Me.upitxt = New System.Windows.Forms.TextBox()
        Me.cardpanel = New System.Windows.Forms.Panel()
        Me.expdate = New System.Windows.Forms.DateTimePicker()
        Me.crdtxt = New System.Windows.Forms.TextBox()
        Me.cvvl = New System.Windows.Forms.Label()
        Me.crdn = New System.Windows.Forms.Label()
        Me.cvv = New System.Windows.Forms.TextBox()
        Me.expl = New System.Windows.Forms.Label()
        Me.UPI = New System.Windows.Forms.Button()
        Me.Card = New System.Windows.Forms.Button()
        Me.Cash = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.upipanel.SuspendLayout()
        Me.cardpanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.upipanel)
        Me.Panel1.Controls.Add(Me.cardpanel)
        Me.Panel1.Controls.Add(Me.UPI)
        Me.Panel1.Controls.Add(Me.Card)
        Me.Panel1.Controls.Add(Me.Cash)
        Me.Panel1.Location = New System.Drawing.Point(39, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 406)
        Me.Panel1.TabIndex = 0
        '
        'upipanel
        '
        Me.upipanel.BackgroundImage = CType(resources.GetObject("upipanel.BackgroundImage"), System.Drawing.Image)
        Me.upipanel.Controls.Add(Me.upil)
        Me.upipanel.Controls.Add(Me.upitxt)
        Me.upipanel.Location = New System.Drawing.Point(52, 331)
        Me.upipanel.Name = "upipanel"
        Me.upipanel.Size = New System.Drawing.Size(364, 58)
        Me.upipanel.TabIndex = 13
        '
        'upil
        '
        Me.upil.AutoSize = True
        Me.upil.BackColor = System.Drawing.Color.Transparent
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
        Me.upitxt.AutoCompleteCustomSource.AddRange(New String() {"@okaxis", "@okhdfcbank", "@upi", "@kotak", "@ybl", "@paytm", "@icici", "@sbi", "@idfc", "@axisbank", "@barodampay", "@okicici"})
        Me.upitxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.upitxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.upitxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upitxt.Location = New System.Drawing.Point(88, 16)
        Me.upitxt.Name = "upitxt"
        Me.upitxt.Size = New System.Drawing.Size(247, 27)
        Me.upitxt.TabIndex = 4
        '
        'cardpanel
        '
        Me.cardpanel.BackgroundImage = CType(resources.GetObject("cardpanel.BackgroundImage"), System.Drawing.Image)
        Me.cardpanel.Controls.Add(Me.expdate)
        Me.cardpanel.Controls.Add(Me.crdtxt)
        Me.cardpanel.Controls.Add(Me.cvvl)
        Me.cardpanel.Controls.Add(Me.crdn)
        Me.cardpanel.Controls.Add(Me.cvv)
        Me.cardpanel.Controls.Add(Me.expl)
        Me.cardpanel.Location = New System.Drawing.Point(49, 185)
        Me.cardpanel.Name = "cardpanel"
        Me.cardpanel.Size = New System.Drawing.Size(367, 67)
        Me.cardpanel.TabIndex = 12
        '
        'expdate
        '
        Me.expdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.expdate.Location = New System.Drawing.Point(110, 39)
        Me.expdate.Name = "expdate"
        Me.expdate.Size = New System.Drawing.Size(107, 22)
        Me.expdate.TabIndex = 8
        '
        'crdtxt
        '
        Me.crdtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crdtxt.Location = New System.Drawing.Point(110, 0)
        Me.crdtxt.MaxLength = 14
        Me.crdtxt.Name = "crdtxt"
        Me.crdtxt.Size = New System.Drawing.Size(227, 27)
        Me.crdtxt.TabIndex = 3
        '
        'cvvl
        '
        Me.cvvl.AutoSize = True
        Me.cvvl.BackColor = System.Drawing.Color.Transparent
        Me.cvvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cvvl.Location = New System.Drawing.Point(224, 37)
        Me.cvvl.Name = "cvvl"
        Me.cvvl.Size = New System.Drawing.Size(42, 25)
        Me.cvvl.TabIndex = 5
        Me.cvvl.Text = "cvv"
        '
        'crdn
        '
        Me.crdn.AutoSize = True
        Me.crdn.BackColor = System.Drawing.Color.Transparent
        Me.crdn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crdn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.crdn.Location = New System.Drawing.Point(-2, 6)
        Me.crdn.Name = "crdn"
        Me.crdn.Size = New System.Drawing.Size(78, 20)
        Me.crdn.TabIndex = 6
        Me.crdn.Text = "Card No"
        '
        'cvv
        '
        Me.cvv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvv.Location = New System.Drawing.Point(273, 36)
        Me.cvv.MaxLength = 3
        Me.cvv.Name = "cvv"
        Me.cvv.Size = New System.Drawing.Size(64, 27)
        Me.cvv.TabIndex = 5
        '
        'expl
        '
        Me.expl.AutoSize = True
        Me.expl.BackColor = System.Drawing.Color.Transparent
        Me.expl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.expl.Location = New System.Drawing.Point(-2, 37)
        Me.expl.Name = "expl"
        Me.expl.Size = New System.Drawing.Size(87, 25)
        Me.expl.TabIndex = 7
        Me.expl.Text = "exp.date"
        '
        'UPI
        '
        Me.UPI.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.UPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPI.ForeColor = System.Drawing.SystemColors.Control
        Me.UPI.Location = New System.Drawing.Point(49, 269)
        Me.UPI.Name = "UPI"
        Me.UPI.Size = New System.Drawing.Size(369, 62)
        Me.UPI.TabIndex = 2
        Me.UPI.Text = "UPI"
        Me.UPI.UseVisualStyleBackColor = False
        '
        'Card
        '
        Me.Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Card.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Card.ForeColor = System.Drawing.SystemColors.Control
        Me.Card.Location = New System.Drawing.Point(49, 125)
        Me.Card.Name = "Card"
        Me.Card.Size = New System.Drawing.Size(369, 62)
        Me.Card.TabIndex = 1
        Me.Card.Text = "Card"
        Me.Card.UseVisualStyleBackColor = False
        '
        'Cash
        '
        Me.Cash.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.ForeColor = System.Drawing.SystemColors.Control
        Me.Cash.Location = New System.Drawing.Point(49, 20)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(369, 62)
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
        Me.upipanel.ResumeLayout(False)
        Me.upipanel.PerformLayout()
        Me.cardpanel.ResumeLayout(False)
        Me.cardpanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents upipanel As Windows.Forms.Panel
    Friend WithEvents cardpanel As Windows.Forms.Panel
End Class
