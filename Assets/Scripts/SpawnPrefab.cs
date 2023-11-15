using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject[] prefabSpawn;
    public float timeInSeconds;
    public bool spawnInHeights;
    private BoxCollider2D bc;
    private float width, height;
    

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        width = bc.bounds.size.x / 2;
        height = bc.bounds.size.y / 2;

        Invoke("SpawnObject", timeInSeconds);
    }

    private void SpawnObject()
    {
        float yPos = Random.Range(-height, height);
        float xPos = Random.Range(-width, width);
        int index = Random.Range(0, prefabSpawn.Length);

        if (spawnInHeights)
        {
            Instantiate(prefabSpawn[index], new Vector3(xPos, this.transform.position.y, 0), new Quaternion());
        } else
        {
            Instantiate(prefabSpawn[index], new Vector3(this.transform.position.x, yPos, 0), new Quaternion());
        }

        Invoke("SpawnObject", timeInSeconds);
    }
}
