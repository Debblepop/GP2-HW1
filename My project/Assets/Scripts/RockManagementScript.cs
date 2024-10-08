using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockManagementScript : MonoBehaviour
{
    public float DestroyTimer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyTimer > 0)
        {
            DestroyTimer -= Time.deltaTime;
        }
        if (DestroyTimer <= 0)
        {
            Destroy(gameObject);
            DestroyTimer = 5;
        }
    }
}
