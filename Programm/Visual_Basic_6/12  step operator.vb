Module Demo
	Sub Main()
	Console.WriteLine("Normal For Loop")
		For num1=1 To 20
		Console.WriteLine(num1)
		Next
		Console.WriteLine()
		Console.WriteLine("Step by 5")
		For num1=1 To 20 Step 5
		Console.WriteLine(num1)
		Next
		Console.WriteLine()
		Console.WriteLine("Step by -4")
		For num1=20 To 1 Step -4
		Console.WriteLine(num1)
		Console.ReadLine()
	End Sub
End Module