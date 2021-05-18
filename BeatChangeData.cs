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
	class BeatChangeData
	{
		private uint _measure;      // 拍子が変わる小節数
		private uint _denominator;  // 拍子の分子
		private uint _numerator;	// 拍子の分母

		public BeatChangeData(uint meas, uint deno, uint nume)
		{
			_measure = meas;
			_denominator = deno;
			_numerator = nume;
		}
	}
}
