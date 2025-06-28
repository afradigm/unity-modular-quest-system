using UnityEngine;

[CreateAssetMenu]
public class QuestData : ScriptableObject
{
    public long id;
    public string description;
    public Objective[] objectives;
}
