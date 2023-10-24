using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.SpriteAssetUtilities;
using UnityEngine;
using UnityEngine.UI;

public class ThrashInteract : MonoBehaviour
{
    public GameObject interactLbl;
    public GameObject tookThrashPanel;
    public Sprite materialSprite;
    public Image materialImage;
    public GameObject check;
    public GameObject interrogation;
    public ThrashManager tm;
    public string materialType;
    public Text typeText;
    private bool tookThrash = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!tookThrash)
        {
            interrogation.SetActive(true);
            check.SetActive(false);
        } else
        {
            interrogation.SetActive(false);
            check.SetActive(true);
        }

        if (!(tm.GetCurrentThrash() == this.gameObject) || tookThrash)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.E) && !Dialogue.GetIsDialoguing())
        {
            tookThrashPanel.SetActive(true);
            materialImage.sprite = materialSprite;
            typeText.text = materialType;
            Dialogue.SetIsDialoguing(true);
        }
        
        if (Dialogue.GetIsDialoguing())
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                tookThrashPanel.SetActive(false);
                Dialogue.SetIsDialoguing(false);
                interactLbl.SetActive(false);
                tookThrash = true;
                tm.thrashTook++;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !tookThrash)
        {
            interactLbl.SetActive(true);
            tm.SetCurrentThrash(this.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !tookThrash)
        {
            interactLbl.SetActive(false);
            tm.SetCurrentThrash(null);
        }
    }
}
