namespace ConsoleApp1
{
    internal class AddCulc
    {
        int first_number,
            second_number;
        bool confirm = false;

        public AddCulc()
        {
            try
            {
                readNumbers();
            }
            catch (Exception Exept)
            {
                Console.WriteLine(Exept);
                retry();
            }
        }

        private void readNumbers()
        {
            Console.WriteLine("Print first number");
            first_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Print second number");
            second_number = int.Parse(Console.ReadLine());
            confirm = true;
        }

        private void retry()
        {
            Console.WriteLine("Try again? y/n");
            string key = Console.ReadLine();
            if (key.Length == 1)
            {
                switch (key[0])
                {
                    case ('y'):
                        readNumbers();
                        break;
                    case ('n'):
                        return;
                    default:
                        retry();
                        break;
                }
            }
            else
            {
                retry();
            }
        }

        public bool get_confirm() => confirm;

        public int Add() => first_number + second_number;
    }
}
