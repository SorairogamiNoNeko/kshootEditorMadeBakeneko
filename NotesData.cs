using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class NotesData
	{
		public List<List<NotePosition>> Bt { get; set; } = new List<List<NotePosition>>();
		public List<List<NotePosition>> Fx { get; set; } = new List<List<NotePosition>>();
		public List<List<LazerChain>> Lazer { get; set; } = new List<List<LazerChain>>();

		private Dictionary<int, Dictionary<Tuple<int, int>, NoteObjectBase>> _notesInfo = new Dictionary<int, Dictionary<Tuple<int, int>, NoteObjectBase>>();

		public NotesData()
		{
			_notesInfo[1] = 
		}
	}
}
