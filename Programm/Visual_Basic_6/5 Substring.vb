Module Demo
	Sub Main()
		Dim userString As String=Nothing
		Console.WriteLine("Enter a String")
		userString=Console.ReadLine()
		Console.WriteLine()
		Console.WriteLine(userString.Length.ToString())
		Console.WriteLine(userString.Substring(0,3))
		Console.WriteLine(userString.Substring(3,3))
		Console.WriteLine(userString.Substring(6))
		Console.RealLine()
		End Sub
End Module