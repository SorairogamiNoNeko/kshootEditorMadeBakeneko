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
		/// エディタで表示される index 本目が何小節目の何拍から始まるか
		/// </summary>
		public List<Tuple<int, int>> StartMeasures { get; set; } = new List<Tuple<int, int>>();
		/// <summary>
		/// エディタで表示される index 本目の長さ
		/// </summary>
		public List<int> LaneHeight { get; set; } = new List<int>();

		public EachLaneStartMeasure()
		{
			StartMeasures.Add(new Tuple<int, int>(1, 1));
		}

		public EachLaneStartMeasure(in MeasureControl ctr, in int height, in int finalObjMeasure, ref EachMeasurePosition measurePos)
		{
			SetLanePos(ctr, height, finalObjMeasure, ref measurePos);
		}

		public void SetLanePos(in MeasureControl ctr, in int height, in int finalObjMeasure, ref EachMeasurePosition measurePos)
		{
			int after_end_count = 0;
			int current_measure = 1;
			int current_denominator = 4;
			int current_numerator = 4;
			int current_lane = 1;

			bool inf_loop_guard = false;
			int guard_count = 0;

			StartMeasures.Clear();
			measurePos.Positions.Clear();
			LaneHeight.Clear();

			while (after_end_count < 10)
			{
				if (current_measure > finalObjMeasure)
				{
					after_end_count++;
				}

				StartMeasures.Add(new Tuple<int, int>(current_measure, current_denominator));

				TimeSignatureChangeData measure_data = ctr.GetChangeDataByMeasure(current_measure);
				int remining_height = height;
				int measure_height = (int)(BaseDefines.BaseMeasureHeight * ((double)measure_data.GetDenominator() / measure_data.GetNumerator()));

				while (remining_height - measure_height > 0)
				{
					measurePos.Positions.Add(new List<Tuple<int, int>>());

					for (int i = 0; i < measure_data.GetDenominator(); i++)
					{
						measurePos.Positions[current_measure - 1].Add(
							new Tuple<int, int>(
								current_lane,
							remining_height - (int)Math.Ceiling(BaseDefines.BaseMeasureHeight * ((double)i / measure_data.GetNumerator()))
							)
							);
						inf_loop_guard = true;
					}

					remining_height -= measure_height;
					current_measure++;
					measure_data = ctr.GetChangeDataByMeasure(current_measure);
					measure_height = (int)(BaseDefines.BaseMeasureHeight * ((double)measure_data.GetDenominator() / measure_data.GetNumerator()));
				}

				if (inf_loop_guard == true)
				{
					inf_loop_guard = false;
				}
				else
				{
					guard_count++;
					if (guard_count > 3)
					{
						System.Windows.Forms.MessageBox.Show("無限ループに陥る可能性があるため、ガードされました", "Inf loog guard", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						throw new System.TimeoutException("無限ループに陥る可能性があるため、ガードされました");
					}
				}

				LaneHeight.Add(height - remining_height);

				current_lane++;
			}
		}
	}
}
