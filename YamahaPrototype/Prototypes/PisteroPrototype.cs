using System;
namespace YamahaPrototype.Prototypes
{
    public class PisteroPrototype : YamahaPrototype
    {
        public override YamahaPrototype Clonar()
        {
            return (PisteroPrototype)this.MemberwiseClone(); 
        }

        public override string VerMoto()
        {
            return $"Modelo: Pistero. Motor: {_motor}. " +
                $"Rodado: {_rodado}. Carroceria: {_carroceria}";
        }
    }
}

