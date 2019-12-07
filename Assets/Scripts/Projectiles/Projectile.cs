using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Damage;
    public float lifespan = 20;
    public float Speed;
    [SerializeField] private GameObject explosionPrefab;

    private Rigidbody2D rigidbody;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * Speed , ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifespan)
        {
            Destroy(this.gameObject);
        }
    }
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
