using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    //public GameObject panelInteract;
    public GameObject interactText;
    public NpcBehavior npcBehavior;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Enables/Disables button to Interact
        if (Dialogue.GetDialogueEnabled() && this.gameObject == Dialogue.GetCurrentNpc())
        {
            if (Dialogue.GetIsDialoguing())
            {
                interactText.SetActive(false);
            } else
            {
                interactText.SetActive(true);
            }
        }

        if (Dialogue.GetCurrentNpc() == this.gameObject && npcBehavior.GetTalked())
        {
            interactText.SetActive(false);
            Dialogue.SetDialogueEnabled(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !npcBehavior.GetTalked())
        {
            Dialogue.SetDialogueEnabled(true);
            Dialogue.SetCurrentNpc(this.gameObject);
            interactText.SetActive(true);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Dialogue.SetDialogueEnabled(false);
            interactText.SetActive(false);
            Dialogue.SetCurrentNpc(null);
        }
    }
}
