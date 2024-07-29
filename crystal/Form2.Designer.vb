<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.searchtext = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.codingbtn = New System.Windows.Forms.Button()
        Me.noncodingbtn = New System.Windows.Forms.Button()
        Me.nametxet = New System.Windows.Forms.Label()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'searchtext
        '
        Me.searchtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtext.Location = New System.Drawing.Point(658, 188)
        Me.searchtext.Name = "searchtext"
        Me.searchtext.Size = New System.Drawing.Size(252, 38)
        Me.searchtext.TabIndex = 49
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.Transparent
        Me.label1.Location = New System.Drawing.Point(661, 99)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(241, 45)
        Me.label1.TabIndex = 42
        Me.label1.Text = "Search By City"
        '
        'codingbtn
        '
        Me.codingbtn.BackColor = System.Drawing.Color.PaleGreen
        Me.codingbtn.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Bold)
        Me.codingbtn.ForeColor = System.Drawing.Color.White
        Me.codingbtn.Location = New System.Drawing.Point(86, 455)
        Me.codingbtn.Name = "codingbtn"
        Me.codingbtn.Size = New System.Drawing.Size(492, 103)
        Me.codingbtn.TabIndex = 50
        Me.codingbtn.Text = "Show Search In Crystal Report In Coding"
        Me.codingbtn.UseVisualStyleBackColor = False
        '
        'noncodingbtn
        '
        Me.noncodingbtn.BackColor = System.Drawing.Color.PaleGreen
        Me.noncodingbtn.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Bold)
        Me.noncodingbtn.ForeColor = System.Drawing.Color.White
        Me.noncodingbtn.Location = New System.Drawing.Point(606, 455)
        Me.noncodingbtn.Name = "noncodingbtn"
        Me.noncodingbtn.Size = New System.Drawing.Size(492, 103)
        Me.noncodingbtn.TabIndex = 51
        Me.noncodingbtn.Text = "Show Search In Crystal Report Without Coding"
        Me.noncodingbtn.UseVisualStyleBackColor = False
        '
        'nametxet
        '
        Me.nametxet.AutoSize = True
        Me.nametxet.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxet.ForeColor = System.Drawing.Color.White
        Me.nametxet.Location = New System.Drawing.Point(269, 99)
        Me.nametxet.Name = "nametxet"
        Me.nametxet.Size = New System.Drawing.Size(83, 45)
        Me.nametxet.TabIndex = 52
        Me.nametxet.Text = "City"
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.PaleGreen
        Me.addbtn.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Bold)
        Me.addbtn.ForeColor = System.Drawing.Color.White
        Me.addbtn.Location = New System.Drawing.Point(177, 170)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(275, 69)
        Me.addbtn.TabIndex = 35
        Me.addbtn.Text = "Show The City"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1343, 608)
        Me.Controls.Add(Me.nametxet)
        Me.Controls.Add(Me.noncodingbtn)
        Me.Controls.Add(Me.codingbtn)
        Me.Controls.Add(Me.searchtext)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.addbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchtext As Windows.Forms.TextBox
    Private WithEvents label1 As Windows.Forms.Label
    Friend WithEvents codingbtn As Windows.Forms.Button
    Friend WithEvents noncodingbtn As Windows.Forms.Button
    Friend WithEvents nametxet As Windows.Forms.Label
    Private WithEvents addbtn As Windows.Forms.Button
End Class
