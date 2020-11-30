using System;

namespace Trabalho_poo2
{
    public class Cliente
    {
        private string nome;
        private string endereco;
        private int telefone;
        private string bairro;
        private string cidade;
        private string estado;
        private DateTime dataNascimento;
        private int rg;

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getEndereco()
        {
            return this.endereco;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public int getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(int telefone)
        {
            this.telefone = telefone;
        }

        public string getBairro()
        {
            return this.bairro;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getCidade()
        {
            return this.cidade;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getEstado()
        {
            return this.estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public DateTime getDataNascimento()
        {
            return this.dataNascimento;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public int getRg()
        {
            return this.rg;
        }

        public void setRg(int rg)
        {
            this.rg = rg;
        }
    }
}