using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public enum ThrashType {Paper, Plastic, Metal, Glass};
    public ThrashType types;
    public GameObject interact;
    private bool canCollect = false;
    private InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = FindObjectOfType<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canCollect)
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                inventoryManager.AddCount(this);
                interact.SetActive(false);
                GameObject.Destroy(this.gameObject);

            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canCollect = true;
            interact.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canCollect = false;
            interact.SetActive(false);
        }
    }

}
