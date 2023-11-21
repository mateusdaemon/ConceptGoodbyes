using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinsDialogue : MonoBehaviour
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
        DialNode node14 = new DialNode();
        DialNode node15 = new DialNode();
        DialNode node16 = new DialNode();
        DialNode node17 = new DialNode();
        DialNode node18 = new DialNode();
        DialNode node19 = new DialNode();
        DialNode node20 = new DialNode();
        DialNode node21 = new DialNode();

        node0.npc = this.gameObject;
        node0.npcText = npcOptions[0];
        node0.playerOpt_1 = "";
        node0.playerOpt_2 = "";
        node0.left = node1;
        node0.right = null;
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
        node2.playerOpt_1 = playerOptions[0];
        node2.playerOpt_2 = playerOptions[1];
        node2.left = node3;
        node2.right = node4;
        node2.isLeaf = false;
        dialTree.Add(node2);

        node3.npc = this.gameObject;
        node3.npcText = npcOptions[3];
        node3.playerOpt_1 = playerOptions[3];
        node3.playerOpt_2 = "";
        node3.left = node5;
        node3.right = null;
        node3.isLeaf = false;
        dialTree.Add(node3);

        node4.npc = this.gameObject;
        node4.npcText = npcOptions[4];
        node4.playerOpt_1 = playerOptions[2];
        node4.playerOpt_2 = "";
        node4.left = null;
        node4.right = null;
        node4.isLeaf = true;
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
        node7.isLeaf = false;
        dialTree.Add(node7);

        node8.npc = this.gameObject;
        node8.npcText = npcOptions[8];
        node8.playerOpt_1 = playerOptions[4];
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
        node10.playerOpt_1 = "";
        node10.playerOpt_2 = "";
        node10.left = node11;
        node10.right = null;
        node10.isLeaf = false;
        dialTree.Add(node10);

        node11.npc = this.gameObject;
        node11.npcText = npcOptions[11];
        node11.playerOpt_1 = "";
        node11.playerOpt_2 = "";
        node11.left = node12;
        node11.right = null;
        node11.isLeaf = false;
        dialTree.Add(node11);

        node12.npc = this.gameObject;
        node12.npcText = npcOptions[12];
        node12.playerOpt_1 = "";
        node12.playerOpt_2 = "";
        node12.left = node13;
        node12.right = null;
        node12.isLeaf = false;
        dialTree.Add(node12);

        node13.npc = this.gameObject;
        node13.npcText = npcOptions[13];
        node13.playerOpt_1 = "";
        node13.playerOpt_2 = "";
        node13.left = node14;
        node13.right = null;
        node13.isLeaf = false;
        dialTree.Add(node13);

        node14.npc = this.gameObject;
        node14.npcText = npcOptions[14];
        node14.playerOpt_1 = "";
        node14.playerOpt_2 = "";
        node14.left = node15;
        node14.right = null;
        node14.isLeaf = false;
        dialTree.Add(node14);

        node15.npc = this.gameObject;
        node15.npcText = npcOptions[15];
        node15.playerOpt_1 = "";
        node15.playerOpt_2 = "";
        node15.left = node16;
        node15.right = null;
        node15.isLeaf = false;
        dialTree.Add(node15);

        node16.npc = this.gameObject;
        node16.npcText = npcOptions[16];
        node16.playerOpt_1 = "";
        node16.playerOpt_2 = "";
        node16.left = node17;
        node16.right = null;
        node16.isLeaf = false;
        dialTree.Add(node16);

        node17.npc = this.gameObject;
        node17.npcText = npcOptions[17];
        node17.playerOpt_1 = "";
        node17.playerOpt_2 = "";
        node17.left = node18;
        node17.right = null;
        node17.isLeaf = false;
        dialTree.Add(node17);

        node18.npc = this.gameObject;
        node18.npcText = npcOptions[18];
        node18.playerOpt_1 = "";
        node18.playerOpt_2 = "";
        node18.left = node19;
        node18.right = null;
        node18.isLeaf = false;
        dialTree.Add(node18);

        node19.npc = this.gameObject;
        node19.npcText = npcOptions[19];
        node19.playerOpt_1 = "";
        node19.playerOpt_2 = "";
        node19.left = node20;
        node19.right = null;
        node19.isLeaf = false;
        dialTree.Add(node19);

        node20.npc = this.gameObject;
        node20.npcText = npcOptions[20];
        node20.playerOpt_1 = "";
        node20.playerOpt_2 = "";
        node20.left = node21;
        node20.right = null;
        node20.isLeaf = false;
        dialTree.Add(node20);

        node21.npc = this.gameObject;
        node21.npcText = npcOptions[21];
        node21.playerOpt_1 = playerOptions[5];
        node21.playerOpt_2 = "";
        node21.left = null;
        node21.right = null;
        node21.isLeaf = true;
        node21.goodbye = true;
        dialTree.Add(node21);

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
