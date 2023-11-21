using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{
    public GameObject grenade;
    private bool canLauch = true;
    private Rigidbody2D grenadeRb;

    // Start is called before the first frame update
    void Start()
    {
        grenadeRb = grenade.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canLauch)
        {
            Vector3 pos = transform.position;
            pos.x += 0.3f;

            grenadeRb = Instantiate(grenade, pos, new Quaternion()).GetComponent<Rigidbody2D>();
            grenadeRb.AddForce(new Vector2(1,1) * 0.25f, ForceMode2D.Impulse);
            canLauch = false;
            Invoke("EnableLaunch", 3);
        }
    }

    private void EnableLaunch()
    {
        canLauch = true;
    }
}
