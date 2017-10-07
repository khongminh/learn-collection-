using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace collection_List
{
	class NonblankList : Collection<string>
	{
		protected override void InsertItem(int index, string item)
		{
			if (string.IsNullOrWhiteSpace(item))
				throw new ArgumentException();

			base.InsertItem(index, item);
		}

		protected override void SetItem(int index, string item)
		{
			if (string.IsNullOrWhiteSpace(item))
				throw new ArgumentException();
			base.SetItem(index, item);
		}
	}

}
