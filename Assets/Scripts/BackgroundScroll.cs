using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    float scroll = 5f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos.x = 0;
        startPos.y = -20;
        startPos.z = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scroll, 40);
        transform.position = startPos + Vector3.up * newPos;
    }
}
