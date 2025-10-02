namespace TalkGame.GameObjects;

public class PlayerAction
{
    public PlayerAction()
    {
    }
    public PlayerAction(int id, List<int> levels, string text)
    {
        Id = id;
        Levels = levels;
        Text = text;
    }

    public int Id { get; set; }
    public string Text { get; set; }
    public List<int> Levels { get; set; }
}