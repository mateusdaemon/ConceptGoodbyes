using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBehavior : MonoBehaviour
{
    private bool goodbye;
    private bool acceptQuest;
    private bool talked = false;
    public GameObject check;
    public GameObject interrogation;
    public DialogueManager dialManager;

    public bool GetAcceptQuest()
    {
        return acceptQuest;
    }

    public bool GetGoodbye()
    {
        return goodbye;
    }

    public bool GetTalked()
    {
        return talked;
    }

    public void SetAcceptQuest(bool accept)
    {
        acceptQuest = accept;
    }

    public void SetGoodbye(bool bye)
    {
        goodbye = bye;
    }

    public void SetTalked(bool talk)
    {
        talked = talk;
    }

    public void Update()
    {
        if (!talked)
        {
            if (dialManager.GetLastDialNode() != null && dialManager.GetLastDialNode().npc == this.gameObject)
            {
                goodbye = dialManager.GetLastDialNode().goodbye;
                acceptQuest = dialManager.GetLastDialNode().acceptQuest;
            }

            if (goodbye)
            {
                check.SetActive(true);
                interrogation.SetActive(false);
                talked = true;

            }
            else
            {
                interrogation.SetActive(true);
            }
        }
    }
}
