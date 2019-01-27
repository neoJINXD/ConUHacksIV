using UnityEngine;
using System.Collections;

public class BoxHealth : MonoBehaviour
{
    int killedCounter=0;

    void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(other.gameObject);
        killedCounter++;

        if(killedCounter == 100)
            Destroy(gameObject);
    }

    

   

}
