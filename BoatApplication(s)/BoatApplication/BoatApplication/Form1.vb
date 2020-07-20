Option Strict On
Imports BoatClasses
Imports System.IO
Public Class frmBoatApplication
    ' Start VB
    ' File, New Project, Windows Forms Application, OK
    ' Solution Explorer, right-click "WindowsApplication1", Add Reference
    ' Browse tab, [class project folder]\bin\Release\*.dll
    Dim gobjBoat(10) As Boat
    Dim gobjPowerBoat(10) As PowerBoat
    Dim gobjSailBoat(10) As SailBoat
    Dim gintBoat As Integer = -1
    Dim gintPowerBoat As Integer = -1
    Dim gintSailBoat As Integer = -1
    Private Sub subReadFileAndLoadArray()
        Dim fsrBoats = New StreamReader("Boats.csv")
        Dim strRec() As String
        Do Until fsrBoats.EndOfStream
            strRec = Split(fsrBoats.ReadLine, ",")
            Select Case strRec(0)
                Case "b"
                    gintBoat += 1
                    gobjBoat(gintBoat) = New Boat(strRec(1), CInt(strRec(2)))
                Case "p"
                    gintPowerBoat += 1
                    gobjPowerBoat(gintPowerBoat) =
                    New PowerBoat(strRec(1), CInt(strRec(2)), CInt(strRec(3)), strRec(4))
                Case "s"
                    gintSailBoat += 1
                    gobjSailBoat(gintSailBoat) =
                        New SailBoat(strRec(1), CInt(strRec(2)), CInt(strRec(3)), strRec(4))
            End Select
        Loop
    End Sub
    Private Sub subPrintArray()
        Dim intRow As Integer
        Console.WriteLine()
        Console.WriteLine("Boat")
        Console.WriteLine(StrDup(Len("Boat"), "-"))
        For intRow = 0 To gintBoat
            Console.WriteLine(gobjBoat(intRow).funReturnClassAttributes)
        Next intRow
        Console.WriteLine()
        Console.WriteLine("PowerBoat")
        Console.WriteLine(StrDup(Len("PowerBoat"), "-"))
        For intRow = 0 To gintPowerBoat
            Console.WriteLine(gobjPowerBoat(intRow).funReturnClassAttributes)
            'Console.WriteLine(gobjPowerBoat(intRow).funGetMake & ", " & gobjPowerBoat(intRow).prpModel)
            '& ", " & gobjPowerBoat(intRow).funGetNumberEngines & ", " & gobjPowerBoat(intRow).prpFuelType)
        Next intRow
        Console.WriteLine()
        Console.WriteLine("SailBoat")
        Console.WriteLine(StrDup(Len("SailBoat"), "-"))
        For intRow = 0 To gintSailBoat
            Console.WriteLine(gobjSailBoat(intRow).funReturnClassAttributes())
            'Console.WriteLine(gobjPowerBoat(intRow).funGetMake & ", " & gobjPowerBoat(intRow).prpModel)
            '& ", " & gobjPowerBoat(intRow).funGetNumberEngines & ", " & gobjPowerBoat(intRow).prpFuelType)
        Next intRow
    End Sub
    Private Sub frmBoatApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReadFileAndLoadArray()
    End Sub
    Private Sub btnPrintBoats_Click(sender As Object, e As EventArgs) Handles btnPrintBoats.Click
        subPrintArray()
    End Sub
End Class