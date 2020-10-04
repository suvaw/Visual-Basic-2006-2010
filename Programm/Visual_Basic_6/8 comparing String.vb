Module Demo
	Sub Main()
		Dim userString As String=Nothing
		Dim compString As String=suva
		Console.WriteLine("Please enter a String")
		userString=Console.ReadLine()
		Console.WriteLine(String.Compare(userString, compString))
		Console.WriteLine(String.Compare(userString, compString,True))
		Console.ReadLine()
	End Sub
End Module