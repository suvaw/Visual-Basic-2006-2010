VERSION 5.00
Begin VB.Form notepad 
   Caption         =   "Notepad"
   ClientHeight    =   3615
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   5160
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3615
   ScaleWidth      =   5160
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton B_Clear 
      Caption         =   "Clear"
      Height          =   495
      Left            =   3360
      TabIndex        =   3
      Top             =   3000
      Width           =   1215
   End
   Begin VB.CommandButton B_Save 
      Caption         =   "Save"
      Height          =   495
      Left            =   480
      TabIndex        =   2
      Top             =   3000
      Width           =   1215
   End
   Begin VB.Frame Fnotepad 
      Caption         =   "Write"
      Height          =   2775
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   4935
      Begin VB.TextBox tbox 
         Height          =   2055
         Left            =   240
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   1
         Top             =   360
         Width           =   4455
      End
   End
End
Attribute VB_Name = "notepad"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
