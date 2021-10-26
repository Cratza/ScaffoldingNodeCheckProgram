<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NodeNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodeX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodeY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodeZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ElemNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodeI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodeJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodeIForce = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NodeJForce = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NodeNum, Me.NodeX, Me.NodeY, Me.NodeZ})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(295, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'NodeNum
        '
        Me.NodeNum.HeaderText = "NodeNum"
        Me.NodeNum.Name = "NodeNum"
        Me.NodeNum.Width = 72
        '
        'NodeX
        '
        Me.NodeX.HeaderText = "NodeX"
        Me.NodeX.Name = "NodeX"
        Me.NodeX.Width = 60
        '
        'NodeY
        '
        Me.NodeY.HeaderText = "NodeY"
        Me.NodeY.Name = "NodeY"
        Me.NodeY.Width = 60
        '
        'NodeZ
        '
        Me.NodeZ.HeaderText = "NodeZ"
        Me.NodeZ.Name = "NodeZ"
        Me.NodeZ.Width = 60
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ElemNum, Me.NodeI, Me.NodeJ, Me.NodeIForce, Me.NodeJForce})
        Me.DataGridView2.Location = New System.Drawing.Point(315, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.Size = New System.Drawing.Size(416, 426)
        Me.DataGridView2.TabIndex = 0
        '
        'ElemNum
        '
        Me.ElemNum.HeaderText = "ElemNum"
        Me.ElemNum.Name = "ElemNum"
        Me.ElemNum.Width = 72
        '
        'NodeI
        '
        Me.NodeI.HeaderText = "NodeI"
        Me.NodeI.Name = "NodeI"
        Me.NodeI.Width = 60
        '
        'NodeJ
        '
        Me.NodeJ.HeaderText = "NodeJ"
        Me.NodeJ.Name = "NodeJ"
        Me.NodeJ.Width = 60
        '
        'NodeIForce
        '
        Me.NodeIForce.HeaderText = "NodeIForce"
        Me.NodeIForce.Name = "NodeIForce"
        Me.NodeIForce.Width = 90
        '
        'NodeJForce
        '
        Me.NodeJForce.HeaderText = "NodeJForce"
        Me.NodeJForce.Name = "NodeJForce"
        Me.NodeJForce.Width = 90
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(738, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SaveFile"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(738, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "OpenFile"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NodeNum As DataGridViewTextBoxColumn
    Friend WithEvents NodeX As DataGridViewTextBoxColumn
    Friend WithEvents NodeY As DataGridViewTextBoxColumn
    Friend WithEvents NodeZ As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ElemNum As DataGridViewTextBoxColumn
    Friend WithEvents NodeI As DataGridViewTextBoxColumn
    Friend WithEvents NodeJ As DataGridViewTextBoxColumn
    Friend WithEvents NodeIForce As DataGridViewTextBoxColumn
    Friend WithEvents NodeJForce As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
