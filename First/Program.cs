using MSTestPracticeProgram;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1.Duplicate Number\n2.Swap Number\n3.Exit");
        bool loopAgain = true;
        while (loopAgain)
        {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PurchaseList list = new PurchaseList();
                    list.List();
                    break;
                case 2:
                    Console.WriteLine("Enter the words separated by a space:");
                    string[] words = Console.ReadLine().Split(' ');

                    if (words.Length != 2)
                    {
                        Console.WriteLine("Invalid input. Please enter two words separated by a space.");
                        return;
                    }
                    SwapConnection swapConnection = new SwapConnection();
                    bool canRearrange = swapConnection.Rearrange(words[0], words[1]);

                    Console.WriteLine(canRearrange ? "YES" : "NO");
                    break;
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                case 4:
                    loopAgain = false;
                    break;
            }
        }


    }
}