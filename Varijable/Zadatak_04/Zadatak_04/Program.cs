using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string descriptionLecture = "Svako predavanje traje ";
            string descriptionPracticeOne = "sat, dok radionice traju po";
            string descriptionPracticeTwo = "stata.";
            string descriptionTaskOne = "Obavezno koristite zasebne varijable za tekst i svaki od dva navedena broja u tekstu, te";
            string descriptionTaskTwo = "potom promijenite sadržaj svake tako da se sada ispiše nešto poput:";
            string descriptionLectureExampleOne = "Svaka radionica traje";
            string descriptionLectureExampleTwo = "sati, dok predavanja traju po";
            string descriptionLectureExampleThree = "sata.";

            double timeLecture,timePractice,timePracticeExample,timeLectureExample = 0;
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("| Molim pratite instrukcije te za potvrdu unosa stisnite tipku Enter. |");
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Unesite vrijeme trajanja jednog predavanja:");
            timeLecture = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite vrijeme trajanja jedne radionice:");
            timePractice = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite vrijeme trajanja jedne radionice za primjer:");
            timePracticeExample = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite vrijeme trajanja jednog predavanja za primjer:");
            timeLectureExample = double.Parse(Console.ReadLine());

            Console.WriteLine(descriptionLecture + " " + timeLecture + " " + descriptionPracticeOne + " " + timePractice + " " + descriptionPracticeTwo);
            Console.WriteLine();
            Console.WriteLine(descriptionTaskOne);
            Console.WriteLine(descriptionTaskTwo);
            Console.WriteLine();
            Console.WriteLine(descriptionLectureExampleOne + " " + timePracticeExample + " " + descriptionLectureExampleTwo + " " + timeLectureExample + " " + descriptionLectureExampleThree);
        }
    }
}
