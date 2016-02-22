using System;

namespace Calculations
{
	public class Formula02
	{
		Colors.ForCLI _cl = new Colors.ForCLI ();

		//Формула за вдлъбнат ъгъл
		public Formula02 ()
		{
		}

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

