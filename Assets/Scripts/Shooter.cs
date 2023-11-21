using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    private bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            Instantiate(bullet, this.transform.position, new Quaternion());
            canShoot = false;
            Invoke("EnableShoot", 0.5f);
        }        
    }

    private void EnableShoot()
    {
        canShoot = true;
    }
}
