using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialTree : MonoBehaviour
{
    public string npcName;
    [TextArea(3, 10)]
    public string[] npcText;
    [TextArea(3, 10)]
    public string[] playerOpt_1;
    [TextArea(3, 10)]
    public string[] playerOpt_2;

    public Sprite npcSpritePic;    
    public Sprite playerSpritePic;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (this.gameObject == Dialogue.GetCurrentNpc())
        {
            Dialogue.CreateTree(npcText, playerOpt_1, playerOpt_2, npcName);
            Dialogue.SetDialogueProfiles(npcSpritePic, playerSpritePic);
        }
    }




}
