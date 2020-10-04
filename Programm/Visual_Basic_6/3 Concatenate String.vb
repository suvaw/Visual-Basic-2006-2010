Module Demo
	Sub Main()
	 Dim userString As String =Nothing
	 Dim programString As String="Catfish"
	 Console.WriteLine("Type anything you want")
	 userString = Console.ReadLine()
	 Console.WriteLine(userString)
	 userString=userString+programString+" fishing"
	 Console.WriteLine(userString & "hello")
	 Console.ReadLine()
	 
	End Sub
End Module