<Serializable> Public Class clsScaffoldingNodeCheck
#Region "全局变量(字段)"
    Public Node3ds As New List(Of Node3D)       '节点的信息数组，包含所有节点的名称、xyz坐标值（单位：m）
    Public ElementInfos As New List(Of Element) '单元的信息数组，包含所有单元的名称、i、j节点名称以及i、j节点力（单位：kN）
    Public ResNodeShear() As Double             '节点的Z向合力，单位：kN，向上为正、向下为负
    Public ResNodeLaYa() As Double              '节点的水平力合力，单位：kN
    Public ResNodeLaYaX() As Double             '节点的X向合力，单位：kN
    Public ResNodeLaYaY() As Double             '节点的Y向合力，单位：kN
#End Region

#Region "构造器"
    'New()函数为当前类（clsScaffoldingNodeCheck）的构造函数
    '当类被初始化时，必须调用此函数，使用外部传入的参数为类中变量（也叫字段）赋值
    Public Sub New(curNode3ds As List(Of Node3D), curElementInfos As List(Of Element))
        Node3ds = curNode3ds
        ElementInfos = curElementInfos
        '使用关键字ReDim可以重新定义变量的类型，修改数组的长度
        ReDim ResNodeShear(Node3ds.Count)
        ReDim ResNodeLaYa(Node3ds.Count)
        ReDim ResNodeLaYaX(Node3ds.Count)
        ReDim ResNodeLaYaY(Node3ds.Count)
    End Sub
#End Region

#Region "方法"
    Public Sub Calulate()
        '依次遍历单元数组，更新节点力的结果数组
        For i = 0 To ElementInfos.Count - 1
            Call Update_NodeShear(i)
        Next
        'Dim a = ResNodeLaYaX.Max
        'Dim b = ResNodeLaYaY.Max
        'Dim c = ResNodeShear.Max
    End Sub

    '对指定单元内力进行处理，更新数组 ResNodeShear、ResNodeLaYaX、ResNodeLaYaY和ResNodeLaYa
    Public Sub Update_NodeShear(CurElemIndex As Long)
        '当前单元的i、j节点轴向力，单位：kN
        Dim Fi As Double = ElementInfos(CurElemIndex).NodeIForce
        Dim Fj As Double = ElementInfos(CurElemIndex).NodeJForce

        '临时保存轴力分解到三个坐标轴的力，单位：kN
        Dim LaYaIX, LaYaJX As Double
        Dim LaYaIY, LaYaJY As Double
        Dim ShearI, ShearJ As Double

        '空间杆件与三坐标轴的余弦值
        Dim length, dx, dy, dz As Double
        Dim cosa, cosb, cosr As Double

        '当前单元的i、j节点的节点名称（而非索引值）
        '注意：若将变量的声明(Dim XXvariable as XXType)和赋值(XXvariable = XXX)写为一行(Dim XXvariable as XXType = XXX)时
        '编译器可以自动推断变量类型，故变量的类型不必被显式指定，As Long可以被省略
        Dim nameNodeI = ElementInfos.ElementAt(CurElemIndex).NodeI
        Dim nameNodeJ = ElementInfos.ElementAt(CurElemIndex).NodeJ

        '当前单元的i、j节点索引值
        '（索引值表示 元素位于列表从0开始数的第x个位置。注意Index与Num的区别？）
        '使用Linq语法查找Node3ds中的元素的索引值，查找条件：
        Dim indexNodeI = Node3ds.FindIndex(Function(n) n.Num = nameNodeI)
        Dim indexNodeJ = Node3ds.FindIndex(Function(n) n.Num = nameNodeJ)

        '求解当前单元轴力沿三个坐标轴的分量：分别为LaYaIX、LaYaIY和ShearI，单位：kN
        dx = Node3ds(indexNodeJ).X - Node3ds(indexNodeI).X
        dy = Node3ds(indexNodeJ).Y - Node3ds(indexNodeI).Y
        dz = Node3ds(indexNodeJ).Z - Node3ds(indexNodeI).Z

        '求解当前单元的长度，单位：m
        'VB.NET支持幂运算操作符“ ^ ”
        length = (dx ^ 2 + dy ^ 2 + dz ^ 2) ^ 0.5
        '使用“ : ”可以分隔不同语句
        cosa = dx / length : cosb = dy / length : cosr = dz / length

        '此处符号判定默认i节点位于小坐标向，默认j节点位于大坐标向，单元受拉为正
        '节点各分力默认以坐标轴正向为正
        LaYaIX = Fi * cosa : LaYaJX = -Fj * cosa
        LaYaIY = Fi * cosb : LaYaJY = -Fj * cosb
        ShearI = Fi * cosr : ShearJ = -Fj * cosr

        '更新节点力表格。
        '注意：每次更新节点力数组时，应当累加之前的数值。故此处使用自增运算符“ += ”而非赋值运算符“ = ”
        ResNodeShear(indexNodeI) += ShearI
        ResNodeLaYaX(indexNodeI) += LaYaIX
        ResNodeLaYaY(indexNodeI) += LaYaIY
        ResNodeLaYa(indexNodeI) += (LaYaIX ^ 2 + LaYaIY ^ 2) ^ 0.5      '将水平力合成，计算LaYa力

        ResNodeShear(indexNodeJ) += ShearJ
        ResNodeLaYaX(indexNodeJ) += LaYaJX
        ResNodeLaYaY(indexNodeJ) += LaYaJY
        ResNodeLaYa(indexNodeJ) += (LaYaJX ^ 2 + LaYaJY ^ 2) ^ 0.5      '将水平力合成，计算LaYa力
    End Sub
#End Region

End Class