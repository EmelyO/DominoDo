using DominoDO.Model;


namespace DominoDO.ViewModel
{
    public class ScoreViewModel
    {
        private readonly Action<ScoreTemp> _onScore;
        public ScoreViewModel(Action<ScoreTemp> onScore)
        {
            _onScore = onScore;
        }
    }
}
