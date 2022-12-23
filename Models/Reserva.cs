namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentOutOfRangeException("A Suite não pode suportar tantos hospedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Suite.Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            valorTotal = diasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.9;
            }

            return valor;
        }
    }
}