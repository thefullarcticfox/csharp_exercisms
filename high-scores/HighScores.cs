using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int>  _scoreList;

    public HighScores(List<int> list) => _scoreList = list;

    public List<int> Scores() => _scoreList;

    public int Latest() => _scoreList.Last();

    public int PersonalBest() => _scoreList.Max();

    public List<int> PersonalTopThree() =>
        _scoreList.OrderByDescending(score => score).Take(3).ToList();
}
