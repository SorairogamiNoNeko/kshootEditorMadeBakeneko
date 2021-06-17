using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kshootEditorMadeBakeneko
{
	partial class Form1
	{
		// 譜面の縦の線
		private Pen _scoreBasePen = new Pen(Color.FromArgb(128, 128, 128), 1);
		// レーザー赤青の背景
		private Pen _blueLazerBackgroundPen = new Pen(Color.FromArgb(0, 48, 48), 9);
		private Pen _redLazerBackgroundPen = new Pen(Color.FromArgb(60, 0, 60), 9);
		// 小節線
		private Pen _scoreBarLinePen = new Pen(Color.FromArgb(64, 64, 64), 1);
		private Pen _scoreYellowBarLinePen = new Pen(Color.FromArgb(255, 255, 0), 1);

		private Point _scoreMargin = new Point(5, 10);
		private Point _scorePadding = new Point(35, 0);
		private int _laneLength;    // ParameterInitialize
		private int _monoLaneWidth = 10;
		private int _testDrawTimes = 8;
		private int _scoreInterval; // ParameterInitialize

		/// <summary>
		/// フィールド初期化子で初期化できないパラメータに値を設定
		/// </summary>
		partial void BaseParameterInitialize()
		{
			_laneLength = mainBox.Size.Height - _scoreMargin.Y * 2 - _scorePadding.Y * 2;
			_scoreInterval = _scoreMargin.X * 2 + _scorePadding.X * 2 + _monoLaneWidth * 4;
		}

		/// <summary>
		/// 譜面の下地を描画するメソッド
		/// </summary>
		private void DrawScoreBase()
		{
			_startMeasure.SetLanePos(_measureCtr, mainBox.Height - _scoreMargin.Y * 2 - _scorePadding.Y * 2, _measureCtr.Changes.Last().GetMeasure(), ref _lanePos);

			for (int i = 0; i < _testDrawTimes; i++)
			{
				DrawMonoScoreBase(_scoreMargin.X + _scoreInterval * i, _startMeasure.LaneHeight[i]);
			}


			List<List<Tuple<int, int>>> all_pos = _lanePos.Positions;
			for(int i = 0; i < all_pos.Count; i++)
			{
				List<Tuple<int, int>> meas = all_pos[i];
				for(int j = 0; j < meas.Count; j++)
				{
					DrawScoreBarLine(meas[j], j == 0);
				}
			}
		}

		private void DrawMonoScoreBase(int posX, int length)
		{
			int start_y = mainBox.Size.Height - _scoreMargin.Y - _scorePadding.Y;

			for (int i = 0; i < 5; i++)
			{
				_mainBoxGrp.DrawLine(
					_scoreBasePen,
					posX + _scorePadding.X + _monoLaneWidth * i,
					start_y,
					posX + _scorePadding.X + _monoLaneWidth * i,
					start_y - length);
			}

			_mainBoxGrp.DrawLine(
					_blueLazerBackgroundPen,
					posX + _scorePadding.X - _monoLaneWidth / 2,
					start_y + 1,
					posX + _scorePadding.X - _monoLaneWidth / 2,
					start_y - length);

			_mainBoxGrp.DrawLine(
					_redLazerBackgroundPen,
					posX + _scorePadding.X + _monoLaneWidth * 4.5f,
					start_y + 1,
					posX + _scorePadding.X + _monoLaneWidth * 4.5f,
					start_y - length);


		}

		/// <summary>
		/// 小節線、拍線を描画するメソッド
		/// </summary>
		/// <param name="pos">Item1 何番目のレーンか<br/>Item2 縦の位置</param>
		/// <param name="yellow">小節線か</param>
		private void DrawScoreBarLine(in Tuple<int, int> pos, bool yellow)
		{
			int start_point_x = _scoreMargin.X + _scorePadding.X - 10 + _scoreInterval * (pos.Item1 - 1);
			int end_point_x = start_point_x + _monoLaneWidth * 6;
			int point_y = pos.Item2 + _scoreMargin.Y + _scorePadding.Y;

			Pen using_pen;
			if(yellow == true)
			{
				using_pen = _scoreYellowBarLinePen;
			}
			else
			{
				using_pen = _scoreBarLinePen;
			}

			_mainBoxGrp.DrawLine(
				using_pen,
				start_point_x,
				point_y,
				end_point_x,
				point_y);
		}
	}
}
