// автомат выдаёт рандомно ТРИ числа от 1 до 9. Пользователь крутит числа нажатием кноки, перед тем сделал ставку (у него есть счет изначально)

using System.Text;

int billAccaunt = 100;

bool toGO = true;
do
{
    int billAcauntLow = 0;
    int billAcaunt777 = 0;
    int billAcaunt666 = 0;
    int billAcauntMedium = 0;

    Random rnd = new Random();
    int[] cazino = new int[3];
    int betUser;

    for (int i = 0; i < cazino.Length; i++)
    {
        cazino[i] = rnd.Next(1, 9 + 1);
    }

    try
    {
        Console.WriteLine($"***\t Your bill: {billAccaunt}$ \t***");
        Console.WriteLine($"\n *** Your bet in $ : ***");
        betUser = int.Parse(Console.ReadLine());
        Console.WriteLine("\n----------------");

        if (betUser > billAccaunt)
        {
            Console.WriteLine($" Your BET more Your bill accaunt ");
            continue;
        }

        billAccaunt -= betUser;

        for (int i = 0; i < cazino.Length; i++)
        {
            Console.Write($"{cazino[i]} \t");
        }
        Console.WriteLine("\n----------------");
        for (int i = 0; i < cazino.Length; i++)
        {
            if (cazino[0] == 7 && cazino[1] == 7 && cazino[2] == 7)
            {
                Console.Write("JackPot 777 AXE");
                billAcaunt777 = betUser * 10;
                Console.WriteLine("\n----------------");
                break;
            }
            if (cazino[0] == 6 && cazino[1] == 6 && cazino[2] == 6)
            {
                Console.Write("JackPot 666 SATAN");
                billAcaunt666 = betUser * 6;
                Console.WriteLine("\n----------------");
                break;
            }

            if (cazino[0] == 1 && cazino[1] == 1 && cazino[2] == 1 ||
                cazino[0] == 2 && cazino[1] == 2 && cazino[2] == 2 ||
                cazino[0] == 3 && cazino[1] == 3 && cazino[2] == 3 ||
                cazino[0] == 4 && cazino[1] == 4 && cazino[2] == 4 ||
                cazino[0] == 5 && cazino[1] == 5 && cazino[2] == 5 ||
                cazino[0] == 8 && cazino[1] == 8 && cazino[2] == 8 ||
                cazino[0] == 9 && cazino[1] == 9 && cazino[2] == 9)
            {
                Console.Write("Add x3 YOR BILL");
                billAcauntMedium = betUser * 3;
                Console.WriteLine("\n----------------");
                break;
            }

            if (cazino[0] == 1 && cazino[1] == 1 ||
                cazino[1] == 1 && cazino[2] == 1 ||
                cazino[0] == 2 && cazino[1] == 2 ||
                cazino[1] == 2 && cazino[2] == 2 ||
                cazino[0] == 3 && cazino[1] == 3 ||
                cazino[1] == 3 && cazino[2] == 3 ||
                cazino[0] == 4 && cazino[1] == 4 ||
                cazino[1] == 4 && cazino[2] == 4 ||
                cazino[0] == 5 && cazino[1] == 5 ||
                cazino[1] == 5 && cazino[2] == 5 ||
                cazino[0] == 6 && cazino[1] == 6 ||
                cazino[1] == 6 && cazino[2] == 6 ||
                cazino[0] == 7 && cazino[1] == 7 ||
                cazino[1] == 7 && cazino[2] == 7 ||
                cazino[0] == 8 && cazino[1] == 8 ||
                cazino[1] == 8 && cazino[2] == 8 ||
                cazino[0] == 9 && cazino[1] == 9 ||
                cazino[1] == 9 && cazino[2] == 9)
            {
                Console.Write("Add x2 YOUR BILL");
                billAcauntLow = betUser * 2;
                Console.WriteLine("\n----------------");
                break;
            }
        }
        if (billAcaunt777 > 0)
        {
            Console.Write("JACKPOT! 777 AXE! Congratulations!!!");
            Console.WriteLine("\n----------------");
            Console.WriteLine($"Your prize: {billAcaunt777}$");
            billAccaunt += billAcaunt777;
        }
        else if (billAcaunt666 > 0)
        {
            Console.Write("JACKPOT! ***666*** ");
            Console.WriteLine(" \n----------------");
            Console.WriteLine($"Your prize: {billAcaunt666}$");
            billAccaunt += billAcaunt666;
        }
        else if (billAcauntMedium > 0)
        {
            Console.Write("*** x3 prize ***");
            Console.WriteLine("\n----------------");
            Console.Write($"Your prize: {billAcauntMedium}$");
            billAccaunt += billAcauntMedium;
        }
        else if (billAcauntLow > 0)
        {
            Console.Write("*** x2 prize ***");
            Console.WriteLine("\n----------------");
            Console.Write($"\nYour prize: {billAcauntLow}$");
            billAccaunt += billAcauntLow;
        }

        else if (billAccaunt == 0)
        {
            Console.Write("\n----------------");
            Console.WriteLine("\n Your accaunt bill = 0, NEED MORE MONEY!");
            toGO = false;
        }
        Console.WriteLine();
        Console.WriteLine($"***Your NEW BILL***: {billAccaunt}$");

        Console.WriteLine($"\nPlaese press all button + ENTER from next game. Thanks");
        Console.ReadLine();
        Console.Clear();
    }

    catch
    {
        Console.WriteLine("Plaese send bet in NUMBER. From next game press all button + ENTER ");
        Console.ReadLine();
        Console.Clear();
    }
} while (toGO);