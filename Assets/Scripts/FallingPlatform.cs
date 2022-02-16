using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    public float fallingTime = 0f;

    private TargetJoint2D target;
    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent <TargetJoint2D> ();
        collider = GetComponent <BoxCollider2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Falling", fallingTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }

    void Falling()
    {
        target.enabled = false;
        collider.isTrigger = true;
    }
}