using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    int killedCounter=0;

    void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        Score.scoreValue++;
    }

    

   

}
