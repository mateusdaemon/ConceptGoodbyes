using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonate : MonoBehaviour
{
    public float timeToDetonate;
    public GameObject grenadeEffect;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DetonateGrenade", timeToDetonate);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DetonateGrenade()
    {
        Vector3 pos = transform.position;
        Instantiate(grenadeEffect, pos, new Quaternion());
        Destroy(this.gameObject);
    }
}
