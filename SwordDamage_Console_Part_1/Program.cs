using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamage_Console_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey(false);

                switch (keyInfo.KeyChar)
                {
                    case '0':
                    case '1': // magic
                    case '2': // flaming
                    case '3': // magic + flaming
                        CalculateSwordAttackPower(swordDamage, random, keyInfo.KeyChar);
                        break;
                    default:
                        return;
                }
            }
        }

        static void CalculateSwordAttackPower(SwordDamage swordDamage, Random random, char input)
        {
            int Roll = RollThreeDice(random);
            swordDamage.SetRoll(Roll);
            swordDamage.SetMagic(input == '1' || input == '3');
            swordDamage.SetFlaming(input == '2' || input == '3');
            Console.WriteLine($"\n{swordDamage.ToString()}\n");
        }

        static int RollThreeDice(Random random)
        {            
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                sum += random.Next(1, 7); // 1부터 6까지의 난수 생성
            }

            return sum;
        }
    }
}
