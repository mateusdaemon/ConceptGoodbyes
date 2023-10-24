using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    private int paperCount = 0;
    private int metalCount = 0;
    private int plasticCount = 0;
    private int glassCount = 0;
    private bool collectedAll = false;

    public Image paperCheck;
    public Image metalCheck;
    public Image plasticCheck;
    public Image glassCheck;

    public Sprite check;
    public Sprite unknow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (paperCount == 1)
        {
            paperCheck.sprite = check;
        } else
        {
            paperCheck.sprite = unknow;
        }

        if (metalCount == 1)
        {
            metalCheck.sprite = check;
        }
        else
        {
            metalCheck.sprite = unknow;
        }

        if (plasticCount == 1)
        {
            plasticCheck.sprite = check;
        }
        else
        {
            plasticCheck.sprite = unknow;
        }

        if (glassCount == 1)
        {
            glassCheck.sprite = check;
        }
        else
        {
            glassCheck.sprite = unknow;
        }

        collectedAll = ((paperCount + metalCount + plasticCount + glassCount) == 4);
    }

    public void AddCount(Collectable thrash)
    {
        switch (thrash.types)
        {
            case Collectable.ThrashType.Paper:
                paperCount++;
                break;
            case Collectable.ThrashType.Plastic:
                plasticCount++;
                break;
            case Collectable.ThrashType.Metal:
                metalCount++;
                break;
            case Collectable.ThrashType.Glass:
                glassCount++;
                break;
            default:
                break;
        }
    }

    public bool AllCollected()
    {
        return collectedAll;
    }


}
