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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbokode = New System.Windows.Forms.ComboBox()
        Me.Txtnamabarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtharga = New System.Windows.Forms.TextBox()
        Me.Txtjumlah = New System.Windows.Forms.TextBox()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.btnkosongkan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'cbokode
        '
        Me.cbokode.FormattingEnabled = True
        Me.cbokode.Location = New System.Drawing.Point(127, 23)
        Me.cbokode.Name = "cbokode"
        Me.cbokode.Size = New System.Drawing.Size(324, 28)
        Me.cbokode.TabIndex = 1
        '
        'Txtnamabarang
        '
        Me.Txtnamabarang.Location = New System.Drawing.Point(127, 66)
        Me.Txtnamabarang.Name = "Txtnamabarang"
        Me.Txtnamabarang.Size = New System.Drawing.Size(324, 26)
        Me.Txtnamabarang.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total Harga"
        '
        'Txtharga
        '
        Me.Txtharga.Location = New System.Drawing.Point(127, 109)
        Me.Txtharga.Name = "Txtharga"
        Me.Txtharga.Size = New System.Drawing.Size(324, 26)
        Me.Txtharga.TabIndex = 7
        '
        'Txtjumlah
        '
        Me.Txtjumlah.Location = New System.Drawing.Point(127, 148)
        Me.Txtjumlah.Name = "Txtjumlah"
        Me.Txtjumlah.Size = New System.Drawing.Size(324, 26)
        Me.Txtjumlah.TabIndex = 8
        '
        'Txttotal
        '
        Me.Txttotal.Location = New System.Drawing.Point(127, 183)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(324, 26)
        Me.Txttotal.TabIndex = 9
        '
        'btnkosongkan
        '
        Me.btnkosongkan.Location = New System.Drawing.Point(12, 215)
        Me.btnkosongkan.Name = "btnkosongkan"
        Me.btnkosongkan.Size = New System.Drawing.Size(439, 33)
        Me.btnkosongkan.TabIndex = 10
        Me.btnkosongkan.Text = "Kosongkan"
        Me.btnkosongkan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 256)
        Me.Controls.Add(Me.btnkosongkan)
        Me.Controls.Add(Me.Txttotal)
        Me.Controls.Add(Me.Txtjumlah)
        Me.Controls.Add(Me.Txtharga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtnamabarang)
        Me.Controls.Add(Me.cbokode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Penjualaan Sederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbokode As System.Windows.Forms.ComboBox
    Friend WithEvents Txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtharga As System.Windows.Forms.TextBox
    Friend WithEvents Txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btnkosongkan As System.Windows.Forms.Button

End Class
