using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public KeyCode shootKey;
    private Rigidbody2D bulletRb;
    private Vector3 bulletPos;
    // Start is called before the first frame update
    void Start()
    {
        bulletRb = bulletPrefab.GetComponent<Rigidbody2D>();
        bulletPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(shootKey))
        {
            GameObject.Instantiate(bulletRb, this.transform.position, new Quaternion());
        }
        
    }
}
