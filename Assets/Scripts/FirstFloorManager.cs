using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorManager : MonoBehaviour
{
    public GameObject firstDialogue;
    // Start is called before the first frame update
    void Start()
    {
        firstDialogue.SetActive(true);
        Dialogue.SetIsDialoguing(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && firstDialogue.activeSelf)
        {
            firstDialogue.SetActive(false);
            Dialogue.SetIsDialoguing(false);
        }
        
    }
}
