using System.Reflection;
using System.Transactions;

public class Math
{
    public static void MathOperations()
    {
        string? operationWanted;
        List<string> previousGames = new();
        do
        {
            Console.WriteLine("Which operation would you like to work on? Addition (A), Subtraction (S), Multiplication (M), Division (D), View Previous Games (V), or Quit the game (Q)");
            operationWanted = Console.ReadLine();
            int startingTime = DateTime.Now.Second;
            int endTime;
            int timerTotal;

            string difficultySelector = "What difficulty level would you like? Easy (E), Medium (M), Hard (H), or Impossible (X)";
            string? difficultyWanted;


            Random random = new();
            int num1 = 0;
            int num2 = 0;

            int countCorrect = 0;
            string totalCorrect;


            switch (operationWanted)
            {
                case "A":
                    Console.WriteLine(difficultySelector);
                    difficultyWanted = Console.ReadLine();
                    for (int i = 0; i < 5; i++)
                    {
                        switch (difficultyWanted)
                        {
                            case "E":
                                num1 = random.Next(1, 11);
                                num2 = random.Next(1, 11);
                                break;
                            case "M":
                                num1 = random.Next(1, 41);
                                num2 = random.Next(1, 41);
                                break;
                            case "H":
                                num1 = random.Next(1, 81);
                                num2 = random.Next(1, 81);
                                break;
                            case "X":
                                num1 = random.Next(1, 101);
                                num2 = random.Next(1, 101);
                                break;
                            default:
                                Console.WriteLine("That wasn't an option, try again.");
                                break;
                        }

                        int result = num1 + num2;

                        Console.WriteLine($"{num1} + {num2} = ?");
                        string? answer = Console.ReadLine();
                        if (answer == result.ToString())
                        {
                            countCorrect += 1;
                            Console.WriteLine($"{answer} is correct!");
                            if (i < 4)
                            {
                                Console.WriteLine($"You currently have answered {countCorrect}/5 correctly");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nice Try!");
                        }
                    }
                    endTime = DateTime.Now.Second;
                    if(endTime < startingTime)
                    {
                        timerTotal = (endTime - startingTime) + 60;
                    }
                    else
                    {
                        timerTotal = endTime - startingTime;
                    }
                        totalCorrect = $"{countCorrect}/5";
                    previousGames.Add($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    Console.WriteLine($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    break;
                case "S":
                    Console.WriteLine(difficultySelector);
                    difficultyWanted = Console.ReadLine();
                    for (int i = 0; i < 5; i++)
                    {
                        switch (difficultyWanted)
                        {
                            case "E":
                                num1 = random.Next(1, 11);
                                num2 = random.Next(1, 11);
                                break;
                            case "M":
                                num1 = random.Next(1, 41);
                                num2 = random.Next(1, 41);
                                break;
                            case "H":
                                num1 = random.Next(1, 81);
                                num2 = random.Next(1, 81);
                                break;
                            case "X":
                                num1 = random.Next(1, 101);
                                num2 = random.Next(1, 101);
                                break;
                            default:
                                Console.WriteLine("That wasn't an option, try again.");
                                break;
                        }

                        int result = num1 - num2;
                        if (result >= 0)
                        {
                            Console.WriteLine($"{num1} - {num2} = ?");
                            string? answer = Console.ReadLine();

                            if (answer == result.ToString())
                            {
                                countCorrect++;
                                Console.WriteLine($"{result} is correct!");
                                if (i < 4)
                                {
                                    Console.WriteLine($"You currently have answered {countCorrect}/5 correctly");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nice Try!");
                            }
                        }
                        else
                        {
                            i--;
                            continue;
                        }

                    }
                    endTime = DateTime.Now.Second;
                    if (endTime < startingTime)
                    {
                        timerTotal = (endTime - startingTime) + 60;
                    }
                    else
                    {
                        timerTotal = endTime - startingTime;
                    }
                    totalCorrect = $"{countCorrect}/5";
                    previousGames.Add($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    Console.WriteLine($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    break;
                case "M":
                    Console.WriteLine(difficultySelector);
                    difficultyWanted = Console.ReadLine();
                    for (int i = 0; i < 5; i++)
                    {
                        switch (difficultyWanted)
                        {
                            case "E":
                                num1 = random.Next(1, 11);
                                num2 = random.Next(1, 11);
                                break;
                            case "M":
                                num1 = random.Next(1, 41);
                                num2 = random.Next(1, 41);
                                break;
                            case "H":
                                num1 = random.Next(1, 81);
                                num2 = random.Next(1, 81);
                                break;
                            case "X":
                                num1 = random.Next(1, 101);
                                num2 = random.Next(1, 101);
                                break;
                            default:
                                Console.WriteLine("That wasn't an option, try again.");
                                break;
                        }
                        int result = num1 * num2;

                        Console.WriteLine($"{num1} * {num2} = ?");
                        string? answer = Console.ReadLine();

                        if (answer == result.ToString())
                        {
                            countCorrect++;
                            Console.WriteLine($"{answer} is correct!");
                            if (i < 4)
                            {
                                Console.WriteLine($"You currently have answered {countCorrect}/5 correctly");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nice Try!");
                        }
                    }
                    endTime = DateTime.Now.Second;
                    if (endTime < startingTime)
                    {
                        timerTotal = (endTime - startingTime) + 60;
                    }
                    else
                    {
                        timerTotal = endTime - startingTime;
                    }
                    totalCorrect = $"{countCorrect}/5";
                    previousGames.Add($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    Console.WriteLine($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    break;
                case "D":
                    Console.WriteLine(difficultySelector);
                    difficultyWanted = Console.ReadLine();
                    for (int i = 0; i < 5; i++)
                    {
                        switch (difficultyWanted)
                        {
                            case "E":
                                num1 = random.Next(1, 11);
                                num2 = random.Next(1, 11);
                                break;
                            case "M":
                                num1 = random.Next(1, 41);
                                num2 = random.Next(1, 41);
                                break;
                            case "H":
                                num1 = random.Next(1, 81);
                                num2 = random.Next(1, 81);
                                break;
                            case "X":
                                num1 = random.Next(1, 101);
                                num2 = random.Next(1, 101);
                                break;
                            default:
                                Console.WriteLine("That wasn't an option, try again.");
                                break;
                        }

                        int result = num1 / num2;

                        if (num1 % num2 != 0 || num1 < num2)
                        {
                            i--;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{num1} / {num2} = ?");
                            string? answer = Console.ReadLine();
                            if (answer == result.ToString())
                            {
                                countCorrect++;
                                Console.WriteLine($"{answer} is correct!");
                                if (i < 4)
                                {
                                    Console.WriteLine($"You currently have answered {countCorrect}/5 correctly");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nice Try!");
                            }
                        }
                    }
                    endTime = DateTime.Now.Second;
                    if (endTime < startingTime)
                    {
                        timerTotal = (endTime - startingTime) + 60;
                    }
                    else
                    {
                        timerTotal = endTime - startingTime;
                    }
                    totalCorrect = $"{countCorrect}/5";
                    previousGames.Add($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    Console.WriteLine($"That game took: {timerTotal} seconds, and you got {totalCorrect} correct.");
                    break;
                case "V":
                    foreach (string game in previousGames)
                    {
                        Console.WriteLine(game);
                    }
                    break;
                case "Q":
                    Console.WriteLine("Thank you!");
                    break;
                default:
                    Console.WriteLine("That wasn't an option, try again.");
                    break;
            }
        } while (operationWanted != "Q");
    }
}

public class Program
{
    public static void Main()
    {
        Math.MathOperations();
    }
}

