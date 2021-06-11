using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	/// <summary>
	/// 拍子が変更される小節数と、その拍子を表すデータ
	/// </summary>
	class TimeSignatureChangeData
	{
		private int _measure;      // 拍子が変わる小節数
		private int _denominator;  // 拍子の分子
		private int _numerator;	// 拍子の分母

		public TimeSignatureChangeData(int meas, int deno, int nume)
		{
			_measure = meas;
			_denominator = deno;
			_numerator = nume;
		}

		public int GetMeasure()
		{
			return _measure;
		}

		public int GetDenominator()
		{
			return _denominator;
		}

		public int GetNumerator()
		{
			return _numerator;
		}
	}
}
