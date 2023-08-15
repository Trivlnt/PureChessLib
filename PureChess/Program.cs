﻿// See https://aka.ms/new-console-template for more information
using PureChess;

Write("{=Blue}Welcome to PureChess Terminal{/}\n");
Write("Type 'help' for the list of commands\n");

Game game = new Game();
Board board = new Board();
Engine engine = new Engine();

game.board = board;
game.engine = engine;
board.game = game;

engine.game = game;

if (Console.ReadLine() == "play")
{
    Write("Starting new Game\n");

    game.StartGame();
}

if(Console.ReadLine() == "test")
{
    engine.ForceMove(board.squares[12], board.squares[20]);
}

void Write(string msg)
{
    string[] ss = msg.Split('{', '}');
    ConsoleColor c;
    foreach (var s in ss)
        if (s.StartsWith("/"))
            Console.ResetColor();
        else if (s.StartsWith("=") && Enum.TryParse(s.Substring(1), out c))
            Console.ForegroundColor = c;
        else
            Console.Write(s);
}

Console.ReadLine();