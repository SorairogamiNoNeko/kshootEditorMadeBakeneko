using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class NoteObjectBase
	{
		public enum NoteType
		{
			BtShort1,
			BtShort2,
			BtShort3,
			BtShort4,
			BtLongStart1,
			BtLongStart2,
			BtLongStart3,
			BtLongStart4,
			BtLongEnd1,
			BtLongEnd2,
			BtLongEnd3,
			BtLongEnd4,
			FxChip1,
			FxChip2,
			FxLongStart1,
			FxLongStart2,
			FxLongEnd1,
			FxLongEnd2,
			LaserStart1,
			LaserStart2,
			LaserMid1,
			LaserMid2,
			LaserEnd1,
			LaserEnd2
		}

		protected uint _measure;      // ノートのある小節
		/* その表紙の _numerator 分割した _denominator 番目のところにノートがある */
		protected uint _denominator;
		protected uint _numerator;
		// notetype (BtChip(1 ～ 4), BtLongStart(1 ～ 4), BtLongEnd(1 ～ 4),
		//	FxChip(1, 2), FxLong(1, 2), FxLongStart(1, 2), FxLongEnd(1, 2),
		//	LaserStart(1, 2), LaserMid(1, 2), LaserEnd(1, 2)
		protected NoteType _noteType;
	}
}
