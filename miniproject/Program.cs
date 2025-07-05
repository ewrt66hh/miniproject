using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rrtttefghj
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Fadlan geli magacaaga: ");
            string studentName = Console.ReadLine();

            Console.Write("Fadlan geli ID-gaaga: ");
            string studentID = Console.ReadLine();

            Console.WriteLine("\n== Xulo nooca xisaabta ==\n1. Kudar\n2. Kajar\n3. Kudhufo\n4. Qaybi");
            Console.Write("Xulashadaada (1-4): ");
            int selection = Convert.ToInt32(Console.ReadLine());

            int trueAnswers = 0;
            int totalQuestions = 10;

            Random generator = new Random();

            for (int num = 1; num <= totalQuestions; num++)
            {
                int x = generator.Next(1, 20);
                int y = generator.Next(1, 20);
                int correctAnswer = 0;

                switch (selection)
                {
                    case 1:
                        Console.Write($"Q{num}: {x} + {y} = ");
                        correctAnswer = x + y;
                        break;
                    case 2:
                        Console.Write($"Q{num}: {x} - {y} = ");
                        correctAnswer = x - y;
                        break;
                    case 3:
                        Console.Write($"Q{num}: {x} * {y} = ");
                        correctAnswer = x * y;
                        break;
                    case 4:
                        x = x * y;
                        Console.Write($"Q{num}: {x} / {y} = ");
                        correctAnswer = x / y;
                        break;
                    default:
                        Console.WriteLine("Xulashada khaldan!");
                        return;
                }

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("👏 Waa sax!\n");
                    trueAnswers++;
                }
                else
                {
                    Console.WriteLine($"❌ Waa khalad! Jawaabta saxda ahayd waa: {correctAnswer}\n");
                }
            }

            int incorrect = totalQuestions - trueAnswers;
            int percentage = (trueAnswers * 100) / totalQuestions;

            Console.WriteLine("\n--- Natiijadaada ---");
            Console.WriteLine($"Magaca: {studentName}");
            Console.WriteLine($"ID-ga: {studentID}");
            Console.WriteLine($"Sax: {trueAnswers} | Khalad: {incorrect}");
            Console.WriteLine($"Guud ahaan: {percentage}%");

        }
    }
}