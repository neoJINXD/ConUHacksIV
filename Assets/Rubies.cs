using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rubies : MonoBehaviour
{
    public int health;
    public int numOfRubies;

    public Sprite[] rubies;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < rubies.Length; i++)
        {
            if (i < numOfRubies)
            {
                rubies[i].enabled = true;
            }
        }
    }
}
