public class Score
{
    public int _score;

    public Score(int score)
    {
        this._score = score;
    }
    public void Add(int addToScore)
    {
        this._score = _score + addToScore;
    }
}