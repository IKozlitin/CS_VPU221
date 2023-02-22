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
                "\n\t\t\t\t\t Нажми 1-Викторина " +
                "\n\t\t\t\t\t Нажми 2-Угадай число");
            int userNumber = 0;
        }

        //**********************END****************************

        //*******************START_QUIZ************************
        static void startQuiz()
        {
            string[] questions =
            {
                "Самая высокая гора? ",
                "Самая длинная река? ",
                "Самая большая страна? ",
                "Самая большая планета? ",
                "Первый человек в космосе? ",
                "Столица России? ", "Столица Китая? ", "Столица Франции? ", "Столица Германии? ", "Столица Италии? "
            };
            string[] answers =
            {
                "эверест", "амазонка", "россия", "юпитер", "гагарин", "москва", "пекин", "париж", "берлин", "рим"
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
                    WriteLine("Ответ верный!");
                }
                else
                {
                    WriteLine("Ответ не верный!");
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
            do
            {
                WriteLine("Введи число: ");
                userNumber = Int32.Parse(ReadLine());
                count++;

                if(userNumber < magicNumber)
                {
                    WriteLine("Введенное число меньше загаданного!");
                }
                else if(userNumber > magicNumber)
                {
                    WriteLine("Введенное число больше загаданного!");
                }
                else if(userNumber == magicNumber)
                {
                    WriteLine("Верно! Загаданное число " + magicNumber);
                    WriteLine($"Тебе понадобилось {count} попыток");
                    break;
                }
            }
            while (userNumber != magicNumber);
        }

        //****************************END****************************


            static void Main(string[] args)
            {
                //gameSelect();
                startQuiz();
                guessNumber();
            }
        }
    }