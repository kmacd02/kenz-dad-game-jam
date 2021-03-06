using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBall : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 25;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyStats enemy = hitInfo.GetComponent<EnemyStats>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}