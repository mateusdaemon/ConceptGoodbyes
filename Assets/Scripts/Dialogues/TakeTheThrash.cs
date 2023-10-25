using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeTheThrash : MonoBehaviour
{
    public string npcName;
    [TextArea(3, 10)]
    public string[] npcOptions;
    [TextArea(3, 10)]
    public string[] playerOptions;

    [TextArea(3, 10)]
    public string[] npcOptions2;
    [TextArea(3, 10)]
    public string[] playerOptions2;

    private List<DialNode> dialTree = new List<DialNode>();

    public Sprite npcSpritePic;
    public Sprite playerSpritePic;

    // Start is called before the first frame update
    void Start()
    {
        DialNode node0 = new DialNode();
        DialNode node1 = new DialNode();

        node0.npc = this.gameObject;
        node0.npcText = npcOptions[0];
        node0.playerOpt_1 = playerOptions[0];
        node0.playerOpt_2 = "";
        node0.left = node1;
        node0.right = null;
        node0.isLeaf = false;
        dialTree.Add(node0);

        node1.npc = this.gameObject;
        node1.npcText = npcOptions[1];
        node1.playerOpt_1 = playerOptions[1];
        node1.playerOpt_2 = "";
        node1.left = null;
        node1.right = null;
        node1.isLeaf = true;
        node1.acceptQuest = true;
        node1.goodbye = true;
        dialTree.Add(node1);

    }

    public void CreateSecondaryDialogue()
    {
        List<DialNode> tree = new List<DialNode>();

        DialNode node0 = new DialNode();
        DialNode node1 = new DialNode();
        DialNode node2 = new DialNode();

        dialTree.Clear();

        node0.npc = this.gameObject;
        node0.npcText = npcOptions2[0];
        node0.playerOpt_1 = "";
        node0.playerOpt_2 = "";
        node0.left = node1;
        node0.right = null;
        node0.isLeaf = false;
        dialTree.Add(node0);

        node1.npc = this.gameObject;
        node1.npcText = npcOptions2[1];
        node1.playerOpt_1 = playerOptions2[0];
        node1.playerOpt_2 = playerOptions2[1];
        node1.left = null;
        node1.right = node2;
        node1.isLeaf = false;
        node1.goodbye = true;
        dialTree.Add(node1);

        node2.npc = this.gameObject;
        node2.npcText = npcOptions2[2];
        node2.playerOpt_1 = playerOptions2[2];
        node2.playerOpt_2 = "";
        node2.left = null;
        node2.right = null;
        node2.isLeaf = true;
        node2.goodbye = true;
        dialTree.Add(node2);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject == Dialogue.GetCurrentNpc())
        {
            Dialogue.SetAllNodes(dialTree);
            Dialogue.SetNpcName(npcName);
            Dialogue.SetDialogueProfiles(npcSpritePic, playerSpritePic);
        }
    }
}
