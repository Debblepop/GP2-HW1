using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;


public class RockScript : MonoBehaviour
{
    public GameObject RockPrefab;
    public float RockSpawnTimer = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < RockSpawnTimer)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnRock();
            timer = 0;
        }
    }

    void SpawnRock()
    {
        Vector3 where = new Vector3(Random.Range(-11f, 11f), Random.Range(6f, 7f), 0);
        Instantiate(RockPrefab, where, Quaternion.identity);
    }
}
