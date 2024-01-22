namespace InterfacesPractice
{
    //Mesma syntax da enrança, porém nesse caso é uma realização de interface, ITaxServices é uma interface e não class
    class BrasilTaxServices : ITaxServices
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }

}