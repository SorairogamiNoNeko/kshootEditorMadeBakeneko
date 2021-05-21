using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class NotesData
	{
		public Dictionary<int, MeasureUnit> NotesInfo { get; set; } = new Dictionary<int, MeasureUnit>();
		public MeasureControl BeatChangeInfo { get; set; } = new MeasureControl();

		public NotesData()
		{
		}
	}
}
