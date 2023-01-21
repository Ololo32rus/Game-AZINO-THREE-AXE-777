// автомат выдаёт рандомно ТРИ числа от 1 до 9. Пользователь крутит числа нажатием кноки, перед тем сделал ставку (у него есть счет изначально)


using _777;

int InputBet(int billAccaunt)
{
    bool isCorrectInput;
    int betUser = 0;

    do
    {
        try
        {
            isCorrectInput = true;

            Console.WriteLine($"***\t Your bill: {billAccaunt}$ \t***");
            Console.WriteLine($"\n *** Your bet in $ : ***");
            betUser = int.Parse(Console.ReadLine());
            Console.WriteLine("\n----------------");

            if (betUser > billAccaunt)
            {
                isCorrectInput = false;
                Console.WriteLine("Your need more money");
            }
        }
        catch
        {
            isCorrectInput = false;
            Console.WriteLine("Plaese send bet in NUMBER. From next game press all button + ENTER ");
        }
    } while (!isCorrectInput);


    return betUser;
}

void CasinoArray(int[] cazino)
{
    Random rnd = new Random();
    for (int i = 0; i < cazino.Length; i++)
    {
        cazino[i] = rnd.Next(1, 9 + 1);
    }
}

void OutputCasinoArray(int[] cazino)
{
    for (int i = 0; i < cazino.Length; i++)
    {
        Console.Write($"{cazino[i]} \t");
    }

    Console.WriteLine("\n----------------");
}

PrizeResult CazinoGame(int[] cazino, int betUser)
{
    PrizeResult prizeResult;

    if (cazino[0] == 7 && cazino[1] == 7 && cazino[2] == 7)
    {
        prizeResult.Win = betUser * 10;
        prizeResult.PrizeType = PrizeType.ThreeSeven;
    }
    else if (cazino[0] == 6 && cazino[1] == 6 && cazino[2] == 6)
    {
        prizeResult.Win = betUser * 6;
        prizeResult.PrizeType = PrizeType.ThreeSix;
    }
    else if (cazino[0] == cazino[1] && cazino[1] == cazino[2] && cazino[0] == cazino[2])
    {
        prizeResult.Win = betUser * 3;
        prizeResult.PrizeType = PrizeType.ThreeNumbers;
    }
    else if (cazino[0] == cazino[1] || cazino[1] == cazino[2] || cazino[0] == cazino[2])
    {
        prizeResult.Win = betUser * 2;
        prizeResult.PrizeType = PrizeType.TwoNumbers;
    }
    else
    {
        prizeResult.Win = 0;
        prizeResult.PrizeType = PrizeType.Nothing;
    }

    return prizeResult;
}

void OutputPrize(PrizeResult prizeResult, int billAccaunt)
{
    switch (prizeResult.PrizeType)
    {
        case PrizeType.ThreeSeven:
            Console.Write("JACKPOT! 777 AXE! Congratulations!!!");
            break;
        case PrizeType.ThreeSix:
            Console.Write("JACKPOT! ***666*** ");
            break;
        case PrizeType.ThreeNumbers:
            Console.Write(" *** x3 prize ***");
            break;
        case PrizeType.TwoNumbers:
            Console.Write("*** x2 prize ***");
            break;
        case PrizeType.Nothing:
            Console.Write("*** NOTHING prize ***");
            break;
    }

    Console.WriteLine("\n----------------");
    Console.WriteLine($"Your prize: {prizeResult.Win}$");
    Console.WriteLine($"***Your NEW BILL***: {billAccaunt}$");
}

bool WantsOneMore(int billAccaunt)
{
    if (billAccaunt == 0)
    {
        Console.Write("\n----------------");
        Console.WriteLine("\nGAME OVER! Your accaunt bill = 0, NEED MORE MONEY!");
        return false;
    }
    else
    {
        Console.WriteLine($"\nPlaese press |Y| for next game. Press |N| for quit");
        string input = Console.ReadLine();
        if (input == "Y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//--------------------------------------------------------------------------------------


//1 вносим деньги
//2 делаем ставку
//3 крутим колесо
//4 проверка выигрыша
//5 обновление баланса
//6 повторить ещё круг

int[] cazino = new int[3];
int billAccaunt = 100;
bool isPlay = true;

while (isPlay)
{
    int betUser = InputBet(billAccaunt);
    billAccaunt -= betUser;

    CasinoArray(cazino);
    OutputCasinoArray(cazino);

    PrizeResult prizeResult = CazinoGame(cazino, betUser);
    billAccaunt += prizeResult.Win;

    OutputPrize(prizeResult, billAccaunt);

    isPlay = WantsOneMore(billAccaunt);
}

Console.WriteLine($"YOUR FINISH billAccaunt = {billAccaunt}");
