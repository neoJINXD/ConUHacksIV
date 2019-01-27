using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    public static GameObject Boss;
    int MoveSpeed;

    void Start()
    {
        MoveSpeed = Random.Range(2,6);
    }

    public static void comeOut(GameObject[] bossObj)
    {
         GameObject b = Instantiate (bossObj[UnityEngine.Random.Range(0,1)]) as GameObject;
         b.transform.position = new Vector2 (3.8f, -0.17f);
    }
}
