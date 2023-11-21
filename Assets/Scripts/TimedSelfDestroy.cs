using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSelfDestroy : MonoBehaviour
{
    public float timeInSeconds;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyMyself", timeInSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroyMyself()
    {
        Destroy(gameObject);
    }
}
