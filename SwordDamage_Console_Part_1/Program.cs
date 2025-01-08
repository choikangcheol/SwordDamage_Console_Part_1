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
                char key = Console.ReadKey().KeyChar;

                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                CalculateSwordAttackPower(swordDamage, random, key);
            }
        }

        static void CalculateSwordAttackPower(SwordDamage swordDamage, Random random, char key)
        {
            int Roll = RollThreeDice(random);
            swordDamage.SetRoll(Roll);
            swordDamage.SetMagic(key == '1' || key == '3');
            swordDamage.SetFlaming(key == '2' || key == '3');
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
