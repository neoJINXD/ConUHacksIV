using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        transform.position = position;
        Vector2 edge = Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

        if (transform.position.x > edge.x)
        {
            Destroy(gameObject);
        }
    }
}
