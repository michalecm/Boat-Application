Option Strict On

Public Class SailBoat
    Inherits Boat
    Private mintNumberSails As Integer
    Private mstrMotorType As String
    Public Sub New(ByVal bvstrMake As String, ByVal bvintModel As Integer,
                   ByVal bvintNumberSails As Integer, ByVal bvstrMotorType As String)
        MyBase.New(bvstrMake, bvintModel)
        subSetMotorType(bvstrMotorType)
        Me.prpNumberSails = bvintNumberSails
    End Sub
    Public Function funGetMotorType() As String
        Return mstrMotorType
    End Function
    Public Sub subSetMotorType(ByVal bvstrMotorType As String)
        mstrMotorType = bvstrMotorType
    End Sub
    Public Property prpNumberSails() As Integer
        Get
            Return mintNumberSails
        End Get
        Set(ByVal bvintNumberSails As Integer)
            mintNumberSails = bvintNumberSails
        End Set
    End Property
    Public Overrides Function funReturnClassAttributes() As String
        Return MyBase.funReturnClassAttributes() & ", " & funGetMotorType() & ", " & Me.prpNumberSails
    End Function
End Class

