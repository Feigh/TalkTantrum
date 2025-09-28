using TalkGame.GameObjects;

namespace TalkGame;

public class PlayerChoise
{
    public List<string> ProcessKey(ConsoleKeyInfo key, List<PlayerAction> toSelect, List<string> activwords)
    {
        if (int.TryParse(key.KeyChar.ToString(), out int rslt))
        {
            var result = toSelect.Where(x => x.Id == rslt);
            activwords.Add("");         
        }

        return activwords;
    }

    public List<string> ListNewWords()
    {
        return null;
    }

    public List<PlayerAction> PrintChoises(List<string> selectWord)
    {
        var result = selectWord.Select((w, index) =>
        {
            index++;
            return new PlayerAction() { Id = index, Text = string.Format("{0}. {1}", index.ToString(), w) };
        });

        return result.ToList();
        //result.ToList().ForEach(Console.WriteLine);
    }
}