<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeasons
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtSeason = New System.Windows.Forms.TextBox()
        Me.cmdMS = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(12, 12)
        Me.txtMonth.MaxLength = 3
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(75, 20)
        Me.txtMonth.TabIndex = 0
        '
        'txtSeason
        '
        Me.txtSeason.Location = New System.Drawing.Point(315, 12)
        Me.txtSeason.Name = "txtSeason"
        Me.txtSeason.ReadOnly = True
        Me.txtSeason.Size = New System.Drawing.Size(100, 20)
        Me.txtSeason.TabIndex = 3
        Me.txtSeason.TabStop = False
        '
        'cmdMS
        '
        Me.cmdMS.Location = New System.Drawing.Point(93, 10)
        Me.cmdMS.Name = "cmdMS"
        Me.cmdMS.Size = New System.Drawing.Size(135, 23)
        Me.cmdMS.TabIndex = 1
        Me.cmdMS.Text = "Month → Season"
        Me.cmdMS.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClear.Location = New System.Drawing.Point(234, 10)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 2
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'frmSeasons
        '
        Me.AcceptButton = Me.cmdMS
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClear
        Me.ClientSize = New System.Drawing.Size(427, 41)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdMS)
        Me.Controls.Add(Me.txtSeason)
        Me.Controls.Add(Me.txtMonth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSeasons"
        Me.Text = "Seasons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtSeason As TextBox
    Friend WithEvents cmdMS As Button
    Friend WithEvents cmdClear As Button
End Class
