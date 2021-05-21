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
		private Point _scoreMargin = new Point(5, 10);
		private Point _scorePadding = new Point(35, 0);
		private int _verticalBarValue = 3;
		private int _laneLength;    // ParameterInitialize
		private int _monoLaneWidth = 10;
		private int _testDrawTimes = 8;
		private int _ScoreInterval; // ParameterInitialize

		/// <summary>
		/// フィールド初期化子で初期化できないパラメータに値を設定
		/// </summary>
		partial void ParameterInitialize()
		{
			_laneLength = 192 * _verticalBarValue;
			_ScoreInterval = _scoreMargin.X * 2 + _scorePadding.X * 2 + _monoLaneWidth * 4;
		}

		/// <summary>
		/// 譜面の下地を描画するメソッド
		/// </summary>
		private void DrawScoreBase()
		{
			for (int i = 0; i < _testDrawTimes; i++)
			{
				DrawMonoScoreBase(_scoreMargin.X + _ScoreInterval * i, _laneLength);
			}
		}

		private void DrawScoreBarLine(Point point, bool yellow = false)
		{

		}

		private void DrawMonoScoreBase(int posX, int length)
		{
			int start_y = mainBox.Size.Height - _scoreMargin.Y + _scorePadding.Y;

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
					start_y,
					posX + _scorePadding.X - _monoLaneWidth / 2,
					start_y - length);

			_mainBoxGrp.DrawLine(
					_redLazerBackgroundPen,
					posX + _scorePadding.X + _monoLaneWidth * 4.5f,
					start_y,
					posX + _scorePadding.X + _monoLaneWidth * 4.5f,
					start_y - length);


		}
	}
}
