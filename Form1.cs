using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kshootEditorMadeBakeneko
{
	public partial class Form1 : Form
	{
		private Bitmap _mainBoxBmp;
		private Graphics _mainBoxGrp;
		private Pen _selectionAreaPen;
		private bool _isMouseDown = false;
		private Point _startPoint;
		private Point _endPoint;

		partial void ParameterInitialize();

		public Form1()
		{
			InitializeComponent();

			/* イベントデリゲートの追加 */
			mainBox.MouseDown += MainBox_MouseDown;
			mainBox.MouseMove += MainBox_MouseMove;
			mainBox.MouseUp += MainBox_MouseUp;

			ParameterInitialize();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			_mainBoxBmp = new Bitmap(mainBox.Size.Width, mainBox.Size.Height);
			mainBox.Image = _mainBoxBmp;

			_mainBoxGrp = Graphics.FromImage(mainBox.Image);
			_selectionAreaPen = new Pen(Brushes.LightGray);

			DrawScoreBase();

			mainBox.Refresh();
		}

		private void MainBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button != MouseButtons.Left)
			{
				return;
			}
			_isMouseDown = true;
			_startPoint = PointToClient(Point.Subtract(Cursor.Position, new Size(mainBox.Location)));

			_mainBoxGrp.Clear(mainBox.BackColor);
			DrawScoreBase();
			mainBox.Refresh();
		}

		private void MainBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (_isMouseDown)
			{
				_mainBoxGrp.Clear(mainBox.BackColor);

				DrawScoreBase();

				Point current_point = PointToClient(Point.Subtract(Cursor.Position, new Size(mainBox.Location)));

				float rect_left = Math.Min(_startPoint.X, current_point.X);
				float rect_top = Math.Min(_startPoint.Y, current_point.Y);
				_mainBoxGrp.DrawRectangle(_selectionAreaPen, rect_left, rect_top, Math.Abs(current_point.X - _startPoint.X), Math.Abs(current_point.Y - _startPoint.Y));

				mainBox.Refresh();
			}
		}

		private void MainBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			_isMouseDown = false;
			_endPoint = PointToClient(Cursor.Position);

			_mainBoxGrp.Clear(mainBox.BackColor);

			DrawScoreBase();

			Point current_point = PointToClient(Cursor.Position);
			float rect_left = Math.Min(_startPoint.X, _endPoint.X);
			float rect_top = Math.Min(_startPoint.Y, _endPoint.Y);

			mainBox.Refresh();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void 選択範囲の傾きをコピーIToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void すべてのToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
