using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float timebetweenwave = 1f;
    private float timetospawn = 2f;
    

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timetospawn)
        {
            spawn();
            timetospawn = Time.time + timebetweenwave;
        }
    }

    void spawn()
    {
        Instantiate(prefab, new Vector3(9.0f, -3.77f, 0.0f), Quaternion.identity);
    }
}
