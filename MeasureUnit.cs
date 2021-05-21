using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class MeasureUnit
	{
		public enum NoteType
		{
			BtShortA,
			BtShortB,
			BtShortC,
			BtShortD,
			BtLongA,
			BtLongB,
			BtLongC,
			BtLongD,
			FxChipL,
			FxChipR,
			FxLongL,
			FxLongR,
			LaserL,
			LaserR
		}

		public Dictionary<NoteType, NotesMonoLaneMeasureUnit> Unit { get; set; } = new Dictionary<NoteType, NotesMonoLaneMeasureUnit>();
	}
}
