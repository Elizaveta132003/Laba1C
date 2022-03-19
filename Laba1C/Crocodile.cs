using System;

namespace Laba1C
{
	internal class Crocodile
	{
		private string _name;
		private double _weight;
		private double _lenght;

		public event Action<Crocodile, double> func;

		public string Name { get => _name; set => _name = value; }
		public double Weight { get => _weight; set => _weight = value; }
		public double Lenght
		{
			get => _lenght;
			set
			{
				if (value < _lenght) return;
				else
				{
					double oldLenght = _lenght;
					_lenght = value;
					func?.Invoke(this, oldLenght);
				}
			}
		}

		public Crocodile(string name, double weight, double lenght)
		{
			_name = name;
			_weight = weight;
			_lenght = lenght;
		}

		public override string ToString() => $"Имя:{_name} Вес:{_weight} Длина:{_lenght}";
	}
}
