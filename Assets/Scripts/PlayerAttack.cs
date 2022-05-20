using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float speed;
    public float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        GameObject Cannonball = Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity) as GameObject;
        Cannonball.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        Destroy(Cannonball, destroyTime);
    }
}
