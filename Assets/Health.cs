
using UnityEngine;

public class Health : MonoBehaviour
{
    public Rigidbody2D rb;
    public int curHealth;
    public int maxHealth=100;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Die()
    {
        if (curHealth == 0)
        {

        }
    }
}
