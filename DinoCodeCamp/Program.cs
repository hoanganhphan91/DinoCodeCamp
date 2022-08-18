using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;
        int n;
        //Input n
        userInput = Console.ReadLine();
        /* Converts to integer type */
        n = Convert.ToInt32(userInput);
        //Input p[]
        userInput = Console.ReadLine();
        int[] p = new int[n];
        string[] subInput = userInput.Split(' ');
        for (int i =0; i< subInput.Length;i++)
        {
            p[i] = Convert.ToInt32(subInput[i]);
        }    
        //Input CHCHCH string
        string lightString = Console.ReadLine();

        // Tao so vi tri trong hanh lang mac dinh pHL[i] = 0 la vi tri rong
        int[] pHL = new int[n];
        for (int i = 0; i < lightString.Length; i++)
        {
            if (lightString[i]== 'C')
            {
                // Xu ly C khung long ra khoi chuong

                int dinoOut = p[0];

                // Sap xep hanh lang
                for (int j = 1; j < pHL.Length; j++)
                {
                    pHL[pHL.Length - j] = pHL[pHL.Length - j - 1];
                }
                pHL[0] = dinoOut;
                // Sap xep chuong
                for (int j = 0; j < p.Length-1; j++)
                {
                    p[j] = p[j+1];
                }
                p[p.Length - 1] = 0;
            }    
            else if (lightString[i] == 'H')
            {
                // Xy ly H khung long vao chuong

                int dinoIn = 0;
                // Tim con nao ra khoi hanh lang va sap xep hanh lang
                for (int j = pHL.Length-1; j >= 0; j--)
                {
                    if (pHL[j] > 0)
                    {
                        dinoIn = pHL[j];
                        pHL[j]=0;
                        break;
                    }
                }
                // Sap xep chuong
                for (int j = p.Length-1; j > 0; j--)
                {
                    p[j] = p[j - 1];
                }
                p[0] = dinoIn;
            }    

        }
        // In ra thu tu trong chuong
        for (int i = 0; i < p.Length; i++)
        {
            Console.Write("{0} ", p[i]);
        }

        return;
    }

    

    
}