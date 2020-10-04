VERSION 5.00
Begin VB.Form StudentReg 
   Caption         =   "Student Registation From"
   ClientHeight    =   3555
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4710
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3555
   ScaleWidth      =   4710
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton bclear 
      Caption         =   "Clear"
      Height          =   495
      Left            =   2640
      TabIndex        =   9
      Top             =   2880
      Width           =   1455
   End
   Begin VB.CommandButton bsave 
      Caption         =   "Save Record"
      Height          =   495
      Left            =   720
      TabIndex        =   8
      Top             =   2880
      Width           =   1455
   End
   Begin VB.TextBox tmobile 
      Height          =   375
      Left            =   1440
      TabIndex        =   7
      Top             =   1560
      Width           =   2895
   End
   Begin VB.TextBox taddress 
      Height          =   375
      Left            =   1440
      TabIndex        =   5
      Top             =   2160
      Width           =   2895
   End
   Begin VB.TextBox temail 
      Height          =   375
      Left            =   1440
      TabIndex        =   3
      Top             =   960
      Width           =   2895
   End
   Begin VB.TextBox tname 
      Height          =   375
      Left            =   1440
      TabIndex        =   1
      Top             =   360
      Width           =   2895
   End
   Begin VB.Label lmobile 
      Caption         =   "Mobile"
      Height          =   255
      Left            =   240
      TabIndex        =   6
      Top             =   1620
      Width           =   975
   End
   Begin VB.Label laddress 
      Caption         =   "Address"
      Height          =   255
      Left            =   240
      TabIndex        =   4
      Top             =   2220
      Width           =   975
   End
   Begin VB.Label lemail 
      Caption         =   "Email"
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   1020
      Width           =   975
   End
   Begin VB.Label lname 
      Caption         =   "Name"
      Height          =   255
      Left            =   240
      TabIndex        =   0
      Top             =   420
      Width           =   975
   End
End
Attribute VB_Name = "StudentReg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
