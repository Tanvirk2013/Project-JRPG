﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scriptQuestMB : MonoBehaviour
{
    // Get reference to non-MB 
    public scriptQuest Quest
    {
        get;
        set;
    }

    public void OnClick()
    {
        scriptQuestManager._questManager.ShowDescription(Quest);
        GetComponent<TMP_Text>().color = Color.yellow;
    }

    public void OnDeselect()
    {
        GetComponent<TMP_Text>().color = Color.white;
    }

    public bool EvaluateAllObjectives()
    {
        return Quest.ObjectivesComplete;
    }
}
