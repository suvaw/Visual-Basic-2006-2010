Public Class Seat
    Dim a, b, seatdata, seatchecking, seatprice As String
    'Dim seatdata As String
    'Dim seatchecking As String
    Dim i As Integer = 5

    Private Sub Seat_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        add_ons.Close()
    End Sub

    Private Sub seatarrange(ByVal str1 As String, ByVal str2 As String)
        Dim data As String
        data = str2 + str1
        Label18.Text = data
        'starting
        If data = "02F" Or data = "03F" Or data = "04F" Or data = "04F" Or data = "05F" Or data = "07F" Or data _
            = "08F" Or data = "09F" Or data = "10F" Or data = "02E" Or data = "03E" Or data = "04E" Or data = "05E" Or data _
            = "06E" Or data = "07E" Or data = "08E" Or data = "10E" Or data = "02D" Or data = "03D" Or data = "04D" Or data _
            = "06D" Or data = "07D" Or data = "08D" Or data = "09D" Or data = "10D" Or data = "02C" Or data _
            = "03C" Or data = "04C" Or data = "05C" Or data = "06C" Or data = "07C" Or data = "08C" Or data = "09C" Or data _
            = "10C" Or data = "02B" Or data = "03B" Or data = "04B" Or data = "05B" Or data = "06B" Or data _
            = "07B" Or data = "08B" Or data = "09B" Or data = "10B" Or data = "02A" Or data = "03A" Or data _
            = "05A" Or data = "06A" Or data = "07A" Or data = "09A" Or data = "10A" Then
            seatprice = 300
        ElseIf data = "11F" Or data = "14F" Or data = "15F" Or data = "11E" Or data = "14E" Or data = "15E" Or data _
            = "11D" Or data = "11C" Or data = "11B" Or data = "14B" Or data = "15B" Or data = "11A" Or data = "14A" Or data = "15A" Then

            seatprice = "200"

        ElseIf data = "12F" Or data = "13F" Or data = "01E" Or data = "12E" Or data = "13E" Or data = "01D" Or data = "12D" Or data _
            = "13D" Or data = "01C" Or data = "12C" Or data = "13C" Or data = "01B" Or data = "12B" Or data = "13B" Or data = "12A" Or data = "13A" Then

            seatprice = "600"

        ElseIf data = "14D" Or data = "15D" Or data = "14C" Or data = "15C" Then

            seatprice = "Free"

        ElseIf data = "01F" Or data = "06F" Or data = "09E" Or data = "05D" Or data = "01A" Or data = "04A" Or data = "08A" Then

            seatprice = "Booked"
        End If
        'stopping
        seatdata = seatdata + vbNewLine + data + "        Rs." + seatprice
        If i = 0 Then
            MsgBox("Your choose Maximum Seat ")
        Else
            i = i - 1
            Label19.Text = i.ToString
            TextBox1.Text = seatdata
        End If

    End Sub

    'Click event create for Seat Arrange
    Private Sub p13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p85.Click, p79.Click, p73.Click, p67.Click, p61.Click, p55.Click, p49.Click, p43.Click, p37.Click, p31.Click, p25.Click, p19.Click, p13.Click, p07.Click, p01.Click
        a = "F"
        seatarrange(a, b)
        
    End Sub
    Private Sub p14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p86.Click, p80.Click, p74.Click, p68.Click, p62.Click, p56.Click, p50.Click, p44.Click, p38.Click, p32.Click, p26.Click, p20.Click, p14.Click, p08.Click, p02.Click
        a = "E"
        seatarrange(a, b)
    End Sub
    Private Sub p09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p87.Click, p81.Click, p75.Click, p69.Click, p63.Click, p57.Click, p51.Click, p45.Click, p39.Click, p33.Click, p27.Click, p21.Click, p15.Click, p09.Click, p03.Click
        a = "D"
        seatarrange(a, b)
    End Sub
    Private Sub p16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p88.Click, p82.Click, p76.Click, p70.Click, p64.Click, p58.Click, p52.Click, p46.Click, p40.Click, p34.Click, p28.Click, p22.Click, p16.Click, p10.Click, p04.Click
        a = "C"
        seatarrange(a, b)
    End Sub
    Private Sub p17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p89.Click, p83.Click, p77.Click, p71.Click, p65.Click, p59.Click, p53.Click, p47.Click, p41.Click, p35.Click, p29.Click, p23.Click, p17.Click, p11.Click, p05.Click
        a = "B"
        seatarrange(a, b)
    End Sub
    Private Sub p12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p90.Click, p84.Click, p78.Click, p72.Click, p66.Click, p60.Click, p54.Click, p48.Click, p42.Click, p36.Click, p30.Click, p24.Click, p18.Click, p12.Click, p06.Click
        a = "A"
        seatarrange(a, b)
    End Sub

    'Mouse Enter event create for seat Arrange
    Private Sub p05_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p06.MouseEnter, p05.MouseEnter, p04.MouseEnter, p03.MouseEnter, p02.MouseEnter, p01.MouseEnter
        b = "01"
    End Sub
    Private Sub p09_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p12.MouseEnter, p11.MouseEnter, p10.MouseEnter, p09.MouseEnter, p08.MouseEnter, p07.MouseEnter
        b = "02"
    End Sub
    Private Sub p13_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p18.MouseEnter, p17.MouseEnter, p16.MouseEnter, p15.MouseEnter, p14.MouseEnter, p13.MouseEnter
        b = "03"
    End Sub
    Private Sub p21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p24.MouseEnter, p23.MouseEnter, p22.MouseEnter, p21.MouseEnter, p20.MouseEnter, p19.MouseEnter
        b = "04"
    End Sub
    Private Sub p26_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p30.MouseEnter, p29.MouseEnter, p28.MouseEnter, p27.MouseEnter, p26.MouseEnter, p25.MouseEnter
        b = "05"
    End Sub
    Private Sub p33_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p36.MouseEnter, p35.MouseEnter, p34.MouseEnter, p33.MouseEnter, p32.MouseEnter, p31.MouseEnter
        b = "06"
    End Sub
    Private Sub p37_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p42.MouseEnter, p41.MouseEnter, p40.MouseEnter, p39.MouseEnter, p38.MouseEnter, p37.MouseEnter
        b = "07"
    End Sub
    Private Sub p45_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p48.MouseEnter, p47.MouseEnter, p46.MouseEnter, p45.MouseEnter, p44.MouseEnter, p43.MouseEnter
        b = "08"
    End Sub
    Private Sub p51_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p54.MouseEnter, p53.MouseEnter, p52.MouseEnter, p51.MouseEnter, p50.MouseEnter, p49.MouseEnter
        b = "09"
    End Sub
    Private Sub p57_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p60.MouseEnter, p59.MouseEnter, p58.MouseEnter, p57.MouseEnter, p56.MouseEnter, p55.MouseEnter
        b = "10"
    End Sub
    Private Sub p66_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p66.MouseEnter, p65.MouseEnter, p64.MouseEnter, p63.MouseEnter, p62.MouseEnter, p61.MouseEnter
        b = "11"
    End Sub
    Private Sub p71_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p72.MouseEnter, p71.MouseEnter, p70.MouseEnter, p69.MouseEnter, p68.MouseEnter, p67.MouseEnter
        b = "12"
    End Sub
    Private Sub p77_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p78.MouseEnter, p77.MouseEnter, p76.MouseEnter, p75.MouseEnter, p74.MouseEnter, p73.MouseEnter
        b = "13"
    End Sub
    Private Sub p80_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p84.MouseEnter, p83.MouseEnter, p82.MouseEnter, p81.MouseEnter, p80.MouseEnter, p79.MouseEnter
        b = "14"
    End Sub
    Private Sub p86_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p90.MouseEnter, p89.MouseEnter, p88.MouseEnter, p87.MouseEnter, p86.MouseEnter, p85.MouseEnter
        b = "15"
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        payment.Show()
        If payment.Visible Then
            Me.Close()
        End If
    End Sub
End Class
