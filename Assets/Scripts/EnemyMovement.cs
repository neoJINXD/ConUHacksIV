using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   
    Vector3 target;
    Vector2 target2;
    Transform targetPos;
    /* int MaxDist = 30;
    int MinDist = 5;*/
    int MoveSpeed = 4;
 
    void Start()
    {
   
    }
 
    void Update()
    {
        float step = MoveSpeed * Time.deltaTime;
        targetPos = GameObject.FindWithTag("Player").transform; 
        var distance = Vector2.Distance(transform.position, targetPos.position);
        if(distance > 2) {
        //target the player
    /*     // get the angle
        Vector3 norTar = (target-transform.position).normalized;
        float angle = Mathf.Atan2(norTar.y,norTar.x)*Mathf.Rad2Deg;
        // rotate to angle
        Quaternion rotation = new Quaternion ();
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); */

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, targetPos.position, step);
        }
    }
 }
