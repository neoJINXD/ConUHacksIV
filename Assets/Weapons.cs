
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bulletPrefab;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
    }
}
