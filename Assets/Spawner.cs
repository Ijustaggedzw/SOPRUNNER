using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //create a public array of objects to spawn 9FIXED LATER)
    public GameObject[] objectsToSpawn;

    float timeToNextSpawn;  //Tracks how long we should wait before spawning an object
    float timeSinceLastSpawn = 0.0f;    //tracks time since something spwned

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);  //random.range returns a random float between the two valsues
    }

    // Update is called once per frame
    void Update()
    {
        //add time. deltatime returns the amount fo time passed till the last frame
        //creates a float which will count up in seconds
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        if (timeSinceLastSpawn > timeToNextSpawn)
        {

            int selection = Random.Range(0, objectsToSpawn.Length);

            //instantiate spawns a game object, we are currently tellin git to spawn a game object from our objectsto spawn
            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);

            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;
        }
    }
}