VERSION 5.00
Begin VB.Form datareadtextbox 
   Caption         =   "Text Box Data Read"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton button 
      Caption         =   "Show Message"
      Height          =   615
      Left            =   1253
      TabIndex        =   1
      Top             =   1560
      Width           =   2055
   End
   Begin VB.TextBox TextBox 
      Height          =   855
      Left            =   233
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Text            =   "datareadtextbox.frx":0000
      Top             =   360
      Width           =   4095
   End
End
Attribute VB_Name = "datareadtextbox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub button_Click()
MsgBox TextBox.Text
End Sub

