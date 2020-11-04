using System;

   namespace Csharp00_
   { 

   public class Caminhao : Veiculo
    {
       public Caminhao(string cor, string marca)
        {
            this.cor = cor;
            this.marca = marca;
        }

        private bool veiculoLevaCarga(string levaCarga)
        {
            return (levaCarga == "Mercedes");
        }

        public string veiculoDeCarga(string levaCarga)
        {
            return this.veiculoLevaCarga(levaCarga) ? "Veiculo de Carga" : "Não é um veículo de carga.";
        } 
    }
   }