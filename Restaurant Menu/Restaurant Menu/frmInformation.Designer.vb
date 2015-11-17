<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformation
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
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblNameLabel = New System.Windows.Forms.Label
        Me.btnBeginOrder = New System.Windows.Forms.Button
        Me.lblChooseTableNumber = New System.Windows.Forms.Label
        Me.numTable = New System.Windows.Forms.NumericUpDown
        Me.btnHelpInfo = New System.Windows.Forms.Button
        CType(Me.numTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(222, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(124, 30)
        Me.txtName.TabIndex = 1
        '
        'lblNameLabel
        '
        Me.lblNameLabel.AutoSize = True
        Me.lblNameLabel.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLabel.Location = New System.Drawing.Point(12, 15)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(170, 21)
        Me.lblNameLabel.TabIndex = 2
        Me.lblNameLabel.Text = "Enter Your Name"
        '
        'btnBeginOrder
        '
        Me.btnBeginOrder.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnBeginOrder.FlatAppearance.BorderSize = 3
        Me.btnBeginOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBeginOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnBeginOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeginOrder.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeginOrder.Location = New System.Drawing.Point(222, 92)
        Me.btnBeginOrder.Name = "btnBeginOrder"
        Me.btnBeginOrder.Size = New System.Drawing.Size(124, 38)
        Me.btnBeginOrder.TabIndex = 19
        Me.btnBeginOrder.Text = "Begin Order"
        Me.btnBeginOrder.UseVisualStyleBackColor = True
        '
        'lblChooseTableNumber
        '
        Me.lblChooseTableNumber.AutoSize = True
        Me.lblChooseTableNumber.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseTableNumber.Location = New System.Drawing.Point(12, 58)
        Me.lblChooseTableNumber.Name = "lblChooseTableNumber"
        Me.lblChooseTableNumber.Size = New System.Drawing.Size(267, 21)
        Me.lblChooseTableNumber.TabIndex = 20
        Me.lblChooseTableNumber.Text = "Choose Your Table Number"
        '
        'numTable
        '
        Me.numTable.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTable.Location = New System.Drawing.Point(285, 49)
        Me.numTable.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numTable.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTable.Name = "numTable"
        Me.numTable.Size = New System.Drawing.Size(61, 30)
        Me.numTable.TabIndex = 21
        Me.numTable.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnHelpInfo
        '
        Me.btnHelpInfo.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnHelpInfo.FlatAppearance.BorderSize = 3
        Me.btnHelpInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnHelpInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnHelpInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpInfo.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpInfo.Location = New System.Drawing.Point(12, 92)
        Me.btnHelpInfo.Name = "btnHelpInfo"
        Me.btnHelpInfo.Size = New System.Drawing.Size(124, 38)
        Me.btnHelpInfo.TabIndex = 22
        Me.btnHelpInfo.Text = "Help?"
        Me.btnHelpInfo.UseVisualStyleBackColor = True
        '
        'frmInformation
        '
        Me.AcceptButton = Me.btnBeginOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(358, 134)
        Me.Controls.Add(Me.btnHelpInfo)
        Me.Controls.Add(Me.numTable)
        Me.Controls.Add(Me.lblChooseTableNumber)
        Me.Controls.Add(Me.btnBeginOrder)
        Me.Controls.Add(Me.lblNameLabel)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information "
        CType(Me.numTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblNameLabel As System.Windows.Forms.Label
    Friend WithEvents btnBeginOrder As System.Windows.Forms.Button
    Friend WithEvents lblChooseTableNumber As System.Windows.Forms.Label
    Friend WithEvents numTable As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnHelpInfo As System.Windows.Forms.Button
End Class
