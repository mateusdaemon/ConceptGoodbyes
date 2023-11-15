using System.Collections.Generic;
using UnityEngine;

public class CleanOceanDial : MonoBehaviour
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
        node1.playerOpt_1 = playerOptions[0];
        node1.playerOpt_2 = "";
        node1.left = node2;
        node1.right = null;
        node1.isLeaf = false;
        dialTree.Add(node1);

        node2.npc = this.gameObject;
        node2.npcText = npcOptions[2];
        node2.playerOpt_1 = "";
        node2.playerOpt_2 = "";
        node2.left = node3;
        node2.right = null;
        node2.isLeaf = false;
        dialTree.Add(node2);

        node3.npc = this.gameObject;
        node3.npcText = npcOptions[3];
        node3.playerOpt_1 = playerOptions[1];
        node3.playerOpt_2 = playerOptions[2];
        node3.left = node4;
        node3.right = node6;
        node3.isLeaf = false;
        dialTree.Add(node3);

        node4.npc = this.gameObject;
        node4.npcText = npcOptions[4];
        node4.playerOpt_1 = "";
        node4.playerOpt_2 = "";
        node4.left = node5;
        node4.right = null;
        node4.isLeaf = false;
        dialTree.Add(node4);

        node5.npc = this.gameObject;
        node5.npcText = npcOptions[5];
        node5.playerOpt_1 = playerOptions[3];
        node5.playerOpt_2 = playerOptions[4];
        node5.left = null;
        node5.right = node6;
        node5.isLeaf = false;
        node5.acceptQuest = true;
        node5.goodbye = true;
        dialTree.Add(node5);

        node6.npc = this.gameObject;
        node6.npcText = npcOptions[6];
        node6.playerOpt_1 = playerOptions[5];
        node6.playerOpt_2 = "";
        node6.left = null;
        node6.right = null;
        node6.isLeaf = true;
        node6.goodbye = true;
        dialTree.Add(node6);
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
