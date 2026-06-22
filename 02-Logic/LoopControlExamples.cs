partial class Program
{
    static void LoopControlExamples()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            //Console.WriteLine(i);
        }
        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7)
            {
                continue;
            }
            //Console.WriteLine(i);
        }
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                //return;
            }
            //Console.WriteLine(i);
        }
        //Bucles infinitos
        while (true)
        {
            Console.WriteLine("Esto siempre se ejecutará");
            break;
        }
        //Bucles infinitos con for
        for (; ; )
        {
            Console.WriteLine("Esto siempre se desde el for");
            break;
        }
    }
}
