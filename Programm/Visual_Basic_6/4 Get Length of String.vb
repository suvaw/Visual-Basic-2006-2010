Module Demo
	Sub Main()
	 Dim userName As String
	 Console.WriteLine("What is your username")
	 userName=Console.RealLine()
	 If userName.Length=10 Then
		Console.WriteLine("You have been granted access!")
	Else
		Console.WriteLineJ("your user name is not the right length")
	End If	
	Console.ReadLine()
	End Sub
End Module