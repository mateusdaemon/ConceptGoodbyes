using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialNode
{
    public GameObject npc;
    public string npcName;
    public string npcText;
    public string playerOpt_1;
    public string playerOpt_2;
    public bool isLeaf;

    public DialNode right;
    public DialNode left;

    public bool goodbye = false;
    public bool acceptQuest = false;
}
