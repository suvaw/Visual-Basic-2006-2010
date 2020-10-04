Module Demo
	Sub Main()
		Dim myString As String=Nothing
		Console.WriteLine("Please enter a string")
		myString=Console.ReadLine()
		Select Case myString.ToLower
			Case "hello"
			Console.WriteLine("Hi")
			Case "Goodbye"
			Console.WriteLine("ByBy")
			Case "Finish"
			Console.WriteLine("boat")
			Case Else
			Console.WriteLine("I dont know what you talking about")
		End Select
		Console.ReadLine()
	End Sub
End Module