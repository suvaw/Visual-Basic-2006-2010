VERSION 5.00
Begin VB.Form MessgeBox 
   Caption         =   "MessageBox"
   ClientHeight    =   2580
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4485
   LinkTopic       =   "Form1"
   ScaleHeight     =   2580
   ScaleWidth      =   4485
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   975
      Left            =   600
      TabIndex        =   0
      Top             =   720
      Width           =   3135
   End
End
Attribute VB_Name = "MessgeBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Dim msg As String
msg = MsgBox("Im vb6 message box", vbYesNoCancel + vbQuestion, "MessageBox")

If msg = vbYes Then
    MsgBox "You choose Yes Button"
End If
If msg = vbNo Then
    MsgBox "You choose no Button"
End If
If msg = vbCancel Then
    MsgBox "You choose Cancel button "
End If


End Sub
