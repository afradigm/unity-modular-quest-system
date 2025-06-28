using System;
using UnityEngine;

public class Quest 
{
    public event Action<Quest> OnQuestCompleted;

    public void Complete()
    {
        OnQuestCompleted?.Invoke(this);
    }
}
