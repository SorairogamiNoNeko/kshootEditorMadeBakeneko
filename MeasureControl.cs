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
		public List<TimeSignatureChangeData> Changes { get; set; } = new List<TimeSignatureChangeData>();

		public MeasureControl()
		{
			Changes.Add(new TimeSignatureChangeData(1, 4, 4));
		}

		public int GetNumeratorByMeasure(int measure)
		{
			TimeSignatureChangeData last_change_measure = Changes.Last();

			if (last_change_measure.GetMeasure() < measure)
			{
				return last_change_measure.GetMeasure();
			}
			else
			{
				int index = Changes.Count - 1;

				while(index > 0)
				{
					--index;

					TimeSignatureChangeData current_data = Changes[index];
					if (current_data.GetMeasure() <= measure)
					{
						return current_data.GetNumerator();
					}
				}
			}

			// エラー時の処理
			throw new System.ArgumentOutOfRangeException("measure", "引数の値が許容範囲外です");
		}

		public TimeSignatureChangeData GetChangeDataByMeasure(int measure)
		{
			TimeSignatureChangeData last_change_measure = Changes.Last();

			if (last_change_measure.GetMeasure() <= measure)
			{
				return last_change_measure;
			}
			else
			{
				int index = Changes.Count - 1;

				while (index > 0)
				{
					--index;

					TimeSignatureChangeData current_data = Changes[index];
					if (current_data.GetMeasure() <= measure)
					{
						return current_data;
					}
				}
			}

			// エラー時の処理
			throw new System.ArgumentOutOfRangeException("measure", "引数の値が許容範囲外です");
		}
	}
}
