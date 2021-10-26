<Serializable> Public Class Node3D
#Region "字段"
    Public Num As Long = 0
    Public X As Double = 0.0
    Public Y As Double = 0.0
    Public Z As Double = 0.0
#End Region

#Region "构造函数"
    Public Sub New(num As Long, x As Double, y As Double, z As Double)
        Me.Num = num
        Me.X = x
        Me.Y = y
        Me.Z = z
    End Sub
#End Region
End Class

<Serializable> Public Class Element
    Public Num As Long = 0
    Public NodeI As Long = 0
    Public NodeJ As Long = 0
    Public NodeIForce As Double = 0.0
    Public NodeJForce As Double = 0.0

    Public Sub New(num As Long, nodeI As Long, nodeJ As Long, nodeIForce As Double, nodeJForce As Double)
        Me.Num = num
        Me.NodeI = nodeI
        Me.NodeJ = nodeJ
        Me.NodeIForce = nodeIForce
        Me.NodeJForce = nodeJForce
    End Sub
End Class