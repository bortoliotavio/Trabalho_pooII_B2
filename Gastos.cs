namespace Trabalho_poo2
{
    public class Gastos
    {
        private int rgCliente;
        private int telefone;
        private int diaria;
        private int alimentacao;

        public int getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(int telefone)
        {
            this.telefone = telefone;
        }

        public int getDiaria(int tipoAcomodacao)
        {
            switch (tipoAcomodacao)
            {
                case 1:
                    return 50;
                case 2:
                    return 90;                  
                case 3:
                    return 120;
                default:
                    return 0;                   
            }
            // return this.diaria;
        }

        public int getAlimentacao()
        {
            return this.alimentacao;
        }

        public void setAlimentacao(int alimentacao)
        {
            this.alimentacao = alimentacao;
        }
        public int getRgCliente()
        {
            return this.rgCliente;
        }

        public void setRgCliente(int rgCliente)
        {
            this.rgCliente = rgCliente;
        }
    }
}