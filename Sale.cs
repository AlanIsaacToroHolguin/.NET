namespace Demo
{
    public class BaseSale
    {blob:https://outlook.office.com/c247f9fb-d674-43fe-8e87-c654f591f25d
        protected decimal CommissionRate = 0.05m;
    }

    public class Sale : BaseSale
    {
        public decimal Total { get; private set; }
        private decimal _some;

        public Sale(decimal total)
        {
            this.Total = total;
            _some = 8m;
        }

        public string GetInfo()
        {
            return $"El total es {Total}";
        }

        public decimal TotalWithCommission()
        {
            return Total * (1 + CommissionRate);
        }
    }
}
