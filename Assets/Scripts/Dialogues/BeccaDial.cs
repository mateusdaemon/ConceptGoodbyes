using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeccaDial : MonoBehaviour
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

        node0.npc = this.gameObject;
        node0.npcText = npcOptions[0];
        node0.playerOpt_1 = playerOptions[0];
        node0.playerOpt_2 = playerOptions[1];
        node0.left = node1;
        node0.right = null;
        node0.isLeaf = false;
        dialTree.Add(node0);

        node1.npc = this.gameObject;
        node1.npcText = npcOptions[1];
        node1.playerOpt_1 = playerOptions[2];
        node1.playerOpt_2 = "";
        node1.left = node2;
        node1.right = null;
        node1.isLeaf = false;
        dialTree.Add(node1);

        node2.npc = this.gameObject;
        node2.npcText = npcOptions[2];
        node2.playerOpt_1 = playerOptions[3];
        node2.playerOpt_2 = playerOptions[4];
        node2.left = node3;
        node2.right = null;
        node2.isLeaf = false;
        dialTree.Add(node2);

        node3.npc = this.gameObject;
        node3.npcText = npcOptions[3];
        node3.playerOpt_1 = playerOptions[5];
        node3.playerOpt_2 = playerOptions[6];
        node3.left = node4;
        node3.right = node5;
        node3.isLeaf = false;
        dialTree.Add(node3);

        node4.npc = this.gameObject;
        node4.npcText = npcOptions[4];
        node4.playerOpt_1 = "";
        node4.playerOpt_2 = "";
        node4.left = node6;
        node4.right = null;
        node4.isLeaf = false;
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
        node6.playerOpt_1 = playerOptions[7];
        node6.playerOpt_2 = playerOptions[8];
        node6.left = node7;
        node6.right = node7;
        node6.isLeaf = false;
        dialTree.Add(node6);

        node7.npc = this.gameObject;
        node7.npcText = npcOptions[7];
        node7.playerOpt_1 = playerOptions[9];
        node7.playerOpt_2 = "";
        node7.left = null;
        node7.right = null;
        node7.isLeaf = true;
        node7.goodbye = true;
        dialTree.Add(node7);

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
