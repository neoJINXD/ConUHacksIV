using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform targetPos;
    int MoveSpeed = Random.Range(3,9);
 
    void Start()
    {
   
    }
 
    void Update()
    {
        float step = MoveSpeed * Time.deltaTime;
        targetPos = GameObject.FindWithTag("Player").transform; 
        var distance = Vector2.Distance(transform.position, targetPos.position);
        if(distance > Random.Range(3,8)) 
        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, targetPos.position, step);

                /* else
            {
                Add bullet script
            }*/
    }
 }
