using System;
namespace YamahaPrototype.Prototypes
{
    public class EnduroPrototype : YamahaPrototype
    {

        public override YamahaPrototype Clonar()
        {
            return (EnduroPrototype)this.MemberwiseClone();
        }

        public override string VerMoto()
        {
            return $"Modelo: Enduro. Motor: {_motor}. " +
                $"Rodado: {_rodado}. Carroceria: {_carroceria}";
        }
    }
}
