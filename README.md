# Tic-Tac-Toe

 Console implementation of the game "Tic-Tac-Toe".

<p>
<img alt="Image" width="350"px src="https://user-images.githubusercontent.com/74410756/216642677-5cd92b8b-302f-496b-9301-6674fe525057.jpg">
</p>

## Overview
`Tic-Tac-Toe` is a game in which two players take turns in choosing either an `X` or an `O` in one square of a grid consisting of nine squares. 

The **winner** is the first player to get three of the same symbols in a row **horizontally**, **vertically** or on **diagonals**.

There is two options to end a game:

- **A player win the game**: player to get three of the same symbols in a row.
- **Without winner**: there is no made sequance of three elemenst in a row from any player.

After each game you will be asked to press any key if you want to play again. Good luck!

## Input and Output
On the console will be initialized which player is on the move with identifiers X or O (Player X / Player O). Each player have to choose row and col for placing his next move.
- `row` is between `0` `1` `2`
- `col` is between `0` `1` `2`

The winner will be announced.

## Solution
- The game is implemented in C# using a 3x3 matrix for the board.
- Two methods are used - one to initialize (save the initial view of the board) and another to print the board.
- In a while loop, it detects which player's turn it is and reads input from the console for row and column.
  - If loop validates the entered values if they are in the coordinates of the board and if there is no symbol already placed at that position. If any of the conditions are not met, the same player is prompted to make his move again.
  - In the If loop, three methods are used, each of which checks whether a sequence of three identical symbols has already been made horizontally, vertically and diagonally. If either method returns true, the winner is printed to the console.
  - A game-ending check is also performed where there is no winner via a separate method.
  - If everything is valid and the game continues, a symbol is placed on the selected position and the next player takes his turn.

## Source Code
[Source code of the project](TicTacToe.cs)

## Screenshots
<img width="250" alt="SS1" src="https://user-images.githubusercontent.com/74410756/216659663-f0edfb9a-5a02-46ef-800b-1c8a36522195.png"> <img width="250" alt="SS2" src="https://user-images.githubusercontent.com/74410756/216659660-ae0464e2-749a-4196-b38a-84d7a193907b.png"> <img width="250" alt="SS3" src="https://user-images.githubusercontent.com/74410756/216659649-dc740c54-8d51-42ee-b6e1-225c10de83a8.png">

## One-Click Live Demo

[<img alt="Play" src="https://user-images.githubusercontent.com/74410756/193477520-ba86bbff-a312-4dbf-942a-c24e902073f7.png">](https://replit.com/@Dochkoff/Tic-Tac-Toe#Main.cs)

