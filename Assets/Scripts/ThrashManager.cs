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
    private GameObject currentThrash;
    public int thrashTook = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (npc.GetTalked() && !interactFree)
        {
            interactPlastic.SetActive(true);
            interactPaper.SetActive(true);
            interactMetal.SetActive(true);
            interactGlass.SetActive(true);
            interactFree = true;
        }       
        
        if (thrashTook > 4)
        {
            npc.SetTalked(false);
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
