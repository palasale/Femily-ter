using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public float Speed = 10;

    private Rigidbody2D rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rBody.AddForce(Vector2.down * Speed *Time.fixedDeltaTime );
        this.transform.position = new Vector3(this.transform.position.x ,this.transform.position.y - Speed*Time.fixedDeltaTime, this.transform.position.z);
    }
}
