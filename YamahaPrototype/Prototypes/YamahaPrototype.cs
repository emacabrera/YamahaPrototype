using System;
namespace YamahaPrototype.Prototypes
{
	public abstract class YamahaPrototype
	{
		protected string _motor;
		protected string _rodado;
		protected string _carroceria;

		public string Motor { set => _motor = value; }
        public string Rodado { set => _rodado = value; }
        public string Carroceria { set => _carroceria = value; }

		public abstract YamahaPrototype Clonar();

		public abstract string VerMoto();
    }
}

