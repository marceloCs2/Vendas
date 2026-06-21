using VendasWeb.Models;
using VendasWeb.Models.Enums;

namespace VendasWeb.Data
{
    public class SeedingService
    {
        private VendasWebContext _context;

        public SeedingService(VendasWebContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVenda.Any())
            {
                return;
            }

            Departamento d1 = new Departamento(1, "Vendas");
            Departamento d2 = new Departamento(2, "Marketing");
            Departamento d3 = new Departamento(3, "Tecnologia");
            Departamento d4 = new Departamento(4, "Recursos Humanos");
            Departamento d5 = new Departamento(5, "Financeiro");
            Departamento d6 = new Departamento(6, "Logística");
            Departamento d7 = new Departamento(7, "Atendimento ao Cliente");
            Departamento d8 = new Departamento(8, "Jurídico");
            Departamento d9 = new Departamento(9, "Compras");
            Departamento d10 = new Departamento(10, "Administrativo");

            Vendedor v1 = new Vendedor(1, "João Silva", "joao.silva@email.com", new DateTime(1995, 2, 1), 7690.85, d4);
            Vendedor v2 = new Vendedor(2, "Maria Santos", "maria.santos@email.com", new DateTime(1982, 3, 24), 3217.47, d9);
            Vendedor v3 = new Vendedor(3, "Pedro Oliveira", "pedro.oliveira@email.com", new DateTime(1977, 10, 14), 2722.48, d2);
            Vendedor v4 = new Vendedor(4, "Ana Souza", "ana.souza@email.com", new DateTime(1981, 4, 17), 6714.13, d9);
            Vendedor v5 = new Vendedor(5, "Carlos Pereira", "carlos.pereira@email.com", new DateTime(1981, 12, 21), 7409.27, d7);
            Vendedor v6 = new Vendedor(6, "Juliana Costa", "juliana.costa@email.com", new DateTime(1982, 8, 19), 4447.33, d1);
            Vendedor v7 = new Vendedor(7, "Lucas Almeida", "lucas.almeida@email.com", new DateTime(1999, 3, 23), 5458.3, d5);
            Vendedor v8 = new Vendedor(8, "Fernanda Lima", "fernanda.lima@email.com", new DateTime(1979, 4, 25), 4856.16, d2);
            Vendedor v9 = new Vendedor(9, "Rafael Carvalho", "rafael.carvalho@email.com", new DateTime(1987, 2, 12), 8432.46, d10);
            Vendedor v10 = new Vendedor(10, "Camila Gomes", "camila.gomes@email.com", new DateTime(1983, 1, 24), 5715.97, d2);
            Vendedor v11 = new Vendedor(11, "Bruno Ribeiro", "bruno.ribeiro@email.com", new DateTime(1987, 2, 18), 4552.25, d10);
            Vendedor v12 = new Vendedor(12, "Patrícia Martins", "patricia.martins@email.com", new DateTime(2002, 6, 19), 3846.02, d2);
            Vendedor v13 = new Vendedor(13, "Gustavo Rocha", "gustavo.rocha@email.com", new DateTime(1976, 11, 8), 7911.48, d2);
            Vendedor v14 = new Vendedor(14, "Larissa Barbosa", "larissa.barbosa@email.com", new DateTime(2002, 4, 28), 3207.01, d5);
            Vendedor v15 = new Vendedor(15, "Felipe Araujo", "felipe.araujo@email.com", new DateTime(1989, 11, 27), 5053.83, d6);
            Vendedor v16 = new Vendedor(16, "Beatriz Fernandes", "beatriz.fernandes@email.com", new DateTime(1986, 4, 22), 4368.84, d2);
            Vendedor v17 = new Vendedor(17, "Diego Cardoso", "diego.cardoso@email.com", new DateTime(1994, 11, 6), 6238.98, d4);
            Vendedor v18 = new Vendedor(18, "Amanda Teixeira", "amanda.teixeira@email.com", new DateTime(1980, 8, 13), 4389.63, d9);
            Vendedor v19 = new Vendedor(19, "Thiago Moreira", "thiago.moreira@email.com", new DateTime(1982, 11, 11), 8399.96, d1);
            Vendedor v20 = new Vendedor(20, "Vanessa Nascimento", "vanessa.nascimento@email.com", new DateTime(1982, 1, 26), 4708.17, d5);

            RegistroVenda rv1 = new RegistroVenda(1, new DateTime(2023, 11, 21), 14728.4, StatusVenda.Pendente, v8);
            RegistroVenda rv2 = new RegistroVenda(2, new DateTime(2023, 09, 27), 4576.6, StatusVenda.Reprovada, v5);
            RegistroVenda rv3 = new RegistroVenda(3, new DateTime(2023, 09, 11), 9594.6, StatusVenda.Pendente, v18);
            RegistroVenda rv4 = new RegistroVenda(4, new DateTime(2023, 09, 25), 9182.9, StatusVenda.Aprovada, v5);
            RegistroVenda rv5 = new RegistroVenda(5, new DateTime(2023, 12, 11), 9602.1, StatusVenda.Pendente, v3);
            RegistroVenda rv6 = new RegistroVenda(6, new DateTime(2023, 12, 21), 13616.6, StatusVenda.Reprovada, v12);
            RegistroVenda rv7 = new RegistroVenda(7, new DateTime(2023, 12, 06), 4422.1, StatusVenda.Aprovada, v2);
            RegistroVenda rv8 = new RegistroVenda(8, new DateTime(2023, 10, 17), 4720.3, StatusVenda.Reprovada, v1);
            RegistroVenda rv9 = new RegistroVenda(9, new DateTime(2023, 09, 18), 13029.2, StatusVenda.Pendente, v9);
            RegistroVenda rv10 = new RegistroVenda(10, new DateTime(2023, 11, 26), 6850.5, StatusVenda.Aprovada, v6);
            RegistroVenda rv11 = new RegistroVenda(11, new DateTime(2023, 09, 13), 15784.3, StatusVenda.Aprovada, v17);
            RegistroVenda rv12 = new RegistroVenda(12, new DateTime(2023, 10, 16), 9450.3, StatusVenda.Reprovada, v15);
            RegistroVenda rv13 = new RegistroVenda(13, new DateTime(2023, 10, 26), 5563.8, StatusVenda.Aprovada, v19);
            RegistroVenda rv14 = new RegistroVenda(14, new DateTime(2023, 09, 22), 6394.3, StatusVenda.Reprovada, v13);
            RegistroVenda rv15 = new RegistroVenda(15, new DateTime(2023, 10, 03), 11340.6, StatusVenda.Aprovada, v4);
            RegistroVenda rv16 = new RegistroVenda(16, new DateTime(2023, 11, 11), 4032.2, StatusVenda.Pendente, v14);
            RegistroVenda rv17 = new RegistroVenda(17, new DateTime(2023, 11, 16), 7741.8, StatusVenda.Pendente, v20);
            RegistroVenda rv18 = new RegistroVenda(18, new DateTime(2023, 10, 12), 3656.4, StatusVenda.Reprovada, v7);
            RegistroVenda rv19 = new RegistroVenda(19, new DateTime(2023, 12, 06), 12508.7, StatusVenda.Aprovada, v16);
            RegistroVenda rv20 = new RegistroVenda(20, new DateTime(2023, 09, 02), 8211.5, StatusVenda.Pendente, v10);
            RegistroVenda rv21 = new RegistroVenda(21, new DateTime(2023, 12, 17), 8869.3, StatusVenda.Aprovada, v8);
            RegistroVenda rv22 = new RegistroVenda(22, new DateTime(2023, 09, 11), 3273.4, StatusVenda.Pendente, v8);
            RegistroVenda rv23 = new RegistroVenda(23, new DateTime(2023, 10, 01), 3922.9, StatusVenda.Pendente, v2);
            RegistroVenda rv24 = new RegistroVenda(24, new DateTime(2023, 10, 03), 14770.5, StatusVenda.Reprovada, v3);
            RegistroVenda rv25 = new RegistroVenda(25, new DateTime(2023, 10, 09), 11696.7, StatusVenda.Aprovada, v18);
            RegistroVenda rv26 = new RegistroVenda(26, new DateTime(2023, 10, 24), 15161.7, StatusVenda.Pendente, v19);
            RegistroVenda rv27 = new RegistroVenda(27, new DateTime(2023, 12, 08), 13200.1, StatusVenda.Reprovada, v7);
            RegistroVenda rv28 = new RegistroVenda(28, new DateTime(2023, 09, 04), 11566.8, StatusVenda.Reprovada, v14);
            RegistroVenda rv29 = new RegistroVenda(29, new DateTime(2023, 12, 15), 14229.9, StatusVenda.Aprovada, v4);
            RegistroVenda rv30 = new RegistroVenda(30, new DateTime(2023, 09, 13), 12466.8, StatusVenda.Aprovada, v8);
            RegistroVenda rv31 = new RegistroVenda(31, new DateTime(2023, 10, 07), 9971.7, StatusVenda.Aprovada, v14);
            RegistroVenda rv32 = new RegistroVenda(32, new DateTime(2023, 10, 09), 9014.2, StatusVenda.Aprovada, v15);
            RegistroVenda rv33 = new RegistroVenda(33, new DateTime(2023, 09, 02), 11477.9, StatusVenda.Pendente, v1);
            RegistroVenda rv34 = new RegistroVenda(34, new DateTime(2023, 09, 25), 14033.0, StatusVenda.Aprovada, v14);
            RegistroVenda rv35 = new RegistroVenda(35, new DateTime(2023, 12, 16), 5778.7, StatusVenda.Reprovada, v2);
            RegistroVenda rv36 = new RegistroVenda(36, new DateTime(2023, 10, 13), 3028.0, StatusVenda.Reprovada, v9);
            RegistroVenda rv37 = new RegistroVenda(37, new DateTime(2023, 12, 10), 8499.1, StatusVenda.Pendente, v18);
            RegistroVenda rv38 = new RegistroVenda(38, new DateTime(2023, 12, 05), 5468.7, StatusVenda.Aprovada, v2);
            RegistroVenda rv39 = new RegistroVenda(39, new DateTime(2023, 09, 24), 7076.9, StatusVenda.Aprovada, v19);
            RegistroVenda rv40 = new RegistroVenda(40, new DateTime(2023, 12, 17), 14952.0, StatusVenda.Pendente, v6);


            _context.Departamento.AddRange(d1, d2, d3, d4, d5, d6, d7, d8, d9, d10);
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
            _context.RegistroVenda.AddRange(rv1, rv2, rv3, rv4, rv5, rv6, rv7, rv8, rv9, rv10, rv11, rv12, rv13, rv14, rv15, rv16, rv17, rv18, rv19, rv20, rv21, rv22, rv23, rv24, rv25, rv26, rv27, rv28, rv29, rv30, rv31, rv32, rv33, rv34, rv35,	rv36,	rv37,	rv38,	rv39,	rv40);

            _context.SaveChanges();
        }
    }
}
