using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

class SnakeGame
{
    static int width = 40;
    static int height = 20;
    static int score = 0;
    static bool GameOver=false;


    static List<(int x, int y)> snake=new List<(int x, int y)> ();
    static (int x, int y) food;
    static (int x, int y) direction = (1, 0);

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.WindowHeight = height;
        Console.WindowWidth = width;

        InitialiazeGame();
    }

     static void   InitialiazeGame()
    {
      snake.Clear ();
     snake.Add((width/2,height/2));
      GenerateFood();

        while (!GameOver)
        {
            Draw();
            Input();
            logic();
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Game Over! Final Score: " + score);
        Console.ReadKey();

    }

    static void GenerateFood()
    {
        Random random = new Random();
        do
        {
            food = (random.Next(1, width - 1), random.Next(1, height - 1));
            
        } while(snake.Contains(food));
    }

    static void Draw()
    {

        Console.Clear();

        foreach (var part in snake)
        {
            Console.SetCursorPosition(part.x, part.y);
            Console.Write("0");
        }

        Console.SetCursorPosition(food.x, food.y);
        Console.Write("X");

        Console.SetCursorPosition(0, height - 1);
        Console.Write("score :" + score);

    }


    static void Input()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKey key=Console.ReadKey(true).Key;

            switch (key)
            {

                case ConsoleKey.UpArrow when direction != (0, 1):
                    direction= (0, -1);
                    break;


                case ConsoleKey.DownArrow when direction != (0, -1):
                    direction = (0, 1);
                    break;
                case ConsoleKey.LeftArrow when direction != (1, 0):
                    direction = (-1, 0);
                    break;
                case ConsoleKey.RightArrow when direction != (-1, 0):
                    direction = (1, 0);
                    break;
            }
        }
        }
    

    static void logic()
    {
        (int x, int y) newHead = (snake[0].x + direction.x, snake[0].y + direction.y);


        if (newHead.x < 0 || newHead.x >= width || newHead.y < 0 || newHead.y >= height)
        {
            GameOver = true;
            return;
        }

        if (snake.Contains(newHead))
        {
            GameOver = true;
            return;
        }

        snake.Insert(0, newHead);

        if (newHead == food)
        {
            score++;
            GenerateFood();
        }
        else
        {
            snake.RemoveAt(snake.Count - 1);
        }
    }



}