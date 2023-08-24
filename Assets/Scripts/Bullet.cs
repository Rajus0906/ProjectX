using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody rb;
    public float lifetime;

    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;

        // destroys bullet so it doesnt over populate the game
        Destroy(gameObject, lifetime);

    }

    // Update is called once per frame
    void Update()
    {

        //Destroy(gameObject);
    }
}
