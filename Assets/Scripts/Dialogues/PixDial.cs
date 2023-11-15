using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixDial : MonoBehaviour
{
    public string npcName;
    [TextArea(3, 10)]
    public string[] npcOptions;
    [TextArea(3, 10)]
    public string[] playerOptions;

    private List<DialNode> dialTree = new List<DialNode>();

    public Sprite npcSpritePic;
    public Sprite playerSpritePic;

    // Start is called before the first frame update
    void Start()
    {
        DialNode node0 = new DialNode();
        DialNode node1 = new DialNode();
        DialNode node2 = new DialNode();
        DialNode node3 = new DialNode();
        DialNode node4 = new DialNode();
        DialNode node5 = new DialNode();
        DialNode node6 = new DialNode();
        DialNode node7 = new DialNode();
        DialNode node8 = new DialNode();
        DialNode node9 = new DialNode();
        DialNode node10 = new DialNode();
        DialNode node11 = new DialNode();
        DialNode node12 = new DialNode();
        DialNode node13 = new DialNode();

        node0.npc = this.gameObject;
        node0.npcText = npcOptions[0];
        node0.playerOpt_1 = playerOptions[0];
        node0.playerOpt_2 = playerOptions[1];
        node0.left = node1;
        node0.right = node1;
        node0.isLeaf = false;
        dialTree.Add(node0);

        node1.npc = this.gameObject;
        node1.npcText = npcOptions[1];
        node1.playerOpt_1 = "";
        node1.playerOpt_2 = "";
        node1.left = node2;
        node1.right = null;
        node1.isLeaf = false;
        dialTree.Add(node1);

        node2.npc = this.gameObject;
        node2.npcText = npcOptions[2];
        node2.playerOpt_1 = playerOptions[2];
        node2.playerOpt_2 = playerOptions[3];
        node2.left = node3;
        node2.right = node4;
        node2.isLeaf = false;
        dialTree.Add(node2);

        node3.npc = this.gameObject;
        node3.npcText = npcOptions[3];
        node3.playerOpt_1 = playerOptions[4];
        node3.playerOpt_2 = "";
        node3.left = node5;
        node3.right = null;
        node3.isLeaf = false;
        dialTree.Add(node3);

        node4.npc = this.gameObject;
        node4.npcText = npcOptions[4];
        node4.playerOpt_1 = playerOptions[5];
        node4.playerOpt_2 = "";
        node4.left = null;
        node4.right = null;
        node4.isLeaf = true;
        node4.goodbye = true;
        dialTree.Add(node4);

        node5.npc = this.gameObject;
        node5.npcText = npcOptions[5];
        node5.playerOpt_1 = "";
        node5.playerOpt_2 = "";
        node5.left = node6;
        node5.right = null;
        node5.isLeaf = false;
        dialTree.Add(node5);

        node6.npc = this.gameObject;
        node6.npcText = npcOptions[6];
        node6.playerOpt_1 = "";
        node6.playerOpt_2 = "";
        node6.left = node7;
        node6.right = null;
        node6.isLeaf = false;
        dialTree.Add(node6);

        node7.npc = this.gameObject;
        node7.npcText = npcOptions[7];
        node7.playerOpt_1 = "";
        node7.playerOpt_2 = "";
        node7.left = node8;
        node7.right = null;
        node7.isLeaf = true;
        node7.goodbye = true;
        dialTree.Add(node7);

        node8.npc = this.gameObject;
        node8.npcText = npcOptions[8];
        node8.playerOpt_1 = "";
        node8.playerOpt_2 = "";
        node8.left = node9;
        node8.right = null;
        node8.isLeaf = false;
        dialTree.Add(node8);

        node9.npc = this.gameObject;
        node9.npcText = npcOptions[9];
        node9.playerOpt_1 = "";
        node9.playerOpt_2 = "";
        node9.left = node10;
        node9.right = null;
        node9.isLeaf = false;
        dialTree.Add(node9);

        node10.npc = this.gameObject;
        node10.npcText = npcOptions[10];
        node10.playerOpt_1 = playerOptions[6];
        node10.playerOpt_2 = playerOptions[7];
        node10.left = node11;
        node10.right = node12;
        node10.isLeaf = false;
        dialTree.Add(node10);

        node11.npc = this.gameObject;
        node11.npcText = npcOptions[11];
        node11.playerOpt_1 = playerOptions[8];
        node11.playerOpt_2 = playerOptions[9];
        node11.left = null;
        node11.right = node13;
        node11.isLeaf = false;
        node11.goodbye = true;
        dialTree.Add(node11);

        node12.npc = this.gameObject;
        node12.npcText = npcOptions[12];
        node12.playerOpt_1 = playerOptions[5];
        node12.playerOpt_2 = "";
        node12.left = null;
        node12.right = null;
        node12.isLeaf = false;
        node12.goodbye = true;
        dialTree.Add(node12);

        node13.npc = this.gameObject;
        node13.npcText = npcOptions[13];
        node13.playerOpt_1 = playerOptions[10];
        node13.playerOpt_2 = "";
        node13.left = null;
        node13.right = null;
        node13.isLeaf = true;
        dialTree.Add(node13);
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
