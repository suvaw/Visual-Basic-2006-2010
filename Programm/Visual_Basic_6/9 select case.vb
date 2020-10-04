Module Demo
	Sub Main()
		Dim myInt As Integer=Nothing
		Console.WriteLine("Plese enter an integer")
		myInt=Console.ReadLine()
		Select Case myInt
			Case 0
			Console.WriteLine("Hi")
			Case 1
			Console.WriteLine("Hellow")
			Case 2
			Console.WriteLine("By")
		End Select
		Console.ReadLine()
	End Sub
End Module