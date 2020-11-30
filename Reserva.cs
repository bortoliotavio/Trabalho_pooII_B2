using System;

namespace Trabalho_poo2
{
    public class Reserva
    {
        private int tipoAcomodacao;
        private DateTime entrada;
        private DateTime saida;
        private int numeroAcomodacao;
        private int rgCliente;
        public int getRgCliente()
        {
            return this.rgCliente;
        }

        public void setRgCliente(int rgCliente)
        {
            this.rgCliente = rgCliente;
        }

        public int getNumeroAcomodacao()
        {
            return this.numeroAcomodacao;
        }

        public void setNumeroAcomodacao(int numeroAcomodacao)
        {
            this.numeroAcomodacao = numeroAcomodacao;
        }


        public int getTipoAcomodacao()
        {
            return this.tipoAcomodacao;
        }

        public void setTipoAcomodacao(int tipoAcomodacao)
        {
            this.tipoAcomodacao = tipoAcomodacao;
        }

        public DateTime getEntrada()
        {
            return this.entrada;
        }

        public void setEntrada(DateTime entrada)
        {
            this.entrada = entrada;
        }

        public DateTime getSaida()
        {
            return this.saida;
        }

        public void setSaida(DateTime saida)
        {
            this.saida = saida;
        }

    }
}