using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueProps : MonoBehaviour
{
    public Image panelProfile;
    public Text panelSentence;
    public Sprite profileImg;

    [TextArea(3,10)]
    public string[] phrases;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject == Dialogue.GetCurrentNpc())
        {
            Dialogue.SetNumberPhrases(this.phrases.Length);
            panelProfile.sprite = this.profileImg;
            panelSentence.text = this.phrases[Dialogue.GetPhraseIndex()];
        }

    }
}
