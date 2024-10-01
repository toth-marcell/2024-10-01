namespace _2024_10_01
{
    public class Product
    {
        public int Id;
        public string Name;
        public int Quantity;
        public int Price;
        public override string ToString() => $"{Id}\t\t{Name}\t\t{Quantity}x\t\t{Price}$";
    }
}
