namespace Services
{
    public interface ICartService
    {
        double Total();
        IEnumerable<CartItem> Items();
    }
}