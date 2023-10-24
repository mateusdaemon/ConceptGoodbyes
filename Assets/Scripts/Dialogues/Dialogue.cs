using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Dialogue
{
    private static bool dialogueEnable = false;
    private static bool isDialoguing = false;
    private static int numberOfPhrases;
    private static int phraseIndex;
    private static GameObject currentNpc;
    private static List<DialNode> allNodes;
    private static Sprite playerProfile;
    private static Sprite npcProfile;
    private static string npcName;

    public static void SetDialogueEnabled(bool enabled)
    {
        dialogueEnable = enabled;
    }

    public static bool GetDialogueEnabled()
    {
        return dialogueEnable;
    }

    public static bool GetIsDialoguing()
    {
        return isDialoguing;
    }
    public static void SetIsDialoguing(bool dialoguing)
    {
        isDialoguing = dialoguing;
    }

    public static void SetPhraseIndex(int index)
    {
        phraseIndex = index;
    }
    public static void IncrementPhraseIndex()
    {
        phraseIndex++;
    }

    public static void SetNumberPhrases(int number)
    {
        numberOfPhrases = number;
    }

    public static int GetPhraseIndex()
    {
        return phraseIndex;
    }

    public static int GetNumberPhrases()
    {
        return numberOfPhrases;
    }

    public static void SetCurrentNpc(GameObject npc)
    {
        currentNpc = npc;
    }
    public static GameObject GetCurrentNpc()
    {
        return currentNpc;
    }

    public static void CreateTree(string[] npcTexts, string[] playerOpt1, string[] playerOpt2, string npcName)
    {
        //allNodes = new List<DialNode>();

        //int indexLeaf = (npcTexts.Length - 1) / 2;

        //for (int i = 0; i < npcTexts.Length; i++)
        //{
        //    DialNode node = new DialNode();
        //    node.npcName = npcName;
        //    node.npcText = npcTexts[i];
        //    node.playerOpt_1 = playerOpt1[i];
        //    node.playerOpt_2 = playerOpt2[i];

        //    allNodes.Add(node);
        //}

        //int incLeft = 1;
        //int incRight = 2;

        //for (int j = 0; j < allNodes.Count; j++)
        //{
        //    if (j >= indexLeaf)
        //    {
        //        allNodes[j].isLeaf = true;
        //        continue;
        //    }

        //    allNodes[j].left = allNodes[j + incLeft];
        //    allNodes[j].right = allNodes[j + incRight];

        //    incLeft++;
        //    incRight++;
        //}
    }

    public static List<DialNode> GetAllNodes()
    {
        return allNodes;
    }

    public static void SetAllNodes(List<DialNode> nodes)
    {
        allNodes = nodes;
    }

    public static void SetDialogueProfiles(Sprite npcProfilePic, Sprite playerProfilePic)
    {
        npcProfile = npcProfilePic;
        playerProfile = playerProfilePic;
    }

    public static Sprite GetNpcProfile()
    {
        return npcProfile;
    }

    public static Sprite GetPlayerProfile()
    {
        return playerProfile;
    }

    public static void SetNpcName(string name)
    {
        npcName = name;
    }
    
    public static string GetNpcName()
    {
        return npcName;
    }
}
