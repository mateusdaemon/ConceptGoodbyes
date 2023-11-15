using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public Vector2 positiveBounds;
    public Vector2 negativeBounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < negativeBounds.x || this.transform.position.x > positiveBounds.x)
        {
            GameObject.Destroy(this.gameObject);
        } else if (this.transform.position.y < negativeBounds.y || this.transform.position.y  > positiveBounds.y)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
