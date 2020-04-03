namespace BankAccountKata
{
    public class Account
    {
        private double _sold;
        
        public Account(){
            _sold = 0;
        }

        public double getSold(){
            return _sold;
        }

        public void updateSold(double newSold){
            _sold = newSold;
        }
    }
}