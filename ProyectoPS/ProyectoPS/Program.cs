using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las dimensiones del plano de juego (ancho x alto):");
            string[] dimensions = Console.ReadLine().Split(' ');
            int screenWidth = int.Parse(dimensions[0]);
            int screenHeight = int.Parse(dimensions[1]);
            Console.SetWindowSize(screenWidth + 1, screenHeight + 1);
            Console.CursorVisible = false;

            int score = 0;
            bool gameOver = false;

            // Inicializar la serpiente
            Snake snake = new Snake(screenWidth / 2, screenHeight / 2);

            // Generar comida aleatoria
            food Food = new Food(screenWidth, screenHeight);

            while (!gameOver)
            {
                // Actualizar la dirección de la serpiente
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.X)
                    {
                        gameOver = true;
                    }
                    else
                    {
                        snake.ChangeDirection(input.Key);
                    }
                }

                // Mover la serpiente
                snake.Move();

                // Verificar si la serpiente ha chocado contra una pared o contra sí misma
                if (snake.CheckCollision(screenWidth, screenHeight))
                {
                    gameOver = true;
                }

                // Verificar si la serpiente ha comido la comida
                if (snake.CheckFoodCollision(food))
                {
                    snake.Grow();
                    food = new Food(screenWidth, screenHeight);
                    score++;
                }

                // Dibujar la serpiente y la comida
                Console.Clear();
                snake.Draw();
                food.Draw();

                // Mostrar la puntuación
                Console.SetCursorPosition(0, 0);
                Console.Write("Score: {0}", score);

                // Esperar un breve momento antes de continuar
                Thread.Sleep(100);
            }

            // Mostrar el mensaje de Game Over
            Console.Clear();
            Console.SetCursorPosition(screenWidth / 2 - 5, screenHeight / 2);
            Console.Write("Game Over!");
            Console.ReadLine();
        }
    }

    class Snake
    {
        private List<Point> body;
        private Point direction;

        public Snake(int x, int y)
        {
            body = new List<Point>();
            body.Add(new Point(x, y));
            direction = new Point(1, 0);
        }

        public void ChangeDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (direction.Y != 1) direction = new Point(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    if (direction.Y != -1) direction = new Point(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction.X != 1) direction = new Point(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    if (direction.X != -1) direction = new Point(1, 0);
                    break;
            }
        }

        public void Move()
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0].X += direction.X;
            body[0].Y += direction.Y;
    }   }
}
