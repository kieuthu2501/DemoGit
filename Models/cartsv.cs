namespace KieuThuXuan_DoAn.Models
{
    public class CartService
    {
        private readonly ApplicationDbContext _context;
        public List<CartItem> CartItems { get; private set; } = new List<CartItem>();

        public CartService(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddToCart(int id, int quantity)
        {
            var sanPham = await _context.SanPhams.FindAsync(id);
            if (sanPham != null)
            {
                var cartItem = CartItems.FirstOrDefault(ci => ci.IDSP == id);
                if (cartItem == null)
                {
                    CartItems.Add(new CartItem { IDSP = id, SanPham = sanPham, Quantity = quantity });
                }
                else
                {
                    cartItem.Quantity += quantity;
                }
            }
        }

        public void RemoveFromCart(int id)
        {
            var cartItem = CartItems.FirstOrDefault(ci => ci.IDSP == id);
            if (cartItem != null)
            {
                CartItems.Remove(cartItem);
            }
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }

        public decimal GetTotal()
        {
            return CartItems.Sum(ci => ci.SanPham.GiaSP * ci.Quantity);
        }
    }
}
