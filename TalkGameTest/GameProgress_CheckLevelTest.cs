using TalkGame;
using TalkGame.GameObjects;

namespace TalkGameTest;

public class GameProgress_CheckLevelTest
{
    
    [Fact]
    public void CheckLevelReturnHighestLevel_Return1()
    {
        var imputList = new List<PlayerAction>()
        {
            new PlayerAction(1, new List<int>() { 1 }, "Du"),
            new PlayerAction(2, new List<int>() { 1 }, "Har"),
            new PlayerAction(3, new List<int>() { 1 }, "Get"),
        };
        var result = GameProgress.CheckLevel(imputList);
        
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void CheckLevelReturnHighestLevel_Return2()
    {
        var imputList = new List<PlayerAction>()
        {
            new PlayerAction(1, new List<int>() { 1 }, "Du"),
            new PlayerAction(2, new List<int>() { 1 }, "Har"),
            new PlayerAction(3, new List<int>() { 1,2 }, "Get"),
        };
        var result = GameProgress.CheckLevel(imputList);
        
        Assert.Equal(2, result);
    }
}