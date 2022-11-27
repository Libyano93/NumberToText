﻿Module MdlNoToArabic
    Function NoToTxt(ByVal TheNo As Double, ByVal MyCur As String, ByVal MySubCur As String) As String
        Dim MyArry1(0 To 9) As String
        Dim MyArry2(0 To 9) As String
        Dim MyArry3(0 To 9) As String
        Dim MyNo As String = ""
        Dim GetNo As String = ""
        Dim RdNo As String = ""
        Dim My100 As String = ""
        Dim My10 As String = ""
        Dim My1 As String = ""
        Dim My11 As String = ""
        Dim My12 As String = ""
        Dim GetTxt As String = ""
        Dim Mybillion As String = ""
        Dim MyMillion As String = ""
        Dim MyThou As String = ""
        Dim MyHun As String = ""
        Dim MyFraction As String = ""
        Dim MyAnd As String = ""
        Dim I As Integer
        Dim ReMark As String = ""


        If TheNo > 999999999999.99 Then
            Return 0
            Exit Function

        End If


        If TheNo < 0 Then
            TheNo = TheNo * -1
            ReMark = "يتبقى لكم "
        Else
            ReMark = "فقط لا غير "
        End If

        If TheNo = 0 Then
            NoToTxt = "صفر"
            Exit Function
        End If

        MyAnd = " و"
        MyArry1(0) = ""
        MyArry1(1) = "مائة"
        MyArry1(2) = "مائتان"
        MyArry1(3) = "ثلاثمائة"
        MyArry1(4) = "أربعمائة"
        MyArry1(5) = "خمسمائة"
        MyArry1(6) = "ستمائة"
        MyArry1(7) = "سبعمائة"
        MyArry1(8) = "ثمانمائة"
        MyArry1(9) = "تسعمائة"

        MyArry2(0) = ""
        MyArry2(1) = " عشر"
        MyArry2(2) = "عشرون"
        MyArry2(3) = "ثلاثون"
        MyArry2(4) = "أربعون"
        MyArry2(5) = "خمسون"
        MyArry2(6) = "ستون"
        MyArry2(7) = "سبعون"
        MyArry2(8) = "ثمانون"
        MyArry2(9) = "تسعون"

        MyArry3(0) = ""
        MyArry3(1) = "واحد"
        MyArry3(2) = "اثنان"
        MyArry3(3) = "ثلاثة"
        MyArry3(4) = "أربعة"
        MyArry3(5) = "خمسة"
        MyArry3(6) = "ستة"
        MyArry3(7) = "سبعة"
        MyArry3(8) = "ثمانية"
        MyArry3(9) = "تسعة"
        '======================

        GetNo = Format(TheNo, "000000000000.00")

        I = 0
        Do While I < 15

            If I < 12 Then
                MyNo = Mid$(GetNo, I + 1, 3)
            Else
                MyNo = "0" + Mid$(GetNo, I + 2, 2)
            End If

            If (Mid$(MyNo, 1, 3)) > 0 Then

                RdNo = Mid$(MyNo, 1, 1)
                My100 = MyArry1(RdNo)
                RdNo = Mid$(MyNo, 3, 1)
                My1 = MyArry3(RdNo)
                RdNo = Mid$(MyNo, 2, 1)
                My10 = MyArry2(RdNo)

                If Mid$(MyNo, 2, 2) = 11 Then My11 = "إحدى عشر"
                If Mid$(MyNo, 2, 2) = 12 Then My12 = "إثنى عشر"
                If Mid$(MyNo, 2, 2) = 10 Then My10 = "عشرة"

                If ((Mid$(MyNo, 1, 1)) > 0) And ((Mid$(MyNo, 2, 2)) > 0) Then My100 = My100 + MyAnd
                If ((Mid$(MyNo, 3, 1)) > 0) And ((Mid$(MyNo, 2, 1)) > 1) Then My1 = My1 + MyAnd

                GetTxt = My100 + My1 + My10

                If ((Mid$(MyNo, 3, 1)) = 1) And ((Mid$(MyNo, 2, 1)) = 1) Then
                    GetTxt = My100 + My11
                    If ((Mid$(MyNo, 1, 1)) = 0) Then GetTxt = My11
                End If

                If ((Mid$(MyNo, 3, 1)) = 2) And ((Mid$(MyNo, 2, 1)) = 1) Then
                    GetTxt = My100 + My12
                    If ((Mid$(MyNo, 1, 1)) = 0) Then GetTxt = My12
                End If

                If (I = 0) And (GetTxt <> "") Then
                    If ((Mid$(MyNo, 1, 3)) > 10) Then
                        Mybillion = GetTxt + " مليار"
                    Else
                        Mybillion = GetTxt + " مليارات"
                        If ((Mid$(MyNo, 1, 3)) = 2) Then Mybillion = " مليار"
                        If ((Mid$(MyNo, 1, 3)) = 2) Then Mybillion = " ملياران"
                    End If
                End If

                If (I = 3) And (GetTxt <> "") Then

                    If ((Mid$(MyNo, 1, 3)) > 10) Then
                        MyMillion = GetTxt + " مليون"
                    Else
                        MyMillion = GetTxt + " ملايين"
                        If ((Mid$(MyNo, 1, 3)) = 1) Then MyMillion = " مليون"
                        If ((Mid$(MyNo, 1, 3)) = 2) Then MyMillion = " مليونان"
                    End If
                End If

                If (I = 6) And (GetTxt <> "") Then
                    If ((Mid$(MyNo, 1, 3)) > 10) Then
                        MyThou = GetTxt + " ألف"
                    Else
                        MyThou = GetTxt + " آلاف"
                        If ((Mid$(MyNo, 3, 1)) = 1) Then MyThou = " ألف"
                        If ((Mid$(MyNo, 3, 1)) = 2) Then MyThou = " ألفان"
                    End If
                End If

                If (I = 9) And (GetTxt <> "") Then MyHun = GetTxt
                If (I = 12) And (GetTxt <> "") Then MyFraction = GetTxt
            End If

            I = I + 3
            '  'Application.DoEvents()
        Loop

        If (Mybillion <> "") Then
            If (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then Mybillion = Mybillion + MyAnd
        End If

        If (MyMillion <> "") Then
            If (MyThou <> "") Or (MyHun <> "") Then MyMillion = MyMillion + MyAnd
        End If

        If (MyThou <> "") Then
            If (MyHun <> "") Then MyThou = MyThou + MyAnd
        End If

        If MyFraction <> "" Then
            If (Mybillion <> "") Or (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then
                NoToTxt = Mybillion + MyMillion + MyThou + MyHun + " " + MyCur + MyAnd + MyFraction + " " + MySubCur + " " + ReMark
            Else
                NoToTxt = MyFraction + " " + MySubCur + " " + ReMark
            End If
        Else
            NoToTxt = Mybillion + MyMillion + MyThou + MyHun + " " + MyCur + " " + ReMark
        End If

    End Function

End Module
