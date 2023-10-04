<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radTwenty = New System.Windows.Forms.RadioButton()
        Me.radFifteen = New System.Windows.Forms.RadioButton()
        Me.radTen = New System.Windows.Forms.RadioButton()
        Me.radFive = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Navy
        Me.btnExit.Location = New System.Drawing.Point(662, 622)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(176, 37)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Navy
        Me.btnClear.Location = New System.Drawing.Point(447, 622)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(176, 37)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.White
        Me.btnStats.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.Color.Navy
        Me.btnStats.Location = New System.Drawing.Point(232, 622)
        Me.btnStats.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(176, 37)
        Me.btnStats.TabIndex = 9
        Me.btnStats.Text = "Stats"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.White
        Me.btnCompute.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.Navy
        Me.btnCompute.Location = New System.Drawing.Point(18, 622)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(176, 37)
        Me.btnCompute.TabIndex = 8
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Lucida Sans", 9.0!)
        Me.txtOutput.Location = New System.Drawing.Point(39, 383)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(768, 201)
        Me.txtOutput.TabIndex = 25
        Me.txtOutput.TabStop = False
        '
        'txtInterest
        '
        Me.txtInterest.ForeColor = System.Drawing.Color.Navy
        Me.txtInterest.Location = New System.Drawing.Point(210, 315)
        Me.txtInterest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(332, 26)
        Me.txtInterest.TabIndex = 3
        '
        'txtPrincipal
        '
        Me.txtPrincipal.ForeColor = System.Drawing.Color.Navy
        Me.txtPrincipal.Location = New System.Drawing.Point(210, 242)
        Me.txtPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(332, 26)
        Me.txtPrincipal.TabIndex = 2
        '
        'txtLname
        '
        Me.txtLname.ForeColor = System.Drawing.Color.Navy
        Me.txtLname.Location = New System.Drawing.Point(210, 168)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(332, 26)
        Me.txtLname.TabIndex = 1
        '
        'txtFname
        '
        Me.txtFname.ForeColor = System.Drawing.Color.Navy
        Me.txtFname.Location = New System.Drawing.Point(210, 94)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(332, 26)
        Me.txtFname.TabIndex = 0
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Navy
        Me.label5.Location = New System.Drawing.Point(20, 322)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(172, 21)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Interest Rate (%):"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(74, 248)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(125, 21)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Principal ($):"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(82, 174)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(115, 21)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Last Name:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(81, 100)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(116, 21)
        Me.label2.TabIndex = 17
        Me.label2.Text = "First Name:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radTwenty)
        Me.groupBox1.Controls.Add(Me.radFifteen)
        Me.groupBox1.Controls.Add(Me.radTen)
        Me.groupBox1.Controls.Add(Me.radFive)
        Me.groupBox1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Navy
        Me.groupBox1.Location = New System.Drawing.Point(582, 83)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox1.Size = New System.Drawing.Size(226, 269)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Years"
        '
        'radTwenty
        '
        Me.radTwenty.AutoSize = True
        Me.radTwenty.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTwenty.Location = New System.Drawing.Point(34, 217)
        Me.radTwenty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radTwenty.Name = "radTwenty"
        Me.radTwenty.Size = New System.Drawing.Size(120, 27)
        Me.radTwenty.TabIndex = 7
        Me.radTwenty.TabStop = True
        Me.radTwenty.Text = "20 Years"
        Me.radTwenty.UseVisualStyleBackColor = True
        '
        'radFifteen
        '
        Me.radFifteen.AutoSize = True
        Me.radFifteen.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFifteen.Location = New System.Drawing.Point(34, 162)
        Me.radFifteen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radFifteen.Name = "radFifteen"
        Me.radFifteen.Size = New System.Drawing.Size(120, 27)
        Me.radFifteen.TabIndex = 6
        Me.radFifteen.TabStop = True
        Me.radFifteen.Text = "15 Years"
        Me.radFifteen.UseVisualStyleBackColor = True
        '
        'radTen
        '
        Me.radTen.AutoSize = True
        Me.radTen.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTen.Location = New System.Drawing.Point(34, 106)
        Me.radTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radTen.Name = "radTen"
        Me.radTen.Size = New System.Drawing.Size(120, 27)
        Me.radTen.TabIndex = 5
        Me.radTen.TabStop = True
        Me.radTen.Text = "10 Years"
        Me.radTen.UseVisualStyleBackColor = True
        '
        'radFive
        '
        Me.radFive.AutoSize = True
        Me.radFive.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFive.Location = New System.Drawing.Point(34, 51)
        Me.radFive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radFive.Name = "radFive"
        Me.radFive.Size = New System.Drawing.Size(107, 27)
        Me.radFive.TabIndex = 4
        Me.radFive.TabStop = True
        Me.radFive.Text = "5 Years"
        Me.radFive.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Lucida Sans", 17.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(178, 14)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(506, 39)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Savings Investment Balance"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(856, 682)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNIT175"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnExit As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnStats As Button
    Private WithEvents btnCompute As Button
    Private WithEvents txtOutput As TextBox
    Private WithEvents txtInterest As TextBox
    Private WithEvents txtPrincipal As TextBox
    Private WithEvents txtLname As TextBox
    Private WithEvents txtFname As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents radTwenty As RadioButton
    Private WithEvents radFifteen As RadioButton
    Private WithEvents radTen As RadioButton
    Private WithEvents radFive As RadioButton
    Private WithEvents label1 As Label
End Class
