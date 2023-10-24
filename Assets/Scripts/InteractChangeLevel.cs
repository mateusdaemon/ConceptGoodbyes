using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractChangeLevel : MonoBehaviour
{
    public GameObject levelPanel;
    private bool enableLevel;
    public SceneAsset scene;
    public KeyCode interactKey;

    // Start is called before the first frame update
    void Start()
    {
        enableLevel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enableLevel && Input.GetKeyDown(interactKey))
        {
            ChangeLevel(scene);
        }
                
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            levelPanel.SetActive(true);
            enableLevel = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            levelPanel.SetActive(false);
            enableLevel = false;
        }
    }

    public void ChangeLevel(SceneAsset level)
    {
        SceneManager.LoadScene(level.name);
    }
}
