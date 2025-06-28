using System.Collections.Generic;
using System.Linq;

public class Objective : IQuestComponent
{
    private List<IQuestComponent> children;
    public bool IsCompleted => children.All(x => x.IsCompleted);
}
