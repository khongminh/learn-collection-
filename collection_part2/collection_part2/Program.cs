using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace collection_List
{
	class Program
	{
		static void Main(string[] args)
		{
			var presidents = new LinkedList<string>();

			presidents.AddLast("JFK");
			presidents.AddLast("Lyndon B Johnson");
			presidents.AddLast("Rechard Nixon");
			presidents.AddLast("Jimmy Carter");


			
			foreach (string president in presidents)
			{
				Console.WriteLine(president);
			}

		}

		
	}

	

}
