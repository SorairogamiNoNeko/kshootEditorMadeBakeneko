using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class EachLaneStartMeasure
	{
		/// <summary>
		/// index 本目が何小節目の何拍から始まるか
		/// </summary>
		public List<Tuple<int, int>> StartMeasures { get; set; } = new List<Tuple<int, int>>();

		public EachLaneStartMeasure()
		{
			StartMeasures.Add(new Tuple<int , int>(1, 1));
		}

		public EachLaneStartMeasure(MeasureControl ctr)
		{

		}
	}
}
