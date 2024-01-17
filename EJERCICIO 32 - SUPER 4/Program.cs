using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace M03.UF2.Activitats
{
    public class Ejercicio_32
    {
        public static void Main()
        {
            const string MsgAvatar = "Selecciona el personatge\n1.\n2.\n3.\n4.";
            const string MsgName = "Introdueix un Nombre. Ha de tenir entre 2 - 25 lletres, y no ha de tenir caracters especials";
            const string MsgEvilLevel = "Introdueix el nivel de maldat. Ha de estar entre (1000-50000)";
            int CharacterNum;
            string Name;
            int EvilLevel;
            bool evil;
            int magicNumber;
            char [] vocalarray = {'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u'};

            do
            {
                Console.WriteLine(MsgAvatar);
                CharacterNum = Convert.ToInt32(Console.ReadLine());
            } while (!Rang(CharacterNum, 4, 1));

            do
            {
                Console.WriteLine(MsgName);
                Name = Console.ReadLine();
            } while (LongName(Name) == false && SpecialCount(Name) == false);

            do
            {
                Console.WriteLine(MsgEvilLevel);
                EvilLevel = Convert.ToInt32(Console.ReadLine());
            } while (!Rang(EvilLevel, 50000, 1000));

            evil = CountVocals(Name, vocalarray);

            magicNumber = DamageEvil(EvilLevel, evil, 4);

            Console.WriteLine($"L'Espurna ha repartit {magicNumber} als personatges");
            if (evil == true)
            {
                Console.WriteLine($"L'avatar obté un {EvilLevel - magicNumber * 4} de maldat");
            } 
            

        }
        public static int DamageEvil(int evilnum, bool ValidationVocal, int CharactersNumber)
        {
            if (ValidationVocal == true)
            {
                return (evilnum / 4);
            }
            else
            {
                return (((evilnum/100)*5)/ 4);
            }
        }
        public static bool SpecialCount(string name) /*Comprueba si el nombre tiene caracteres especiales*/
        {
            return name.Contains("_");
        }
        public static bool CountVocals(string name, char[] vocalArray)/*Cuanta las vocales del nombre*/
        {
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < vocalArray.Length; j++)
                {
                    if (name[i] == vocalArray[j])
                    {
                        count++;
                    }
                    if (count == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool LongName(string name) /*Comprueba la longitud del nombre*/
        {
            if (name.Length <= 25 && name.Length >=  2)
            {
                return true;
            }
            return false;
        }
        public static bool Rang(int word, int MaxRang, int LessRang) /*Comprueba si es un avatar*/
        {
            if (word >= LessRang && word <= MaxRang)
            {
                return true;
            }
            return false;
        }  
    }
}