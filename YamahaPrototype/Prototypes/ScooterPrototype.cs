using System;
namespace YamahaPrototype.Prototypes
{
	public class ScooterPrototype : YamahaPrototype
	{
        public override YamahaPrototype Clonar()
        {
            return (ScooterPrototype)this.MemberwiseClone();
        }

        public override string VerMoto()
        {
            return $"Modelo: Scooter. Motor: {_motor}. " +
                $"Rodado: {_rodado}. Carroceria: {_carroceria}";
        }
    }
}

