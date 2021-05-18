using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	/// <summary>
	/// 拍子の変更を管理するクラス
	/// </summary>
	class MeasureControl
	{
		private List<BeatChangeData> _changes = new List<BeatChangeData>();

		public List<BeatChangeData> Changes { get => _changes; set => _changes = value; }

		MeasureControl()
		{
			Changes.Add(new BeatChangeData(0, 4, 4));
		}
	}
}
