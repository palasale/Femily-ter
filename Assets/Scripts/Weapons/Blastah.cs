using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blastah : Weapon
{
    [SerializeField] private GameObject projectilePrefab;
    private float lastShotTime;
    [SerializeField] private float shotDelay = 0.2f;
    
    
    private bool canFire = true;
    // Start is called before the first frame update
    void Start()
    {
        lastShotTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Fire()
    {
        if (lastShotTime + shotDelay < Time.time)
        {
            lastShotTime = Time.time;
            GameObject instance = Instantiate(projectilePrefab, transform.position, transform.rotation);
            //instance.GetComponent<Projectile>();
        }
    }

   
}
