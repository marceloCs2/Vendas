using VendasWeb.Models;


namespace VendasWeb.Services
{
    public class VendedorService
    {
        private readonly VendasWebContext _context;

        public VendedorService(VendasWebContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }


    }
}
