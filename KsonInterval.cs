using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class KsonInterval
	{
		public ulong _y; // pulse number
		public ulong _length = 0;

		public KsonInterval(ulong y, ulong length = 0)
		{
			_y = y;
			_length = length;
		}
	}
}
