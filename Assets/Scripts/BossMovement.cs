using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    Transform targetPos;
    int MoveSpeed = 9;
 
    void Start()
    {
   
    }
 
    void Update()
    {
        float step = MoveSpeed * Time.deltaTime;
        targetPos = GameObject.FindWithTag("Player").transform; 
        var distance = Vector2.Distance(transform.position, targetPos.position);

        if (distance > 18)
            transform.position = Vector2.MoveTowards(transform.position, targetPos.position, step);
        /* else
            {
                Add bullet script
            }*/
    }
 }
