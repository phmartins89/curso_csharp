using System;

namespace Csharp00_
{

     public class Veiculo
      {
        public string cor { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
    
        public string verificaSituacao(string placa)
        {
        return "Carro OK";
        }
    }
 
 }