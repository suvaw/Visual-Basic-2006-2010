Module Demo
	Sub Main()
		Console.WriteLine("Normal for loop")
		For num1 =1 To 15
			Console.WriteLine(num1)
		Next
		Console.WriteLine()
		Console.WriteLine("Continue Statement")
		For num1=1 To 15
		If num1=5 Or num1=9 Or num1=12 Then Continue For
		Console.WriteLine(num1)
		Next
		End If
		Console.ReadLine()
	End Sub
End Module