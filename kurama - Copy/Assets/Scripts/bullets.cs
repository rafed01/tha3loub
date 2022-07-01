using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject effect;
    public int damage = 40;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Enemy enemy = hitinfo.GetComponent<Enemy>();
        if (enemy  != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);

    }

}
