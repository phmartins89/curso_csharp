using System;


namespace Csharp00_
{

    class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Carro");
            Carro car = new Carro("vermelho", "Peugeot");
            Console.WriteLine("Carro cor: "+car.cor+" Carro marca: "+car.marca);
            Console.WriteLine(car.mostrarSituacao("OPD2G12"));

            Console.WriteLine("Moto");
            Moto moto  = new Moto("preta", "Suzuki");
            Console.WriteLine("Moto cor: "+car.cor+" Moto marca: "+car.marca);
            Console.WriteLine(moto.verificarVeiculo("OPD2G12"));

            Console.WriteLine("Carro");
            Caminhao caminhao = new Caminhao("Azul", "Mercedes");
            Console.WriteLine("Caminhao cor: "+car.cor+" Caminhao marca: "+car.marca);
            Console.WriteLine(caminhao.veiculoDeCarga("Mercedes"));
        }

    }
      
}