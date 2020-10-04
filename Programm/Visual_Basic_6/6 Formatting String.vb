Module Demo
	Sub Main()
		Dim myString As String=Nothing
		Console.WriteLine("Please enter a String")
		myString= 	Console.ReadLine()
		Console.WriteLine("Please enter a decimal value")
		Dim myDouble As Double= Console.ReadLine()
		Console.WriteLine()
		Console.WriteLine(String.Format("{0:n2},myDouble"))
		Console.WriteLine(myString.ToUpper())
		Console.WriteLine(myString.ToLower())
		Console.ReadLine()
	End Sub
End Module