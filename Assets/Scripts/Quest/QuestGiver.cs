using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    [SerializeField]
    private Quest[] quests;

    //Debugging
    [SerializeField]
    private QuestLog tmpLog;

    private void Awake()
    {
        // Here we need to accept a quest;
    }
}
