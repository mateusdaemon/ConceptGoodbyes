using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrashManager : MonoBehaviour
{
    public GameObject interactPlastic;
    public GameObject interactPaper;
    public GameObject interactMetal;
    public GameObject interactGlass;
    private bool interactFree = false;
    public NpcBehavior npc;
    private GameObject currentThrash = null;
    public int thrashTook = 0;
    public DialogueManager dialManager;
    private bool thrashQuestComplete = false;
    public TakeTheThrash tkThrash;
    public GameObject changeLevel;
    private bool backOcean = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!thrashQuestComplete)
        {
            if (npc.GetTalked() && !interactFree)
            {
                interactPlastic.SetActive(true);
                interactPaper.SetActive(true);
                interactMetal.SetActive(true);
                interactGlass.SetActive(true);
                interactFree = true;
            }
        
            if (thrashTook >= 4)
            {
                npc.SetTalked(false);
                npc.SetGoodbye(false);
                dialManager.SetLastDialNode(new DialNode());
                thrashQuestComplete=true;
                tkThrash.CreateSecondaryDialogue();
            }
        }

        if (thrashQuestComplete && !backOcean)
        {
            if (npc.GetGoodbye())
            {
                changeLevel.SetActive(true);
                backOcean = true;
            }
        }


    }

    public void SetCurrentThrash(GameObject thrash)
    {
        currentThrash = thrash;
    }

    public GameObject GetCurrentThrash()
    {
        return currentThrash;
    }
}
