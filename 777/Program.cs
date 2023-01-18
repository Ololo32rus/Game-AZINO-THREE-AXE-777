// автомат выдаёт рандомно ТРИ числа от 1 до 9. Пользователь крутит числа нажатием кноки, перед тем сделал ставку (у него есть счет изначально)

int billAccaunt = 100;
int billOne = 0;
int billAcaunt777 = 0;
int billAcaunt666 = 0;
int billAcauntMedium = 0;
int billAcauntLow = 0;

bool toGO = true;
Console.WriteLine($"Ваш счет {billAccaunt}");
do
{
    Random rnd = new Random();
    int[] cazino = new int[3];
    int betUser;

    for (int i = 0; i < cazino.Length; i++)
    {
        cazino[i] = rnd.Next(1, 9 + 1);
    }

    try
    {
        Console.WriteLine($" \n Введите вашу ставку $ :");
        betUser = int.Parse(Console.ReadLine());
        Console.WriteLine("\n ***********************");

        billAccaunt -= betUser;

        for (int i = 0; i < cazino.Length; i++)
        {
            Console.Write($"{cazino[i]} \t");
        }
        Console.WriteLine("\n ***********************");
        for (int i = 0; i < cazino.Length; i++)
        {
            if (cazino[0] == 7 && cazino[1] == 7 && cazino[2] == 7)
            {
                Console.Write("JackPot 777 AXE");
                billAcaunt777 = betUser * 10 + billAccaunt;
                Console.WriteLine($"\n New BILL {billAcaunt777}");
                Console.WriteLine("\n ***********************");
            }
            else if (cazino[0] == 6 && cazino[1] == 6 && cazino[2] == 6)
            {
                Console.Write("JackPot 666 SATAN");
                billAcaunt666 = betUser * 6 + billAccaunt;
                Console.WriteLine($"\n New BILL {billAcaunt666}");
                Console.WriteLine("\n ***********************");
            }

            else if (cazino[0] == 1 && cazino[1] == 1 && cazino[2] == 1 ||
                cazino[0] == 2 && cazino[1] == 2 && cazino[2] == 2 ||
                cazino[0] == 3 && cazino[1] == 3 && cazino[2] == 3 ||
                cazino[0] == 4 && cazino[1] == 4 && cazino[2] == 4 ||
                cazino[0] == 5 && cazino[1] == 5 && cazino[2] == 5 ||
                cazino[0] == 8 && cazino[1] == 8 && cazino[2] == 8 ||
                cazino[0] == 9 && cazino[1] == 9 && cazino[2] == 9)
            {
                Console.Write("Add x3 YOR BILL");
                billAcauntMedium = betUser * 3 + billAccaunt;
                Console.WriteLine($"\n New BILL {billAcauntMedium}");
                Console.WriteLine("\n ***********************");
            }

            else if (cazino[0] == 7 && cazino[1] == 7 ||
                cazino[0] == 1 && cazino[1] == 1 ||
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
                Console.Write("JackPot");
                billAcauntLow = betUser * 2 + billAccaunt;
                Console.WriteLine($"\n New BILL {billAcauntLow}");
                Console.WriteLine("\n ***********************");
            }
        }
        if (billAcaunt777 > 0)
        {
            Console.Write("JACKPOT! 777 AXE! Congratulations!!!");
            Console.WriteLine($"Your prize: {billAcaunt777}");
            billAccaunt += billAcaunt777;
        }
        else if (billAcaunt666 > 0)
        {
            Console.Write("JACKPOT! ***666*** ");
            Console.WriteLine($"Your prize: {billAcaunt666}");
            billAccaunt += billAcaunt666;
        }
        else if (billAcauntMedium > 0)
        {
            Console.Write("*** x3 prize ***");
            Console.WriteLine("----------------");
            Console.Write($"Your prize: {billAcauntMedium}");
            billAccaunt += billAcauntMedium;
        }
        else if (billAcauntLow > 0)
        {
            Console.Write("*** x2 prize ***");
            Console.WriteLine("----------------");
            Console.Write($"Your prize: {billAcauntLow}");
            billAccaunt += billAcauntLow;
        }


        else if (billAccaunt == 0)
        {
            Console.Write("----------------");
            Console.WriteLine("Ваш баланс  0, пополните!");
            toGO = false;
        }
        Console.WriteLine();
        Console.WriteLine($"Ваш счет: {billAccaunt}");

        Console.ReadLine();
        Console.Clear();
    }

    catch
    {
        toGO = false;
        Console.WriteLine("Не работает программаБ извените!");
    }
} while (toGO);




