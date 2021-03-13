using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletprefab;
    // Start is called before the first frame update
    public float bulletforce = 5f;

    // Update is called once per frame
    void Start()
    {
        //StartCoroutine(Tool());
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(Gamecontroller.canshoot == true)
            {

               
                Shoot();

            }
                
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb =  bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);
    }

    /*IEnumerator Tool()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.48f);
            canshoot = true;
            Debug.Log("Shoot");
            yield return new WaitForSeconds(0.2f);
            canshoot = false;
        }
    }*/
   
}
