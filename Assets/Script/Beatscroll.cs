using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beatscroll : MonoBehaviour
{
    bool trigger = false;
    private  float tempo = 120f;
    public bool gamestart;
    // Start is called before the first frame update
    void Start()
    {
        tempo = tempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            gamestart = true;
        }
        else
        {
            transform.position -= new Vector3(tempo * Time.deltaTime, 0.0f, 0.0f);
            if(transform.position.x < -10.0f)
            {
                Destroy(gameObject);
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (trigger == true)
            {

                Destroy(gameObject);


            }

        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            Gamecontroller.canshoot = true;
            trigger = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            Gamecontroller.canshoot = false;
            trigger = false;
        }

    }
}
