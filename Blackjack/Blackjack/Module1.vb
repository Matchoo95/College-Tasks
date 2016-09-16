Imports System
Imports System.Text
Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Module Module1
    Structure Cardset1
        Dim Cardvalue As Integer
        Dim Cardname As String
        Dim Suit As String
        Dim Used As Boolean
    End Structure
    Dim Cardset(52) As Cardset1
    Dim Choice As String
    Sub Main()
        Randomize()
        Call StartMenu()
    End Sub
    Sub StartMenu()
        Console.WriteLine("||Blackjack||")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("+Main Menu+")
        Console.WriteLine("1) Singleplayer (AI)")
        Console.WriteLine("2) Multiplayer (Online LAN)")
        Console.WriteLine("3) How to play")
        Choice = UCase(Console.ReadLine)
        If Choice = "3" Then
            Call Rules()
        ElseIf Choice = "1" Then
            Call Cards()
        End If
    End Sub
    Sub Cards()

        Cardset(1).Cardvalue = 11
        Cardset(1).Cardname = "ACE"
        Cardset(1).Suit = "HEARTS"
        Cardset(2).Cardvalue = 2
        Cardset(2).Cardname = "2"
        Cardset(2).Suit = "HEARTS"
        Cardset(3).Cardvalue = 3
        Cardset(3).Cardname = "3"
        Cardset(3).Suit = "HEARTS"
        Cardset(4).Cardvalue = 4
        Cardset(4).Cardname = "4"
        Cardset(4).Suit = "HEARTS"
        Cardset(5).Cardvalue = 5
        Cardset(5).Cardname = "5"
        Cardset(5).Suit = "HEARTS"
        Cardset(6).Cardvalue = 6
        Cardset(6).Cardname = "6"
        Cardset(6).Suit = "HEARTS"
        Cardset(7).Cardvalue = 7
        Cardset(7).Cardname = "7"
        Cardset(7).Suit = "HEARTS"
        Cardset(8).Cardvalue = 8
        Cardset(8).Cardname = "8"
        Cardset(8).Suit = "HEARTS"
        Cardset(9).Cardvalue = 9
        Cardset(9).Cardname = "9"
        Cardset(9).Suit = "HEARTS"
        Cardset(10).Cardvalue = 10
        Cardset(10).Cardname = "10"
        Cardset(10).Suit = "HEARTS"
        Cardset(11).Cardname = "JACK"
        Cardset(11).Cardvalue = 11
        Cardset(11).Suit = "HEARTS"
        Cardset(12).Cardname = "QUEEN"
        Cardset(12).Cardvalue = 11
        Cardset(12).Suit = "HEARTS"
        Cardset(13).Cardname = "KING"
        Cardset(13).Cardvalue = 11
        Cardset(13).Suit = "HEARTS"
        Cardset(14).Cardvalue = 11
        Cardset(14).Cardname = "ACE"
        Cardset(14).Suit = "DIAMONDS"
        Cardset(15).Cardvalue = 2
        Cardset(15).Cardname = "2"
        Cardset(15).Suit = "DIAMONDS"
        Cardset(16).Cardvalue = 3
        Cardset(16).Cardname = "3"
        Cardset(16).Suit = "DIAMONDS"
        Cardset(17).Cardvalue = 4
        Cardset(17).Cardname = "4"
        Cardset(17).Suit = "DIAMONDS"
        Cardset(18).Cardvalue = 5
        Cardset(18).Cardname = "5"
        Cardset(18).Suit = "DIAMONDS"
        Cardset(19).Cardvalue = 6
        Cardset(19).Cardname = "6"
        Cardset(19).Suit = "DIAMONDS"
        Cardset(20).Cardvalue = 7
        Cardset(20).Cardname = "7"
        Cardset(20).Suit = "DIAMONDS"
        Cardset(21).Cardvalue = 8
        Cardset(21).Cardname = "8"
        Cardset(21).Suit = "DIAMONDS"
        Cardset(22).Cardvalue = 9
        Cardset(22).Cardname = "9"
        Cardset(22).Suit = "DIAMONDS"
        Cardset(23).Cardvalue = 10
        Cardset(23).Cardname = "10"
        Cardset(23).Suit = "DIAMONDS"
        Cardset(24).Cardname = "JACK"
        Cardset(24).Cardvalue = 11
        Cardset(24).Suit = "DIAMONDS"
        Cardset(25).Cardname = "QUEEN"
        Cardset(25).Cardvalue = 11
        Cardset(25).Suit = "DIAMONDS"
        Cardset(26).Cardname = "KING"
        Cardset(26).Cardvalue = 11
        Cardset(26).Suit = "DIAMONDS"
        Cardset(27).Cardvalue = 11
        Cardset(27).Cardname = "ACE"
        Cardset(27).Suit = "SPADES"
        Cardset(28).Cardvalue = 2
        Cardset(28).Cardname = "2"
        Cardset(28).Suit = "SPADES"
        Cardset(29).Cardvalue = 3
        Cardset(29).Cardname = "3"
        Cardset(29).Suit = "SPADES"
        Cardset(30).Cardvalue = 4
        Cardset(30).Cardname = "4"
        Cardset(30).Suit = "SPADES"
        Cardset(31).Cardvalue = 5
        Cardset(31).Cardname = "5"
        Cardset(31).Suit = "SPADES"
        Cardset(32).Cardvalue = 6
        Cardset(32).Cardname = "6"
        Cardset(32).Suit = "SPADES"
        Cardset(33).Cardvalue = 7
        Cardset(33).Cardname = "7"
        Cardset(33).Suit = "SPADES"
        Cardset(34).Cardvalue = 8
        Cardset(34).Cardname = "8"
        Cardset(34).Suit = "SPADES"
        Cardset(35).Cardvalue = 9
        Cardset(35).Cardname = "9"
        Cardset(35).Suit = "SPADES"
        Cardset(36).Cardvalue = 10
        Cardset(36).Cardname = "10"
        Cardset(36).Suit = "SPADES"
        Cardset(37).Cardname = "JACK"
        Cardset(37).Cardvalue = 11
        Cardset(37).Suit = "SPADES"
        Cardset(38).Cardname = "QUEEN"
        Cardset(38).Cardvalue = 11
        Cardset(38).Suit = "SPADES"
        Cardset(39).Cardname = "KING"
        Cardset(39).Cardvalue = 11
        Cardset(39).Suit = "SPADES"
        Cardset(40).Cardvalue = 11
        Cardset(40).Cardname = "ACE"
        Cardset(40).Suit = "CLUBS"
        Cardset(41).Cardvalue = 2
        Cardset(41).Cardname = "2"
        Cardset(41).Suit = "CLUBS"
        Cardset(42).Cardvalue = 3
        Cardset(42).Cardname = "3"
        Cardset(42).Suit = "CLUBS"
        Cardset(43).Cardvalue = 4
        Cardset(43).Cardname = "4"
        Cardset(43).Suit = "CLUBS"
        Cardset(44).Cardvalue = 5
        Cardset(44).Cardname = "5"
        Cardset(44).Suit = "CLUBS"
        Cardset(45).Cardvalue = 6
        Cardset(45).Cardname = "6"
        Cardset(45).Suit = "CLUBS"
        Cardset(46).Cardvalue = 7
        Cardset(46).Cardname = "7"
        Cardset(46).Suit = "CLUBS"
        Cardset(47).Cardvalue = 8
        Cardset(47).Cardname = "8"
        Cardset(47).Suit = "CLUBS"
        Cardset(48).Cardvalue = 9
        Cardset(48).Cardname = "9"
        Cardset(48).Suit = "CLUBS"
        Cardset(49).Cardvalue = 10
        Cardset(49).Cardname = "10"
        Cardset(49).Suit = "CLUBS"
        Cardset(50).Cardname = "JACK"
        Cardset(50).Cardvalue = 11
        Cardset(50).Suit = "CLUBS"
        Cardset(51).Cardname = "QUEEN"
        Cardset(51).Cardvalue = 11
        Cardset(51).Suit = "CLUBS"
        Cardset(52).Cardname = "KING"
        Cardset(52).Cardvalue = 11
        Cardset(52).Suit = "CLUBS"

        Call Play()

    End Sub
    Sub Rules()

        Console.WriteLine("The rules are as follows;")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("1) Each player must reach a total of 21")
        Console.WriteLine("2) Each card represents a number, The number cards represent their respective numbers and the picture cards are all 11 and the ace is 1")
        Console.WriteLine("3) On your first go two cards will be drawn for you. If you wish to keep your cards and not draw again then type Stick. If you wish to draw again on the next round then please type Draw. These options will only become availabe during your turn")
        Console.WriteLine("4) If a player has 5 cards and still has a total under 21 they automatically win")
        Console.WriteLine("5) If 2 or more players draw then they will both take a card of the top of the deck and the winner of that game will be determined by the player with the highest scoring card")
        Console.ReadLine()
        System.Threading.Thread.Sleep(2000)
        Console.WriteLine("Are you ready to play?")
        Console.WriteLine("1) Yes")
        Console.WriteLine("2) No")
        Choice = Console.ReadLine
        If Choice = "1" Then
            Call Play()
            If Choice = "2" Then
                Call Main()
            End If
        End If
    End Sub
    Sub Play()

        Dim PlayerCards(5) As Integer
        Dim LoopCounter As Integer
        Dim LoopCounter2 As Integer
        

        Do
            LoopCounter = LoopCounter + 1
            PlayerCards(LoopCounter) = CInt(51 * Rnd() + 1)

            Console.WriteLine(LoopCounter & ": " & Cardset(PlayerCards(LoopCounter)).Cardname & " of " & Cardset(PlayerCards(LoopCounter)).Suit)
        Loop Until LoopCounter = 2
        Do
            Console.WriteLine("Press 1 to Stick and 2 to twist")
            Choice = UCase(Console.ReadLine)
            LoopCounter2 = 0
            Do
                LoopCounter2 = LoopCounter2 + 1
                If Choice = "1" Then
                    Call Player2(PlayerCards, LoopCounter)
                ElseIf Choice = "2" Then
                    LoopCounter = LoopCounter + 1
                    PlayerCards(LoopCounter) = CInt(51 * Rnd() + 1)
                    Console.WriteLine(LoopCounter & ": " & Cardset(PlayerCards(LoopCounter)).Cardname & " of " & Cardset(PlayerCards(LoopCounter)).Suit)
                End If
            Loop Until Choice = "2"
        Loop Until Choice = "1"
        Console.ReadLine()
    End Sub
   
    Sub Player2(ByVal PlayerCards, ByVal LoopCounter)

        Dim PlayerCards2(5) As Integer
        Dim LoopCounter3 As Integer
        Dim LoopCounter4 As Integer

        Console.WriteLine("Player 2 it is your turn")
        Do
            LoopCounter3 = LoopCounter3 + 1
            PlayerCards2(LoopCounter3) = CInt(51 * Rnd() + 1)

            Console.WriteLine(LoopCounter3 & ": " & Cardset(PlayerCards2(LoopCounter3)).Cardname & " of " & Cardset(PlayerCards2(LoopCounter3)).Suit)
        Loop Until LoopCounter3 = 2
        Do
            Console.WriteLine("Press 1 to Stick and 2 to twist")
            Choice = UCase(Console.ReadLine)
            LoopCounter4 = 0
            Do
                LoopCounter4 = LoopCounter4 + 1
                If Choice = "1" Then
                    Call EndGame(PlayerCards2, LoopCounter3, PlayerCards, LoopCounter)
                ElseIf Choice = "2" Then
                    LoopCounter3 = LoopCounter3 + 1
                    PlayerCards2(LoopCounter3) = CInt(51 * Rnd() + 1)
                    Console.WriteLine(LoopCounter3 & ": " & Cardset(PlayerCards2(LoopCounter3)).Cardname & " of " & Cardset(PlayerCards2(LoopCounter3)).Suit)
                End If
            Loop Until Choice = "2"
        Loop Until Choice = "1"
        Console.ReadLine()
    End Sub
    Sub EndGame(ByVal PlayerCards2, ByVal LoopCounter3, ByVal PlayerCards, ByVal LoopCounter)

        Dim CardTotal As Integer
        Dim CardTotal2 As Integer
        For LoopCounter = 1 To 5
            CardTotal = CardTotal + Cardset(PlayerCards(LoopCounter)).Cardvalue
        Next
        Console.WriteLine("Player 1, your card total is " & CardTotal)

        For LoopCounter3 = 1 To 5
            CardTotal2 = CardTotal2 + Cardset(PlayerCards2(LoopCounter3)).Cardvalue
        Next
        Console.WriteLine("Player 2, your card total is " & CardTotal2)

        If CardTotal > 21 And CardTotal2 < 21 Then
            Console.WriteLine("Player 1 you lose, congratulations Player 2")
        ElseIf CardTotal < 21 And CardTotal2 > 21 Then
            Console.WriteLine("Player 2 you lose, congratulations Player 1")
        ElseIf CardTotal > 21 And CardTotal2 > 21 Then
            Console.WriteLine("You both lose")
        ElseIf CardTotal > CardTotal2 And CardTotal < 21 Then
            Console.WriteLine("Congratulations Player 1, you win")
        ElseIf CardTotal2 > CardTotal And CardTotal < 21 Then
            Console.WriteLine("Congratulations Player 2, you win")
        End If
        Console.WriteLine()
        Console.WriteLine("Would you like to play again?")
        Console.WriteLine("1) Yes")
        Console.WriteLine("2) No")
        Choice = Console.ReadLine
        If Choice = "1" Then
            Console.Clear()
            Call Play()
        ElseIf Choice = "2" Then
            MsgBox("Thank you for playing")
            End
        End If
    End Sub
End Module
