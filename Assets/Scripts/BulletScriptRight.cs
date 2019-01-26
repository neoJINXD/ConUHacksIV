using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriptRight : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position;
        position = new Vector2(position.x +speed, position.y);
        transform.position = position;
        Vector2 edge = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if(transform.position.x > edge.x)
        {
            Destroy(gameObject);
        }
    }
}
