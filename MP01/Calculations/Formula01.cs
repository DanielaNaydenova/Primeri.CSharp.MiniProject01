﻿using System;

namespace Calculations
{
	/// <summary>
	/// Клас за формула за обикновена строителна яма.(Формула 01)</summary>
	public class Formula01
	{
		//Библиотеки
		private Colors.ForCLI _c = new Colors.ForCLI ();
		/// <summary>
		/// Конструктор на Формула 01</summary>

		public Formula01 () 	//Формула за обикновена строителна яма
		{
		}

		/// <summary>
		/// Метод за пресмятане на Формула 01</summary>
		/// <param name="_userInput">Това е цялата команда с параметри, въведени от потребителя</param>
		//Парсване
		public void calc (string _userInput)
		{
			try {
				string [] param = _userInput.Split (' ');

				if (param.Length > 1 && _userInput.Contains ("-п"))		//-п - за помощ
				{
					//Помощ за командата

					help ();
				}

				if (param.Length > 0 && !_userInput.Contains ("-п"))		//-п - за помощ
				{
					//Изчисления
					double _result = 0;

					if (runCalculations (param, out _result))
					{
						_c.Default (); 	Console.Write ("Обемът на строителната яма е: ");
						_c.Result ();	Console.Write (_result.ToString ("N2"));
						_c.Default ();	Console.WriteLine (" m3\n");
					}else{
						_c.Default();	Console.WriteLine ("Има грешно въведен параметър. Можете да проверите синтаксиса с параметър '-п'\n");
					}
				}
			} catch {
			}
		}
			
		//Изчисление и изписване
		/// <summary>
		/// Вътрешен метод за пресмятане на Формула 01, след парсване на командата от потребителя</summary>
		/// <param name="_param">Това е масив от стрингове, който съдържа командата с параметрите от потребителя</param>
		/// <param name="_result">В тази променлива ще бъде върнат резултатът от формулата</param>
		/// <returns>Методът връща true при успешно изпълнение</returns>
		private bool runCalculations (string [] _param, out double _result)
		{
			try {
				double _a1 = 0, _b1 = 0, _a2 = 0, _b2 = 0, _h = 0;

				//_param[0] == <име на команда>
				double.TryParse(_param[1], out _a1);
				double.TryParse(_param[2], out _b1);
				double.TryParse(_param[3], out _a2);
				double.TryParse(_param[4], out _b2);
				double.TryParse(_param[5], out _h);

				double F1 = _a1 * _b1, F2 = _a2 * _b2;

				_result = _h * (F1 + F2) / 2;

				return true;
			}catch {
			}
			_result = 0;
			return false;
		}
	 	 
		//Помощ за командата
		/// <summary>
		/// Вътрешен метод, показващ синтаксиса на командата в командния ред.</summary>
		private void help ()
		{		
			_c.Result ();
			Console.Write ("[яма]");
			_c.Default ();
			Console.WriteLine (" - команда за пресмятане на строителна яма");

			_c.Command ();
			Console.Write ("параметри: ");
			_c.Default ();
			Console.WriteLine ("a1 b1 a2 b2 h\n");

			_c.Command ();
			Console.Write ("a1 и b1");
			_c.Default ();
			Console.WriteLine (" - ширина и дължина на горната страна на изкопа");

			_c.Command ();
			Console.Write ("a2 и b2");
			_c.Default ();
			Console.WriteLine (" - ширина и дължина на долната страна на изкопа");

			_c.Command ();
			Console.Write ("h");
			_c.Default ();
			Console.WriteLine (" - височина на изкопа\n");
		}
	}
	}
