
using UnityEngine;

public class WeaponLeft : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bulletPrefabLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(bulletPrefabLeft, Firepoint.position, Firepoint.rotation);
    }
}
