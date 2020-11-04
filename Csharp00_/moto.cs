using System;

   namespace Csharp00_
   { 

   public class Moto : Veiculo
    {
       public Moto(string cor, string marca)
        {
            this.cor = cor;
            this.marca = marca;
            
        }
         private string veiculoDuasRodas(int duasRodas)
        {
            if(duasRodas == 2){
                return "Veiculo é uma moto";
            }
            return "Não é uma moto";
        }
        public string verificarVeiculo(string duasRodas)
        {
            return (duasRodas);
            
        } 
    }
   }