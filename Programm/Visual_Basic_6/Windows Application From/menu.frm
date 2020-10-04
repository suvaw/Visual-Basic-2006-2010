VERSION 5.00
Begin VB.Form menu 
   Caption         =   "Main Menu"
   ClientHeight    =   3780
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form2"
   ScaleHeight     =   3780
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton exit 
      Caption         =   "Exit"
      Height          =   615
      Left            =   480
      TabIndex        =   3
      Top             =   2760
      Width           =   3615
   End
   Begin VB.CommandButton btnReg 
      Caption         =   "Registation From"
      Height          =   615
      Left            =   480
      TabIndex        =   2
      Top             =   1920
      Width           =   3615
   End
   Begin VB.CommandButton btnnotepad 
      Caption         =   "Notepad App"
      Height          =   615
      Left            =   480
      TabIndex        =   1
      Top             =   1080
      Width           =   3615
   End
   Begin VB.CommandButton btnlabel 
      Caption         =   "Message"
      Height          =   615
      Left            =   480
      TabIndex        =   0
      Top             =   240
      Width           =   3615
   End
End
Attribute VB_Name = "menu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btnlabel_Click()
From.Show
Me.Hide
End Sub

Private Sub btnnotepad_Click()
notepad.Show
Me.Hide
End Sub

Private Sub btnReg_Click()
StudentReg.Show
Me.Hide
End Sub

Private Sub exit_Click()
Unload Me
End Sub
