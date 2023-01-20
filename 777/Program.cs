// автомат выдаёт рандомно ТРИ числа от 1 до 9. Пользователь крутит числа нажатием кноки, перед тем сделал ставку (у него есть счет изначально)

int billAccaunt = 100;
int InputBet()
    {
        bool Go = true;
        int betUser= 0;
        try
        {
            Console.WriteLine($"***\t Your bill: {billAccaunt}$ \t***");
            Console.WriteLine($"\n *** Your bet in $ : ***");
            betUser = int.Parse(Console.ReadLine());
            Console.WriteLine("\n----------------");
        billAccaunt -= betUser;
    }

        catch
        {
       
        Console.WriteLine("Plaese send bet in NUMBER. From next game press all button + ENTER ");
        Console.ReadLine(); 
        Console.Clear();
        Go = false;
        }
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

int ThreeSeven(int[] cazino, int betUser)
{
    int billAcaunt777 = 0;  
    {
        if (cazino[0] == 7 && cazino[1] == 7 && cazino[2] == 7)
        {
            Console.Write("JackPot 777 AXE");
            billAcaunt777 = betUser * 10;
            Console.WriteLine("\n----------------");
        }
    }
    return billAcaunt777;
}

int ThreeSix(int[] cazino, int betUser)
{
    int billAcaunt666 = 0;
    if (cazino[0] == 6 && cazino[1] == 6 && cazino[2] == 6)
            {
                Console.Write("JackPot 666 SATAN");
                billAcaunt666 = betUser * 6;
                Console.WriteLine("\n----------------");
            }
    return billAcaunt666;
}

int ThreeNumbers(int[]cazino, int betUser)
{ 
    int billAcauntMedium = 0;
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
            }
            return billAcauntMedium;
}

int TwoNumbers(int[] cazino, int betUser)
{ 
    int billAcauntLow = 0;
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
            }
            return billAcauntLow;
}
        
void OutputPrize(int[] cazino, int betUser)
{ 
        if (ThreeSeven(cazino, betUser) > 0)
        {
            Console.Write("JACKPOT! 777 AXE! Congratulations!!!");
            Console.WriteLine("\n----------------");
            Console.WriteLine($"Your prize: {ThreeSeven(cazino, betUser)}$");
            billAccaunt += ThreeSeven(cazino, betUser);
        }
        if (ThreeSix(cazino, betUser) > 0)
        {
            Console.Write("JACKPOT! ***666*** ");
            Console.WriteLine(" \n----------------");
            Console.WriteLine($"Your prize: {ThreeSix(cazino, betUser)}$");
            billAccaunt += ThreeSix(cazino, betUser);
        }
        if (ThreeNumbers(cazino, betUser) > 0)
        {
            Console.Write(" *** x3 prize ***");
            Console.WriteLine("\n----------------");
            Console.Write($"Your prize: {ThreeNumbers(cazino, betUser)}$");
            billAccaunt += ThreeNumbers(cazino, betUser);
        }
        if (TwoNumbers(cazino, betUser) > 0)
        {
            Console.Write("*** x2 prize ***");
            Console.WriteLine("\n----------------");
            Console.Write($"\nYour prize: {TwoNumbers(cazino, betUser)}$");
            billAccaunt += TwoNumbers(cazino, betUser);
        }
    Console.WriteLine($"\nPlaese press |all button + ENTER| from next game. Thanks");
    Console.ReadLine();
    Console.Clear();
}

void CazinoGame(int[] cazino, int betUser)
{
    for (int i = 0; i < cazino.Length; i++)
    {
        ThreeSeven (cazino, betUser);
        ThreeSix (cazino, betUser);
        ThreeNumbers (cazino, betUser);
        TwoNumbers(cazino, betUser);
    }
    Console.WriteLine();
    Console.WriteLine($"***Your NEW BILL***: {billAccaunt}$");
}

void ExitGame(int betUser)
{
    bool Go = true;
        if (billAccaunt == 0)
        {
            Console.Write("\n----------------");
            Console.WriteLine("\n Your accaunt bill = 0, NEED MORE MONEY!"); 
        Go = false;
        }
        if (betUser > billAccaunt)
        {
        Console.WriteLine($" Your BET more Your bill accaunt ");
        }
}
//--------------------------------------------------------------------------------------
int betUser = InputBet();
int[] cazino = new int[3];
do
{
    ExitGame(betUser);
    CasinoArray(cazino);
    OutputCasinoArray(cazino);
    CazinoGame(cazino, betUser);
    OutputPrize(cazino, betUser);

} while (!true);


// Проблемы
//1. Заходит 3ри раза на проверку выйграшных комибинаций 
//(3ри захода, а прерывал breakОМ - при выйграшной комбинации будет выкидывать каждый раз writeline...) 
//Надо: прервать проверку после первого захода.
//2. При неверном вводе ставки  продолжает выполнение программы.
//Надо: Перезапускать программу 
//3. Первым что делает заходит не в цикл, а в глобальную переменную betUser -> фунц. ImputBet
//4. Нормально не циклится.
//5. в программе до функций основной проблемой было что выйгрышная комбинация не перезаписывалась в 0, а принимала новое значение
