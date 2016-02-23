using System;

namespace Calculations
{
	/// <summary>
	/// Клас за формула за изчисляване на канален изкоп.(Формула 05)</summary>
	public class Formula05
	{
		Colors.ForCLI _cl = new Colors.ForCLI ();
		/// <summary>
		/// Конструктор на Формула 05</summary>

		public Formula05 ()
		{
		}

//		Формула за: Канaлен изкоп
///		Формула: (а + b ) / 2 * h * L
///		където:
//
//		а и b - горна и долна ширина на профилa
///		h - височина
///		L - дължина
	
		/// <summary>
		/// Метод за пресмятане на Формула 05</summary>
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

				if (param.Length > 0 && !_input.ToLower().Contains ("-п"))
				{
					double _result = 0;

				if (runCalculate (param, out _result))
				{
					_cl.Default ();		Console.Write ("Обемът на каналния изкоп е ");
					_cl.Result ();		Console.Write (_result.ToString ("N2"));
					_cl.Default ();		Console.WriteLine (" m3\n");
				}else{
					_cl.Default ();		Console.WriteLine ("Има грешно въведени параметри. С параметъра '-п' можете\nда видите синтаксиса на командата.\n");
				}
				}
			}catch{
			}
		}

		/// <summary>
		/// Вътрешен метод за пресмятане на Формула 05, след парсване на командата от потребителя</summary>
		/// <param name="_param">Това е масив от стрингове, който съдържа командата с параметрите от потребителя</param>
		/// <param name="_result">В тази променлива ще бъде върнат резултатът от формулата</param>
		/// <returns>Методът връща true при успешно изпълнение</returns>
		private bool runCalculate (string [] _param, out double _result)
		{
			try
			{
				double _a = 0, _b = 0, _h = 0, _L = 0;	
				double.TryParse (_param[1], out _a);
				double.TryParse (_param[2], out _b);
				double.TryParse (_param[3], out _h);
				double.TryParse (_param[4], out _L);

				_result = (_a + _b) / 2 * _h * _L;

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
			_cl.Result ();	Console.Write ("[кизкоп]");
			_cl.Default ();	Console.WriteLine (" - канален изкоп");

			_cl.Command ();	Console.Write ("параметри: ");
			_cl.Default ();	Console.WriteLine ("a, b, h и L\n");

			_cl.Command ();	Console.Write ("a и b");
			_cl.Default (); Console.WriteLine (" - горна и долна ширина и дължина");

			_cl.Command ();	Console.Write ("h");
			_cl.Default ();	Console.WriteLine (" - височина\n");

			_cl.Command ();	Console.Write ("L");
			_cl.Default ();	Console.WriteLine (" - дължина\n");
		}
	
	}
}

