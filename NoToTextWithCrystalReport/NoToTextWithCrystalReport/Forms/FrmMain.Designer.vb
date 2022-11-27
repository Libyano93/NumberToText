<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtAmountByArabic = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.BtnPrintSelectedStudent = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnPrintSelectedStudent)
        Me.Panel1.Controls.Add(Me.TxtAmountByArabic)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtAmount)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 147)
        Me.Panel1.TabIndex = 0
        '
        'TxtAmountByArabic
        '
        Me.TxtAmountByArabic.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtAmountByArabic.Location = New System.Drawing.Point(12, 75)
        Me.TxtAmountByArabic.Name = "TxtAmountByArabic"
        Me.TxtAmountByArabic.ReadOnly = True
        Me.TxtAmountByArabic.Size = New System.Drawing.Size(636, 22)
        Me.TxtAmountByArabic.TabIndex = 15
        Me.TxtAmountByArabic.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "قيمة السند :-"
        '
        'TxtAmount
        '
        Me.TxtAmount.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtAmount.Location = New System.Drawing.Point(460, 44)
        Me.TxtAmount.MaxLength = 12
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(188, 22)
        Me.TxtAmount.TabIndex = 14
        Me.TxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPrintSelectedStudent
        '
        Me.BtnPrintSelectedStudent.BackColor = System.Drawing.Color.Cyan
        Me.BtnPrintSelectedStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintSelectedStudent.FlatAppearance.BorderSize = 0
        Me.BtnPrintSelectedStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintSelectedStudent.Font = New System.Drawing.Font("Arabic Typesetting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintSelectedStudent.ForeColor = System.Drawing.Color.Black
        Me.BtnPrintSelectedStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrintSelectedStudent.ImageIndex = 0
        Me.BtnPrintSelectedStudent.Location = New System.Drawing.Point(252, 103)
        Me.BtnPrintSelectedStudent.Name = "BtnPrintSelectedStudent"
        Me.BtnPrintSelectedStudent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPrintSelectedStudent.Size = New System.Drawing.Size(162, 32)
        Me.BtnPrintSelectedStudent.TabIndex = 29
        Me.BtnPrintSelectedStudent.Text = "طباعة"
        Me.BtnPrintSelectedStudent.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(660, 147)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "FrmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الشاشة الرئيسية"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtAmountByArabic As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents TxtAmount As TextBox
    Friend WithEvents BtnPrintSelectedStudent As Button
End Class
