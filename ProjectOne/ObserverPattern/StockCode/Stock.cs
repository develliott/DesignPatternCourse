namespace ProjectOne.ObserverPattern.StockCode
{
    public class Stock : Subject
    {
        public string Symbol;

        private float _price;
        public float Price
        {
            get => _price;
            set
            {
                if (value == _price) return;
                _price = value;
                NotifyObservers();
            }
        }

        public Stock(string symbol, float price)
        {
            Symbol = symbol;
            Price = price;
        }

        public override string ToString()
        {
            return "Stock{" +
                   "symbol='" + Symbol + '\'' +
                   ", price=" + Price +
                   '}';
        }
    }
}
