using TalkGame;
using TalkGame.GameObjects;

namespace TalkGameTest;

public class GameProgress_ChoisesCommitedTest
{
    [Fact]
    public void ChoisesCommitedFormatString()
    {
        var imputList = new List<PlayerAction>()
        {
            new PlayerAction(1, new List<int>() { 1 }, "Du"),
            new PlayerAction(2, new List<int>() { 1 }, "Har"),
            new PlayerAction(3, new List<int>() { 1,2 }, "Get"),
        };
        var result = GameProgress.ChoisesCommited(imputList);
        
        Assert.Equal("Du Har Get", result);
    }
}