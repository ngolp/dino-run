using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject oneCactus;
    public GameObject twoCactus;

    float timer = 0;
    double spawnRate = 2;
    float spawnOffset = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnCactus();
        }
    }

    void spawnCactus()
    {
        float leftPoint = transform.position.x - spawnOffset;
        float rightPoint = transform.position.x + spawnOffset;
        float randomVal = Random.Range(0, 1000);
        print(randomVal);
        if (randomVal > 500)
        {
            Instantiate(oneCactus, new Vector3(Random.Range(leftPoint, rightPoint), transform.position.y, 0), transform.rotation);
        }
        else
        {
            Instantiate(twoCactus, new Vector3(Random.Range(leftPoint, rightPoint), -0.84f, 0), transform.rotation);
        }
    }
}