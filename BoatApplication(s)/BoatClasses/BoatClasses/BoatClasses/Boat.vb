Option Strict On

Public Class Boat
    Private mstrMake As String
    Private mintModel As Integer

    Public Sub New(ByVal bvstrMake As String, ByVal bvintModel As Integer)
        subSetMake(bvstrMake)
        Me.prpModel = bvintModel
    End Sub

    Public Function funGetMake() As String
        Return mstrMake
    End Function

    Public Sub subSetMake(ByVal bvstrMake As String)
        mstrMake = bvstrMake
    End Sub

    Public Property prpModel As Integer
        Get
            Return mintModel
        End Get
        Set(bvintModel As Integer)
            mintModel = bvintModel
        End Set
    End Property

    Public Property prpMake As String
        Get
            Return mstrMake
        End Get
        Set(bvstrMake As String)
            mstrMake = bvstrMake
        End Set
    End Property

    Public Overridable Function funReturnClassAttributes() As String
        Return (funGetMake() & ", " & Me.prpModel)
    End Function

End Class
