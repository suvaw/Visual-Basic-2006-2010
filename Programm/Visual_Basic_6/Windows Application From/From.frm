VERSION 5.00
Begin VB.Form From 
   Caption         =   "Label change"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton btn 
      Caption         =   "Submitt"
      Height          =   615
      Left            =   840
      TabIndex        =   1
      Top             =   1440
      Width           =   2895
   End
   Begin VB.Label Label 
      Alignment       =   2  'Center
      Caption         =   "Wel Come VB6"
      BeginProperty Font 
         Name            =   "@Adobe Gothic Std B"
         Size            =   30
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4215
   End
End
Attribute VB_Name = "From"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btn_Click()
Label.Caption = "Hello World!"
End Sub
