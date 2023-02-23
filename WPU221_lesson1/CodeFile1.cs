using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WPU221_lesson1
{
    class Program
    {
        //******************SELECT_GAME***********************
        static void gameSelect()
        {
            WriteLine("\t\t\t\t\t *****Выбери игру***** " +
                "\n\t\t\t\t\t Нажми 1 - Викторина " +
                "\n\t\t\t\t\t Нажми 2 - Угадай число");
            int gameSelection = Int32.Parse(ReadLine());
            switch (gameSelection)
            {
                case 1: startQuiz(); break;
                case 2: guessNumber(); break;
            }
        }

        //**********************END****************************

        //********************REPLAY***************************

        static void gameReplay()
        {
            WriteLine("\t\t\t\t\t *****Конец игры***** " + 
                     "\n\t\t\t\t\tНажми 1 - Выбор игры!" + 
                     "\n\t\t\t\t\tНажми 2 - Выход!");
            int gameReplay = Int32.Parse(ReadLine());
            switch (gameReplay)
            {
                case 1: Clear(); gameSelect(); break;
            }
            while (Read() != '2');
        }
        //**********************END****************************

        //*******************START_QUIZ************************
        static void startQuiz()
        {
            string[] questions =
            {
                "1) Самая высокая гора? ",
                "2) Самая длинная река? ",
                "3) Самая большая страна? ",
                "4) Самая большая планета? ",
                "5) Первый человек в космосе? ",
                "6) Столица России? ", "7) Столица Китая? ", "8) Столица Франции? ",
                "9) Столица Германии? ", "10) Столица Италии? "
            };
            string[] answers =
            {
                "эверест", "амазонка", "россия", "юпитер", "гагарин",
                "москва", "пекин", "париж", "берлин", "рим"
            };
            int countOfRightAnswers = 0;
            string userAnswer;

            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i] + " ");
                userAnswer = ReadLine();
                if (userAnswer.ToLower() == answers[i])
                {
                    countOfRightAnswers++;
                    WriteLine("Ответ верный!\n");
                }
                else
                {
                    WriteLine("Ответ не верный!\n");
                }
            }
            WriteLine("Правильных ответов: " + countOfRightAnswers);
            if (countOfRightAnswers == 0)
            {
                WriteLine("Плохо!");
            }
            else if ((countOfRightAnswers >= 1) && (countOfRightAnswers <= 3))
            {
                WriteLine("Старайся лучше!");
            }
            else if ((countOfRightAnswers > 3) && (countOfRightAnswers <= 6))
            {
                WriteLine("Молодец!");
            }    
            else if ((countOfRightAnswers > 6) && (countOfRightAnswers <= 9))
            {
                WriteLine("Отличный результат!");
            }
            else if (countOfRightAnswers == 10)
            {
                WriteLine("МЕГА МОЗГ!");
            }
            gameReplay();
        }

        //****************************END****************************

        //**********************MAGIC_NUMBER*************************
        static void guessNumber()
        {
            WriteLine("*******Угадай число от 0 до 100!******");
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int count = 0;
            int attempt = 10;

            do
            {
                Write("Число попыток: " + attempt + "\tВведите число: ");
                userNumber = Int32.Parse(ReadLine());
                count++;
                attempt--;

                if (userNumber < magicNumber)
                {
                    WriteLine("Введенное число - " + userNumber + " меньше загаданного!\n");
                }
                else if (userNumber > magicNumber)
                {
                    WriteLine("Введенное число - " + userNumber + " больше загаданного!\n");
                }
                else if (userNumber == magicNumber || attempt != 0)
                {
                    WriteLine("Верно! Загаданное число " + magicNumber);
                    WriteLine($"Тебе понадобилось {count} попыток");
                    break;
                }
            }
            while (attempt != 0 && userNumber != magicNumber);
            WriteLine("Попробуй ещё раз!");
            gameReplay();  
        }

        //****************************END****************************


            static void Main(string[] args)
            {
                gameSelect();
            }
    }
}