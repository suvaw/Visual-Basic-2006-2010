Module Demo
	Sub Main()
		Console.WriteLine("Normal for Loop")
		for num1=1 To 30
		Console.WriteLine(num1)
		Next
		Console.WriteLine()
		Console.WriteLine("For Loop that exits befre it's finish")
		For num1=1 To 30
		Console.WriteLine(num1)
			If num1=23 Then 
			Exit For
			End if
		Next
		Console.ReadLine()
	End Sub
End Module