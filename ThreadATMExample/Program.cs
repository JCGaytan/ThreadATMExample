namespace ThreadATMExample
{
    class Program
    {
        static int accountBalance = 1000; // Initial account balance
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!");
            Console.WriteLine("Press Enter to start transactions...");
            Console.ReadLine();

            // Create multiple threads to simulate ATM transactions
            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(PerformTransaction);
                threads[i].Start(i + 1);
            }

            // Wait for all threads to complete
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("All transactions completed.");
            Console.WriteLine($"Final account balance: ${accountBalance}");
        }

        static void PerformTransaction(object threadId)
        {
            for (int i = 0; i < 5; i++)
            {
                // Generate a random amount to withdraw between $10 and $100
                int amountToWithdraw = random.Next(10, 101);

                // Simulate some processing time
                Thread.Sleep(100);

                // Use a lock to ensure only one thread accesses the balance at a time
                lock (typeof(Program))
                {
                    if (accountBalance >= amountToWithdraw)
                    {
                        accountBalance -= amountToWithdraw;
                        Console.WriteLine($"Thread {threadId}: Withdrew ${amountToWithdraw}");
                    }
                    else
                    {
                        Console.WriteLine($"Thread {threadId}: Insufficient funds. Required: ${amountToWithdraw}");
                    }
                }
            }
        }
    }
}
