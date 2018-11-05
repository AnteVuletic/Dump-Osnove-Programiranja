using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string descriptionLecture = "Svako predavanje traje ";
            double timeLecture = 1.5;
            string descriptionPracticeOne = "sat, dok radionice traju po";
            int timePractice = 2;
            string descriptionPracticeTwo = "stata.";
            string descriptionTaskOne = "Obavezno koristite zasebne varijable za tekst i svaki od dva navedena broja u tekstu, te";
            string descriptionTaskTwo = "potom promijenite sadržaj svake tako da se sada ispiše nešto poput:";
            string descriptionLectureExampleOne = "Svaka radionica traje";
            int timeLectureExample = 6;
            string descriptionLectureExampleTwo = "sati, dok predavanja traju po";
            double timePracticeExample = 3.5;
            string descriptionLectureExampleThree = "sata.";

            Console.WriteLine(descriptionLecture + " " + timeLecture + " " + descriptionPracticeOne + " " + timePractice + " " + descriptionPracticeTwo);
            Console.WriteLine();
            Console.WriteLine(descriptionTaskOne);
            Console.WriteLine(descriptionTaskTwo);
            Console.WriteLine();
            Console.WriteLine(descriptionLectureExampleOne + " " + timeLectureExample + " " + descriptionLectureExampleTwo + " " + timePracticeExample + " " + descriptionLectureExampleThree);

        }
    }
}
