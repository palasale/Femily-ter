using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Spawner : MonoBehaviour
{

    public UnitController Prefab;
    public float SpawnPeriod = 1;

    private float lastSpawnTime;
    private Rigidbody2D rigidBody2D;
    private Random rngesus = new Random();
    
    // Start is called before the first frame update
    void Start()
    {
        lastSpawnTime = Time.time;
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time - lastSpawnTime > SpawnPeriod)
        {
            lastSpawnTime = Time.time;
            var tmpTransform = transform;
            var tmp = (float)(rngesus.NextDouble() * tmpTransform.localScale.x);

            var instance = Instantiate(Prefab, tmpTransform.position + Vector3.right*tmp + Vector3.left * tmpTransform.localScale.x / 2, Quaternion.identity);
            //instance.GetComponent<Rigidbody2D>().angularVelocity = 10*((float)rngesus.NextDouble() - 0.5f);
            instance.GetComponent<Rigidbody2D>().AddTorque(instance.GetComponent<Rigidbody2D>().mass*100*((float)rngesus.NextDouble() - 0.5f));
            
            
        }
        
    }
}
