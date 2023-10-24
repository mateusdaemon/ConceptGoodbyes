using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterManager : MonoBehaviour
{
    public InventoryManager invManager;
    public InteractChangeLevel changeLevel;
    public GameObject selfDialogue;

    private bool messageRead = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (invManager.AllCollected() && !messageRead)
        {
            selfDialogue.SetActive(true);
            Dialogue.SetIsDialoguing(true);
        }

        if (selfDialogue.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                selfDialogue.SetActive(false);
                Dialogue.SetIsDialoguing(false);
                messageRead = true;
                changeLevel.gameObject.SetActive(true);
            }
        }
        
    }
}
