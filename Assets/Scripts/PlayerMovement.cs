using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject bulletRight;
    public GameObject pos1;
    public GameObject bulletLeft;
    public GameObject pos2;
    public float maxSpeed = 10000.0f;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject bullet02 = (GameObject)Instantiate(bulletLeft);
            bullet02.transform.position = pos2.transform.position;
        }
        if (Input.GetMouseButtonDown(1))
        {
            
            GameObject bullet01 = (GameObject)Instantiate(bulletRight);
            bullet01.transform.position = pos1.transform.position;
        }
        
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.velocity = new Vector2(moveHorizontal * 5, moveVertical * 5);

    }
}
