
using UnityEngine;

public class BulletLeft : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -(transform.right * speed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        transform.position = position;
        Vector2 edge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0));

        if (transform.position.x < edge.x)
        {
            Destroy(gameObject);
        }
    }
}
