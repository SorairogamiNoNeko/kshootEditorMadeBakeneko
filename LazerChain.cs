using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kshootEditorMadeBakeneko
{
	class LazerChain
	{
		private List<LazerPoint> _lazerPoints;

		public List<LazerPoint> LazerPoints { get => _lazerPoints; set => _lazerPoints = value; }
	}
}
