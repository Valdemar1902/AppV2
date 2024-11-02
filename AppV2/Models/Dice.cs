namespace AppV2.Models;

public class Dice
{
    private Random _random = new Random();
    public int Value { get; set; }
    
    public void Roll()
    {
        Value = _random.Next(1, 7);
    }
}