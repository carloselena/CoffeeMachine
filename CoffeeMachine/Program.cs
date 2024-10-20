using System;
using CoffeeMachine.Entities;
using CoffeeMachine.Common;

namespace CoffeeMachine.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Máquina de Café");

            CoffeeMachineClass coffeeMachine = new CoffeeMachineClass
            {
                CoffeeMaker = new CoffeeMaker(100),
                SugarSupplier = new SugarSupplier(50),
                SmallCups = new SmallCup(10),
                MediumCups = new MediumCup(10),
                LargeCups = new LargeCup(10)
            };

            while (true)
            {
                Console.WriteLine("\nSeleccione el tipo de taza:");
                Console.WriteLine("1. Pequeña");
                Console.WriteLine("2. Mediana");
                Console.WriteLine("3. Grande");
                Console.WriteLine("0. Salir");

                int cupChoice = int.Parse(Console.ReadLine());

                if (cupChoice == 0)
                    break;

                Cup selectedCup = cupChoice switch
                {
                    1 => coffeeMachine.SmallCups,
                    2 => coffeeMachine.MediumCups,
                    3 => coffeeMachine.LargeCups,
                    _ => null
                };

                if (selectedCup == null)
                {
                    Console.WriteLine("Tipo de taza no válido.");
                    continue;
                }

                Console.WriteLine("Ingrese la cantidad de tazas:");
                int cupQuantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de azúcar por taza:");
                int sugarQuantity = int.Parse(Console.ReadLine());

                string result = coffeeMachine.GetCoffeeCup(selectedCup, cupQuantity, sugarQuantity);
                Console.WriteLine("\n" + result + "\n");

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Datos de la taza seleccionada:");
                Console.WriteLine($"Tipo de taza: {(selectedCup is SmallCup ? "Pequeña" : selectedCup is MediumCup ? "Mediana" : "Grande")}");
                Console.WriteLine($"Cantidad de tazas: {cupQuantity}");
                Console.WriteLine($"Cantidad de azúcar por taza: {sugarQuantity}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Café restante: {coffeeMachine.CoffeeMaker.CoffeeQuantity}");
                Console.WriteLine($"Azúcar restante: {coffeeMachine.SugarSupplier.SugarQuantity}");
                Console.WriteLine($"Tazas pequeñas restantes: {coffeeMachine.SmallCups.Quantity}");
                Console.WriteLine($"Tazas medianas restantes: {coffeeMachine.MediumCups.Quantity}");
                Console.WriteLine($"Tazas grandes restantes: {coffeeMachine.LargeCups.Quantity}");
            }
        }
    }
}

