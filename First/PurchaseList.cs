namespace MSTestPracticeProgram
{
    public class PurchaseList
    {
        public int[] ListA()
        {
            int[] list = { 7, 5, 4, 7, 94, 1, 11 };
            int len = list.Length;
            int soldForOnce = 0;
            int soldMoreThanOnce = 0;
            bool flag = false;
            Dictionary<int, int> frequencyOfPrice = new Dictionary<int, int>();
            foreach (int i in list)
            {
                if (frequencyOfPrice.ContainsKey(i))
                {
                    frequencyOfPrice[i]++;
                }
                else
                {
                    frequencyOfPrice[i] = 1;
                }
            }
            foreach (int Key in frequencyOfPrice.Keys)
            {
                if (frequencyOfPrice[Key] == 1)
                {
                    soldForOnce = Key;
                    break;
                }
            }
            foreach (int Key in frequencyOfPrice.Keys)
            {
                if (frequencyOfPrice[Key] > 1)
                {
                    soldMoreThanOnce = Key;
                    break;
                }
            }
            if (list.Length == 0)
            {
                Console.WriteLine("\nNone");
            }
            else
            {
                bool isRepeating = false;
                foreach (int Key in frequencyOfPrice.Keys)
                {
                    if (frequencyOfPrice[Key] != 1)
                    {
                        isRepeating = true;
                        break;
                    }
                }
                Console.WriteLine("\n" + soldForOnce);
                if (!isRepeating)
                    Console.WriteLine("None");
                else
                    Console.WriteLine(soldMoreThanOnce);
            }
            int[] arrReturn = { soldForOnce, soldMoreThanOnce };
            return arrReturn;
        }
    }
}

