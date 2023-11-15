using UnityEditor;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public NpcBehavior npc;
    public SceneAsset accepctQuest;
    public SceneAsset declineQuest;
    public InteractChangeLevel changeLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (npc.GetAcceptQuest())
        {
            changeLevel.scene = accepctQuest;
        } else
        {
            changeLevel.scene = declineQuest;
        }

        if (npc.GetTalked())
        {
            changeLevel.gameObject.SetActive(true);
        } else
        {
            changeLevel.gameObject.SetActive(false);
        }
    }
}
