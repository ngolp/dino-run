using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;
    public float cloudSpawnRate = 7;
    public float cloudOffsetX = 2;
    public float cloudOffsetY = 3;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < cloudSpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnCloud();
        }
    }

    void spawnCloud()
    {
        float highPoint = transform.position.y + cloudOffsetY;
        float lowPoint = transform.position.y - cloudOffsetY;
        float rightPoint = transform.position.x + cloudOffsetX;
        float leftPoint = transform.position.x - cloudOffsetX;

        Instantiate(cloud, new Vector3(Random.Range(leftPoint, rightPoint), Random.Range(lowPoint, highPoint), 1), transform.rotation);
    }
}
