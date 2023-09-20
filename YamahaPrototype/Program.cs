// See https://aka.ms/new-console-template for more information
using YamahaPrototype.Prototypes;
using YamahaProto = YamahaPrototype.Prototypes.YamahaPrototype;

// Scooter
YamahaProto scooter = new ScooterPrototype();
scooter.Motor = "50cc";
scooter.Rodado = "14";
scooter.Carroceria = "Hierro";

YamahaProto scooterCopy = scooter.Clonar();
Console.WriteLine(scooterCopy.VerMoto());

// Enduro
YamahaProto enduro = new EnduroPrototype();
enduro.Motor = "250cc";
enduro.Rodado = "22";
enduro.Carroceria = "Aluminio";

YamahaProto enduroCopy = enduro.Clonar();
Console.WriteLine(enduroCopy.VerMoto());

// Pistero
YamahaProto pistero = new EnduroPrototype();
pistero.Motor = "500cc";
pistero.Rodado = "19";
pistero.Carroceria = "Carbono";

YamahaProto pisteroCopy = pistero.Clonar();
Console.WriteLine(pisteroCopy.VerMoto());

Console.ReadKey();