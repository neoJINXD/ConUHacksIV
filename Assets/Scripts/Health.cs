
using UnityEngine;

public class Health : MonoBehaviour
{
    public Rigidbody2D rb;
    public static int curHealth;
    public int maxHealth=5;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth == 0)
        {
            Die();
        }
    }
    void Die()
    {
        FindObjectOfType<gameManager>().gameOver();
    }
}
