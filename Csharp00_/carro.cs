using System;


namespace Csharp00_
{
    public class Carro : Veiculo
    {
        public Carro(string cor, string marca)
        {
            this.cor = cor;
            this.marca = marca;
        }
        public string mostrarSituacao(string placa)
        {
            return this.verificaSituacao(placa) == "Carro OK" ? "Veiculo OK" : "Veiculo com impedimento";
        }
    }
}