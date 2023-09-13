using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusScript : MonoBehaviour
{
    public float cactusMoveSpeed = 5;
    public dinoScript dino;
    public logicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        dino = GameObject.FindWithTag("Dino").GetComponent<dinoScript>();
        logic = GameObject.FindWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * cactusMoveSpeed) * Time.deltaTime;

        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dino.alive = false;
        logic.gameOver();
    }
}
