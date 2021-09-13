using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Game
    {
        string[] hangmanArt = new string[] {
            "****************************" +
            "\n  +---+" +
            "\n  |   |" +
            "\n      |" +
            "\n      |" +
            "\n      |" +
            "\n      |" +
            "\n=========" +
            "\n****************************",
            "****************************" +
            "\n  +---+" +
            "\n   |   |" +
            "\n   O   |" +
            "\n       |" +
            "\n       |" +
            "\n       |" +
            "\n=========" +
            "\n****************************",
            "****************************" +
            "  +---+" +
            "\n   |   |" +
            "\n   O   |" +
            "\n   |   |" +
            "\n       |" +
            "\n       |" +
            "\n=========" +
            "\n****************************",
            "****************************" +
            "\n   +---+" +
            "\n   |   |" +
            "\n   O   |" +
            "\n  /|   |" +
            "\n       |" +
            "\n       |" +
            "\n=========" +
            "\n****************************",
            "****************************" +
            "\n  +---+" +
            "\n   |   |" +
            "\n   O   |" +
            @"\n  /|\  |" +
            "\n       |" +
            "\n       |" +
            "\n=========" +
            "\n****************************",
            "****************************" +
            "\n   |   |" +
            "\n   O   |" +
            @"\n  /|\  |" +
            "\n  /    |" +
            "\n       |" +
            "\n=========" +
            "\n****************************",
            "****************************" +
            "\n   |   |" +
            "\n   O   |" +
            @"\n  /|\  |" +
            @"\n  / \  |" +
            "\n       |" +
            "\n=========" +
            "\n****************************", };
        int currentScene;
        int hangmanIndex;
        bool gameOver = false;

        public void Run()
        {
            Start();

            while (!gameOver)
            {
            Update();
            }

            End();
        }

        void Display()
        {
            switch (currentScene)
            {
                case 0:
                    DisplayMainMenu();
                    break;
                case 1:
                    RenderHangman();
                    break;

            }
        }

        void Update()
        {
            Display();
        }

        void Start()
        {
            currentScene = 0;
            hangmanIndex = 0;
        }

        void End()
        {

        }

        void DisplayMainMenu()
        {
            Console.WriteLine("Hello, this is a console-based Hangman game.");
            Console.WriteLine("I hope you enjoy.");
            Console.ReadKey(true);
            Console.Clear();
            currentScene++;
        }

        void RenderHangman()
        {
            Console.WriteLine(hangmanArt[hangmanIndex]);
            Console.ReadKey(true);

        }
    }
}
