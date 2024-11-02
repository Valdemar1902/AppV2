namespace AppV2.Models;

public class DiceCup
{
    private List<Dice> _dices;

    public DiceCup (int numberOfDices = 2)
    {
        _dices = Enumerable.Range(0, numberOfDices).Select(_ => new Dice()).ToList();
    }

    public void Roll()
    {
        foreach (var dice in _dices)
        {
            dice.Roll();
        }
    }
    public IEnumerable<int> GetValues()
    {
        return _dices.Select(d => d.Value);
    }

    public void SetNumberOfDices(int number)
    {
        _dices = Enumerable.Range(0, number).Select(_ => new Dice()).ToList();
    }

}