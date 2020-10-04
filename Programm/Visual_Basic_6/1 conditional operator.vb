Module Demo
	Sub Main()
	  Dim isInKindergarden As Boolean= Nothing
	  Dim canDrink As Boolean=Nothing 
	  Dim isSeniorCitizen As Boolean=Nothing
	  Console.WriteLine("What is your age?")
	  Dim age As Integer=Console.ReadLine()
	  Dim outComeKindergarten As String=Nothing
	  Dim outComeSenior As String=Nothing
	  Dim outComeDrink As String=Nothing
	  If age <> 5 Then
		isInKindergerten=False
		outComeKindergarten="You are't in Kindergarten"
	  Else
	  isInKindergarten=True
	  outComeKindergarten="You are in Kindergarten"
	  End If
	  If age >=65 Then
	  idSeniorCitizen=True
	  outComeSenear="You are a senior citizen"
	  
	  Else
	  isSenearCitizen=False
	  outComeSenear="You are't a senior citizen"
	  End If
	  If age >=21 Then 
	  canDrink=True
	  outComeDrink="You can Drink"
	  Else
	  canDrink=False
	  outComeDrink="you can't drink"
	  End If
	  Console.WriteLine(&outComeDrink & outComeKindergarten & outComeSenior)
	End Sub
End Module