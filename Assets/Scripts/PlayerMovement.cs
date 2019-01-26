using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject bulletRight;
    public GameObject pos1;
    public GameObject bulletLeft;
    public GameObject pos2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            GameObject bullet02 = (GameObject)Instantiate(bulletLeft);
            bullet02.transform.position = pos2.transform.position;
        }
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject)Instantiate(bulletRight);
            bullet01.transform.position = pos1.transform.position;
        }
    }
}
