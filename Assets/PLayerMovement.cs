
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public float maxSpeed=10000.0f;

    public Rigidbody2D rb;
    

    // Update is called once per frame
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
       
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.velocity = new Vector2(moveHorizontal*5, moveVertical*5);

    }



    
}
