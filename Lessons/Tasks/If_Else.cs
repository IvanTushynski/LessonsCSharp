class If_Else
{

    public void taskRandomSubscription()
    {
        {
            Console.WriteLine("discount---------------------");
            Random random = new Random();
            int daysUntilExpiration = random.Next(10,12);
            int discountPercentage = random.Next(10,12);
            if (daysUntilExpiration == 10 || discountPercentage == 10)
            {
                Console.WriteLine("1--------------------");
            }
            else if (daysUntilExpiration == 11 || discountPercentage == 11)
            {
                Console.WriteLine("2---------------------");
            }
            else if (daysUntilExpiration == 12 || discountPercentage == 12)
            {
                Console.WriteLine("3---------------------");
            }
        }
    }
}