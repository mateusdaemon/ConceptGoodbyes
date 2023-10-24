using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueListener : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject continueText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject != Dialogue.GetCurrentNpc())
        {
            return;
        }

        if (Dialogue.GetDialogueEnabled())
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!Dialogue.GetIsDialoguing())
                {
                    Dialogue.SetIsDialoguing(true);
                    Dialogue.SetPhraseIndex(0);
                    dialoguePanel.SetActive(true);
                } else
                {
                    dialoguePanel.SetActive(false);
                    Dialogue.SetIsDialoguing(false);
                    Dialogue.SetNumberPhrases(0);
                    Dialogue.SetPhraseIndex(0);
                }            
            }

            if (Dialogue.GetPhraseIndex() + 1 == Dialogue.GetNumberPhrases())
            {
                continueText.SetActive(false);
            } else
            {
                continueText.SetActive(true);
            }


            if (Input.GetKeyDown(KeyCode.C) && continueText.activeSelf)
            {
                Dialogue.IncrementPhraseIndex();
            }
        }
    }
}
