using System;

namespace Calculations
{
	/// <summary>
	/// Клас за формула за изчисляване на вдлъбнат ъгъл.(Формула 02)</summary>
	public class Formula02
	{
		Colors.ForCLI _cl = new Colors.ForCLI ();
		/// <summary>
		/// Конструктор на Формула 02</summary>

		//Формула за вдлъбнат ъгъл
		public Formula02 ()
		{
		}

		/// <summary>
		/// Метод за пресмятане на Формула 02</summary>
		/// <param name="_input">Това е цялата команда с параметри, въведени от потребителя</param>

		public void calc (string _input)
		{
			try
			{
				string [] param = _input.Split (' ');

				if (param.Length > 1 && _input.ToLower().Contains ("-п"))
				{
					help ();
				}

				if (param.Length == 4 || _input.ToLower().Contains ("-п"))
				{
				}else{
					_cl.Default ();		Console.WriteLine ("Има грешно въведени параметри. С параметъра '-п' можете\nда видите синтаксиса на командата.\n");
				}

				double _result = 0;

					if (runCalculate (param, out _result))
					{
						_cl.Default ();		Console.Write ("Обемът на вдлъбнатия ъгъл е ");
						_cl.Result ();		Console.Write (_result.ToString ("N2"));
						_cl.Default ();		Console.WriteLine (" m3\n");
				}
			}catch{
			}
		}

		/// <summary>
		/// Вътрешен метод за пресмятане на Формула 02, след парсване на командата от потребителя</summary>
		/// <param name="_param">Това е масив от стрингове, който съдържа командата с параметрите от потребителя</param>
		/// <param name="_result">В тази променлива ще бъде върнат резултатът от формулата</param>
		/// <returns>Методът връща true при успешно изпълнение</returns>
		private bool runCalculate (string [] _param, out double _result)
		{
			try
			{
				double _a = 0, _b = 0, _h = 0;	
				double.TryParse (_param[1], out _a);
				double.TryParse (_param[2], out _b);
				double.TryParse (_param[3], out _h);

				_result = _a * _b * _h /3;

				return true;
			}catch{
			}
			_result = 0;
			return false;
		}

		/// <summary>
		/// Вътрешен метод, показващ синтаксиса на командата в командния ред.</summary>
		private void help ()
		{
			_cl.Result ();	Console.Write ("[въгъл]");
			_cl.Default ();	Console.WriteLine (" - вдлъбнат ъгъл");

			_cl.Command ();	Console.Write ("параметри: ");
			_cl.Default ();	Console.WriteLine ("a, b и h\n");

			_cl.Command ();	Console.Write ("a и b");
			_cl.Default (); Console.WriteLine (" - ширина и дължина");

			_cl.Command ();	Console.Write ("h");
			_cl.Default ();	Console.WriteLine (" - височина\n");
		}
	}
}

