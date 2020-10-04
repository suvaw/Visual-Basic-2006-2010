Module Demo
	Sub Main()
		Dim myString As String=Nothing
		Dim finalString As String=Nothing
		Console.WriteLine("Please enter a string")
		myString=Console.ReadLine()
		finalString=myString.Replace("a","n")
		Console.WriteLine(finalString)
		Console.ReadLine()
	End Sub
End Module