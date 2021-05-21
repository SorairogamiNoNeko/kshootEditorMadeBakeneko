using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class NotesMonoLaneMeasureUnit
	{
		private List<NoteObjectBase> _monoLane = new List<NoteObjectBase>();

		public List<NoteObjectBase> MonoLane { get => _monoLane; set => _monoLane = value; }
	}
}
