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
		private List<BeatChangeData> Changes { get; set; } = new List<BeatChangeData>();

		public MeasureControl()
		{
			Changes.Add(new BeatChangeData(1, 4, 4));
		}
	}
}
