using DominoDO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoDO.ViewModel
{
    public class ScoreViewModel
    {
        private readonly Action<ScoreTemp> _onScore;
        public ScoreViewModel(Page page, Action<ScoreTemp> onScore)
        {
            _onScore = onScore;
        }
    }
}
