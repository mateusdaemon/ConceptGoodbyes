using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Image npcPanelPic;
    public Image playerPanelPic;
    public Text npcName;
    public Text npcText;
    public Text playerOpt_1;
    public Text playerOpt_2;
    public GameObject dialPanel;
    public GameObject continuePanel;
    public GameObject opt1Interact;
    public GameObject opt2Interact;

    private List<DialNode> dialTree;
    private DialNode currentNode;
    private bool getFirstNode = true;

    public DialNode lastDialogueNode;



    private void Update()
    {
        if (!Dialogue.GetDialogueEnabled())
        {
            return;
        }
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!Dialogue.GetIsDialoguing())
            {
                dialPanel.SetActive(true);
                Dialogue.SetIsDialoguing(true);
            } else
            {
                dialPanel.SetActive(false);
                Dialogue.SetIsDialoguing(false);
                getFirstNode = true;
            }
        }

        if (Dialogue.GetIsDialoguing())
        {

            dialTree = Dialogue.GetAllNodes();

            if (getFirstNode)
            {
                currentNode = dialTree[0];
                getFirstNode = false;
            }

            npcName.text = Dialogue.GetNpcName();
            npcText.text = currentNode.npcText;
            playerOpt_1.text = currentNode.playerOpt_1;
            playerOpt_2.text = currentNode.playerOpt_2;
            npcPanelPic.sprite = Dialogue.GetNpcProfile();
            playerPanelPic.sprite = Dialogue.GetPlayerProfile();

            if (playerOpt_1.text == "")
            {
                opt1Interact.SetActive(false);
                continuePanel.SetActive(true);
            }
            else
            {
                opt1Interact.SetActive(true);
                continuePanel.SetActive(false);
            }

            if (playerOpt_2.text == "")
            {
                opt2Interact.SetActive(false);
            }
            else
            {
                opt2Interact.SetActive(true);
            }

            if (continuePanel.activeSelf && Input.GetKeyDown(KeyCode.C))
            {
                currentNode = currentNode.left;
                return;
            }


            if (currentNode.isLeaf && (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2)))
            {
                dialPanel.SetActive(false);
                Dialogue.SetIsDialoguing(false);
                getFirstNode = true;
                SetLastDialNode(currentNode);
                return;
            }

            if (Input.GetKeyDown(KeyCode.Alpha1) && playerOpt_1.text != "")
            {
                if (currentNode.left != null)
                {
                    currentNode = currentNode.left;
                } else
                {
                    dialPanel.SetActive(false);
                    Dialogue.SetIsDialoguing(false);
                    getFirstNode = true;
                    SetLastDialNode(currentNode);
                    return;
                }
            } else if (Input.GetKeyDown(KeyCode.Alpha2) && playerOpt_2.text != "")
            {
                if (currentNode.right != null)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    dialPanel.SetActive(false);
                    Dialogue.SetIsDialoguing(false);
                    getFirstNode = true;
                    SetLastDialNode(currentNode);
                    return;
                }
            }

        }
    }

    public void SetLastDialNode(DialNode node)
    {
        lastDialogueNode = node;
    }

    public DialNode GetLastDialNode()
    {
        return lastDialogueNode;
    }

}
