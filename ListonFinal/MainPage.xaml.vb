'Program Name: Tic-Tac-Toe
'Purpose: play a simple tic-tac-toe game against the computer
'programmed By: Benjamin Liston on 6/1/2016
'---------------------------------
'Updated on: 6/24/2016
'Added more advance AI that trys to block Player 1 from winning

Partial Public Class MainPage
    Inherits PhoneApplicationPage
    'variables to hold the "X" or "O" for each player
    Private strP1Choice As String
    Private strP2Choice As String
    'variable to keep track of game ending condition
    Private blnGameOver As Boolean = False
    Private strButton As String
    ' Constructor
    Public Sub New()
        InitializeComponent()
        myAnimateOnLoad.Begin()
        'check which player is player 1 (X) and start game accordingly
        WhichPlayer()
    End Sub

    'this sub sets the content of the button to X or O when pressed by player 1
    Private Sub SetXO(Click_Button)
        'receive whichever button was pressed
        Dim button As Button = Click_Button
        'if the button has no content yet
        If button.Content.ToString = "" Then
            'set the content to the value
            strButton = button.Name.ToString
            button.Content = strP1Choice
            'disable the button
            button.IsEnabled = False
        End If
        'check to see if player 1 won
        CheckForWinnerP1()
        'if game did not end
        If blnGameOver <> True Then
            'check to see if it ends in a draw
            CheckForDraw()
            'if no draw it is player 2 turn
            If blnGameOver <> True Then
                TryToBlock()
                'check if player 2 wins
                CheckForWinnerP2()
                'if not check for draw
                If blnGameOver <> True Then
                    CheckForDraw()
                Else
                    GameOver()
                End If
            Else
                GameOver()
            End If
        Else
            GameOver()
        End If

    End Sub
    'sub for player2 (computer) turn - called when there is no moves to block
    Private Sub Player2AnySpot()
        ' variable to hold a list count
        Dim intListCount As Integer
        'new random object
        Dim RandNum As New Random
        'variable to hold random result
        Dim intRan As Integer
        'variable to hold string from list
        Dim strContent As String
        'create new list of strings object
        Dim lstSpots As New List(Of String) From {}
        'check to see if each button has been claimed by a player yet
        'if it has not, add the name of the button to the list
        If btn1.Content.ToString = "" Then
            lstSpots.Add("btn1")
        End If
        If btn2.Content.ToString = "" Then
            lstSpots.Add("btn2")
        End If
        If btn3.Content.ToString = "" Then
            lstSpots.Add("btn3")
        End If
        If btn4.Content.ToString = "" Then
            lstSpots.Add("btn4")
        End If
        If btn5.Content.ToString = "" Then
            lstSpots.Add("btn5")
        End If
        If btn6.Content.ToString = "" Then
            lstSpots.Add("btn6")
        End If
        If btn7.Content.ToString = "" Then
            lstSpots.Add("btn7")
        End If
        If btn8.Content.ToString = "" Then
            lstSpots.Add("btn8")
        End If
        If btn9.Content.ToString = "" Then
            lstSpots.Add("btn9")
        End If
        'get the size of the list
        intListCount = lstSpots.Count
        'if the list is greater than 0
        If intListCount > 0 Then
            'generate a random number between 1 and the size of the list
            intRan = RandNum.Next(1, intListCount)
            'pull the button name from the index that matched the random number
            strContent = lstSpots.Item(intRan)
            'check the value against the following conditions
            'if match set the button content to player2 variable and disable button
            Select Case strContent
                Case "btn1"
                    btn1.Content = strP2Choice
                    btn1.IsEnabled = False
                Case "btn2"
                    btn2.Content = strP2Choice
                    btn2.IsEnabled = False
                Case "btn3"
                    btn3.Content = strP2Choice
                    btn3.IsEnabled = False
                Case "btn4"
                    btn4.Content = strP2Choice
                    btn4.IsEnabled = False
                Case "btn5"
                    btn5.Content = strP2Choice
                    btn5.IsEnabled = False
                Case "btn6"
                    btn6.Content = strP2Choice
                    btn6.IsEnabled = False
                Case "btn7"
                    btn7.Content = strP2Choice
                    btn7.IsEnabled = False
                Case "btn8"
                    btn8.Content = strP2Choice
                    btn8.IsEnabled = False
                Case "btn9"
                    btn9.Content = strP2Choice
                    btn9.IsEnabled = False
            End Select

        End If
    End Sub

    'first sub called for player 2 turn- checks each row and blocks p1 from winning when possible
    Private Sub TryToBlock()
        'row 1
        If btn1.Content.ToString = strP1Choice And btn2.Content.ToString = strP1Choice And btn3.Content.ToString <> strP1Choice And btn3.Content.ToString <> strP2Choice Then
            btn3.Content = strP2Choice
            btn3.IsEnabled = False

        ElseIf btn1.Content.ToString = strP1Choice And btn3.Content.ToString = strP1Choice And btn2.Content.ToString <> strP1Choice And btn2.Content.ToString <> strP2Choice Then
            btn2.Content = strP2Choice
            btn2.IsEnabled = False

        ElseIf btn2.Content.ToString = strP1Choice And btn3.Content.ToString = strP1Choice And btn1.Content.ToString <> strP1Choice And btn1.Content.ToString <> strP2Choice Then
            btn1.Content = strP2Choice
            btn1.IsEnabled = False

            'row2
        ElseIf btn4.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn6.Content.ToString <> strP1Choice And btn6.Content.ToString <> strP2Choice Then
            btn6.Content = strP2Choice
            btn6.IsEnabled = False

        ElseIf btn4.Content.ToString = strP1Choice And btn6.Content.ToString = strP1Choice And btn5.Content.ToString <> strP1Choice And btn5.Content.ToString <> strP2Choice Then
            btn5.Content = strP2Choice
            btn5.IsEnabled = False

        ElseIf btn5.Content.ToString = strP1Choice And btn6.Content.ToString = strP1Choice And btn4.Content.ToString <> strP1Choice And btn4.Content.ToString <> strP2Choice Then
            btn4.Content = strP2Choice
            btn4.IsEnabled = False

            'row 3
        ElseIf btn7.Content.ToString = strP1Choice And btn8.Content.ToString = strP1Choice And btn9.Content.ToString <> strP1Choice And btn9.Content.ToString <> strP2Choice Then
            btn9.Content = strP2Choice
            btn9.IsEnabled = False

        ElseIf btn7.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice And btn8.Content.ToString <> strP1Choice And btn8.Content.ToString <> strP2Choice Then
            btn8.Content = strP2Choice
            btn8.IsEnabled = False

        ElseIf btn8.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice And btn7.Content.ToString <> strP1Choice And btn7.Content.ToString <> strP2Choice Then
            btn7.Content = strP2Choice
            btn7.IsEnabled = False

            'column 1
        ElseIf btn1.Content.ToString = strP1Choice And btn4.Content.ToString = strP1Choice And btn7.Content.ToString <> strP1Choice And btn7.Content.ToString <> strP2Choice Then
            btn7.Content = strP2Choice
            btn7.IsEnabled = False

        ElseIf btn1.Content.ToString = strP1Choice And btn7.Content.ToString = strP1Choice And btn4.Content.ToString <> strP1Choice And btn4.Content.ToString <> strP2Choice Then
            btn4.Content = strP2Choice
            btn4.IsEnabled = False

        ElseIf btn4.Content.ToString = strP1Choice And btn7.Content.ToString = strP1Choice And btn1.Content.ToString <> strP1Choice And btn1.Content.ToString <> strP2Choice Then
            btn1.Content = strP2Choice
            btn1.IsEnabled = False

            'column 2
        ElseIf btn2.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn8.Content.ToString <> strP1Choice And btn8.Content.ToString <> strP2Choice Then
            btn8.Content = strP2Choice
            btn8.IsEnabled = False

        ElseIf btn2.Content.ToString = strP1Choice And btn8.Content.ToString = strP1Choice And btn5.Content.ToString <> strP1Choice And btn5.Content.ToString <> strP2Choice Then
            btn5.Content = strP2Choice
            btn5.IsEnabled = False

        ElseIf btn5.Content.ToString = strP1Choice And btn8.Content.ToString = strP1Choice And btn2.Content.ToString <> strP1Choice And btn2.Content.ToString <> strP2Choice Then
            btn2.Content = strP2Choice
            btn2.IsEnabled = False

            'column 3
        ElseIf btn3.Content.ToString = strP1Choice And btn6.Content.ToString = strP1Choice And btn9.Content.ToString <> strP1Choice And btn9.Content.ToString <> strP2Choice Then
            btn9.Content = strP2Choice
            btn9.IsEnabled = False

        ElseIf btn3.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice And btn6.Content.ToString <> strP1Choice And btn6.Content.ToString <> strP2Choice Then
            btn6.Content = strP2Choice
            btn6.IsEnabled = False

        ElseIf btn6.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice And btn3.Content.ToString <> strP1Choice And btn3.Content.ToString <> strP2Choice Then
            btn3.Content = strP2Choice
            btn3.IsEnabled = False

            'diag left to right
        ElseIf btn1.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn9.Content.ToString <> strP1Choice And btn9.Content.ToString <> strP2Choice Then
            btn9.Content = strP2Choice
            btn9.IsEnabled = False

        ElseIf btn1.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice And btn5.Content.ToString <> strP1Choice And btn5.Content.ToString <> strP2Choice Then
            btn5.Content = strP2Choice
            btn5.IsEnabled = False

        ElseIf btn5.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice And btn1.Content.ToString <> strP1Choice And btn1.Content.ToString <> strP2Choice Then
            btn1.Content = strP2Choice
            btn1.IsEnabled = False

            'diag right to left
        ElseIf btn3.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn7.Content.ToString <> strP1Choice And btn7.Content.ToString <> strP2Choice Then
            btn7.Content = strP2Choice
            btn7.IsEnabled = False

        ElseIf btn3.Content.ToString = strP1Choice And btn7.Content.ToString = strP1Choice And btn5.Content.ToString <> strP1Choice And btn5.Content.ToString <> strP2Choice Then
            btn5.Content = strP2Choice
            btn5.IsEnabled = False

        ElseIf btn5.Content.ToString = strP1Choice And btn7.Content.ToString = strP1Choice And btn3.Content.ToString <> strP1Choice And btn3.Content.ToString <> strP2Choice Then
            btn3.Content = strP2Choice
            btn3.IsEnabled = False

        Else
            'if no move to block- pick any open spot
            Player2AnySpot()
        End If

    End Sub
    'sub to check if player 1 wins
    Private Sub CheckForWinnerP1()
        'check each horizontal, vertical, and diaganol row for 3 in a row of same content
        'if match display player 1 wins message
        If btn1.Content.ToString = strP1Choice And btn2.Content.ToString = strP1Choice And btn3.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn4.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn6.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn7.Content.ToString = strP1Choice And btn8.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn1.Content.ToString = strP1Choice And btn4.Content.ToString = strP1Choice And btn7.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn2.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn8.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn3.Content.ToString = strP1Choice And btn6.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn1.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn9.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn3.Content.ToString = strP1Choice And btn5.Content.ToString = strP1Choice And btn7.Content.ToString = strP1Choice Then
            txtGameWin.Text = "Player 1 Wins!"
            txtGameWin.Opacity = 1
        End If
        'if win message can be seen its game over
        If txtGameWin.Opacity = 1 Then
            blnGameOver = True
        End If

    End Sub

    'sub to check if player 2 wins
    Private Sub CheckForWinnerP2()
        'check each horizontal, vertical, and diaganol row for 3 in a row of same content
        'if match display player 2 wins message
        If btn1.Content.ToString = strP2Choice And btn2.Content.ToString = strP2Choice And btn3.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn4.Content.ToString = strP2Choice And btn5.Content.ToString = strP2Choice And btn6.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn7.Content.ToString = strP2Choice And btn8.Content.ToString = strP2Choice And btn9.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn1.Content.ToString = strP2Choice And btn4.Content.ToString = strP2Choice And btn7.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn2.Content.ToString = strP2Choice And btn5.Content.ToString = strP2Choice And btn8.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn3.Content.ToString = strP2Choice And btn6.Content.ToString = strP2Choice And btn9.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn1.Content.ToString = strP2Choice And btn5.Content.ToString = strP2Choice And btn9.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        ElseIf btn3.Content.ToString = strP2Choice And btn5.Content.ToString = strP2Choice And btn7.Content.ToString = strP2Choice Then
            txtGameWin.Text = "Player 2 Wins!"
            txtGameWin.Opacity = 1
        End If
        If txtGameWin.Opacity = 1 Then
            blnGameOver = True
        End If
    End Sub

    'sub to check for draw
    Private Sub CheckForDraw()
        'if all buttons are disabled and noone has won yet
        If btn1.IsEnabled = False And btn2.IsEnabled = False And btn3.IsEnabled = False And btn4.IsEnabled = False And btn5.IsEnabled = False And btn6.IsEnabled = False And btn7.IsEnabled = False And btn8.IsEnabled = False And btn9.IsEnabled = False Then
            'display message
            txtGameWin.Text = "Ended In Draw!"
            txtGameWin.Opacity = 1
            'end game
            blnGameOver = True

        End If

    End Sub

    'game over sub, disable all buttons
    Private Sub GameOver()
        btn1.IsEnabled = False
        btn2.IsEnabled = False
        btn3.IsEnabled = False
        btn4.IsEnabled = False
        btn5.IsEnabled = False
        btn6.IsEnabled = False
        btn7.IsEnabled = False
        btn8.IsEnabled = False
        btn9.IsEnabled = False
    End Sub

    'click events for game buttons, sends it self to SetXO sub
    Private Sub btn1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn1.Click
        SetXO(sender)
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn4.Click
        SetXO(sender)
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn7.Click
        SetXO(sender)
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn2.Click
        SetXO(sender)
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn5.Click
        SetXO(sender)
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn8.Click
        SetXO(sender)
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn3.Click
        SetXO(sender)
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn6.Click
        SetXO(sender)
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btn9.Click
        SetXO(sender)
    End Sub
    'new game button
    Private Sub btnNew_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnNew.Click
        'call new game sub
        NewGame()
    End Sub
    'new game sub
    Private Sub NewGame()
        myAnimateOnReload.Begin()
        myAnimateOnLoad.Begin()
        'call which player sub to see who is X and O
        WhichPlayer()
        'enable all buttons
        btn1.IsEnabled = True
        btn2.IsEnabled = True
        btn3.IsEnabled = True
        btn4.IsEnabled = True
        btn5.IsEnabled = True
        btn6.IsEnabled = True
        btn7.IsEnabled = True
        btn8.IsEnabled = True
        btn9.IsEnabled = True
        'set all button content back to blank
        btn1.Content = ""
        btn2.Content = ""
        btn3.Content = ""
        btn4.Content = ""
        btn5.Content = ""
        btn6.Content = ""
        btn7.Content = ""
        btn8.Content = ""
        btn9.Content = ""
        'hide win message
        txtGameWin.Opacity = 0
        'reset game over boolean
        blnGameOver = False
        'if user chooses to play as "O" they go second
        If rdbO.IsChecked = True Then
            'player 2 goes first
            Player2AnySpot()
        End If
    End Sub
    Private Sub WhichPlayer()
        'determine which player is which with the radio buttons
        If rdbX.IsChecked = True Then
            strP1Choice = "X"
            strP2Choice = "O"
        Else
            strP1Choice = "O"
            strP2Choice = "X"
        End If
    End Sub
    'to prevent cheeting and errors, start a new game when either radio button is changed
    Private Sub rdbO_Checked(sender As Object, e As System.Windows.RoutedEventArgs) Handles rdbO.Checked
        NewGame()
    End Sub

    Private Sub rdbX_Checked(sender As Object, e As System.Windows.RoutedEventArgs) Handles rdbX.Checked
        NewGame()
    End Sub

  

End Class
