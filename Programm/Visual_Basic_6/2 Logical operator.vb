Module Demo
	Sub Main()
	 Dim userName As String=Nothing
	 Dim password As String=Nothing
	 Console.WriteLine("What is your name?")
	 userName=Console.ReadLine()
	 Console.WriteLine("What is your password?")
	 password=Console.ReadLine()
	 If (userName="San" Or userName="Tim") And password="new" Then
		Console.WriteLine("hello" & userName)
	Else
		Console.WriteLine("Access not Granted")
	End If
		Console.ReadLine()
	End Sub
End Module