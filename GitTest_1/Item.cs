using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_1
{
	public class Item
	{
		public string Name { get; private set; }
		public int Value { get; private set; }

		public Item(string name, int value)
		{
			if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
			this.Name = name;
			this.Value = value;
		}
	}

}
