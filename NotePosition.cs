using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class NotePosition : NoteObjectBase
	{
		private uint _measure;		// ノートのある小節
		/* その表紙の _numerator 分割した _denominator 番目のところにノートがある */
		private uint _denominator;
		private uint _numerator;
	}
}
