using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObstacle : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        Debug.Log(currentHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(20);
            Destroy(collision.gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

}
