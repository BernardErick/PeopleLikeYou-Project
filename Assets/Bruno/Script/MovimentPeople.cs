using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPeople : MonoBehaviour
{
    public GameObject people;
    public float spawnRate;

    private float nextSpawn;
    void Update()
    {
        if(Time.time> nextSpawn){
            nextSpawn = Time.time + spawnRate;

            Instantiate(people, transform.position, people.transform.rotation);
        }
    }
}
