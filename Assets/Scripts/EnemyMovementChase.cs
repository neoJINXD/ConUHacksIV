using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementChase : MonoBehaviour
{
    Transform targetPos;
    int MoveSpeed = Random.Range(4,8);
        
    #endregion;
 
    void Start()
    {
   
    }
 
    void Update()
    {
        float step = MoveSpeed * Time.deltaTime;
        //target the player
        targetPos = GameObject.FindWithTag("Player").transform; 
        var distance = Vector2.Distance(transform.position, targetPos.position);

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, targetPos.position, step);
    }
 }

