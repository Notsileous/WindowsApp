﻿#ExternalChecksum("C:\bens\vb Projects\Windows Phone Projects\ListonFinal\ListonFinal\MainPage.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","D2556D6E8B228948FD348D59B0A97F8B")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainPage
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents myAnimateOnLoad As System.Windows.Media.Animation.Storyboard
    
    Friend WithEvents myAnimateOnReload As System.Windows.Media.Animation.Storyboard
    
    Friend WithEvents TitlePanel As System.Windows.Controls.StackPanel
    
    Friend WithEvents PageTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents ContentCanvas As System.Windows.Controls.Canvas
    
    Friend WithEvents MyAnimatedCanvas As System.Windows.Media.TranslateTransform
    
    Friend WithEvents btn1 As System.Windows.Controls.Button
    
    Friend WithEvents btn2 As System.Windows.Controls.Button
    
    Friend WithEvents btn3 As System.Windows.Controls.Button
    
    Friend WithEvents btn4 As System.Windows.Controls.Button
    
    Friend WithEvents btn5 As System.Windows.Controls.Button
    
    Friend WithEvents btn6 As System.Windows.Controls.Button
    
    Friend WithEvents btn7 As System.Windows.Controls.Button
    
    Friend WithEvents btn8 As System.Windows.Controls.Button
    
    Friend WithEvents btn9 As System.Windows.Controls.Button
    
    Friend WithEvents btnNew As System.Windows.Controls.Button
    
    Friend WithEvents rdbX As System.Windows.Controls.RadioButton
    
    Friend WithEvents rdbO As System.Windows.Controls.RadioButton
    
    Friend WithEvents TextBlock1 As System.Windows.Controls.TextBlock
    
    Friend WithEvents txtGameWin As System.Windows.Controls.TextBlock
    
    Friend WithEvents HistoryMenuItem As Microsoft.Phone.Shell.ApplicationBarMenuItem
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/ListonFinal;component/MainPage.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.myAnimateOnLoad = CType(Me.FindName("myAnimateOnLoad"),System.Windows.Media.Animation.Storyboard)
        Me.myAnimateOnReload = CType(Me.FindName("myAnimateOnReload"),System.Windows.Media.Animation.Storyboard)
        Me.TitlePanel = CType(Me.FindName("TitlePanel"),System.Windows.Controls.StackPanel)
        Me.PageTitle = CType(Me.FindName("PageTitle"),System.Windows.Controls.TextBlock)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.ContentCanvas = CType(Me.FindName("ContentCanvas"),System.Windows.Controls.Canvas)
        Me.MyAnimatedCanvas = CType(Me.FindName("MyAnimatedCanvas"),System.Windows.Media.TranslateTransform)
        Me.btn1 = CType(Me.FindName("btn1"),System.Windows.Controls.Button)
        Me.btn2 = CType(Me.FindName("btn2"),System.Windows.Controls.Button)
        Me.btn3 = CType(Me.FindName("btn3"),System.Windows.Controls.Button)
        Me.btn4 = CType(Me.FindName("btn4"),System.Windows.Controls.Button)
        Me.btn5 = CType(Me.FindName("btn5"),System.Windows.Controls.Button)
        Me.btn6 = CType(Me.FindName("btn6"),System.Windows.Controls.Button)
        Me.btn7 = CType(Me.FindName("btn7"),System.Windows.Controls.Button)
        Me.btn8 = CType(Me.FindName("btn8"),System.Windows.Controls.Button)
        Me.btn9 = CType(Me.FindName("btn9"),System.Windows.Controls.Button)
        Me.btnNew = CType(Me.FindName("btnNew"),System.Windows.Controls.Button)
        Me.rdbX = CType(Me.FindName("rdbX"),System.Windows.Controls.RadioButton)
        Me.rdbO = CType(Me.FindName("rdbO"),System.Windows.Controls.RadioButton)
        Me.TextBlock1 = CType(Me.FindName("TextBlock1"),System.Windows.Controls.TextBlock)
        Me.txtGameWin = CType(Me.FindName("txtGameWin"),System.Windows.Controls.TextBlock)
        Me.HistoryMenuItem = CType(Me.FindName("HistoryMenuItem"),Microsoft.Phone.Shell.ApplicationBarMenuItem)
    End Sub
End Class

