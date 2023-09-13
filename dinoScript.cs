using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength = 10;
    public bool alive = true;
    public float GROUND = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && alive && transform.position.y <= GROUND)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }
    }
}
