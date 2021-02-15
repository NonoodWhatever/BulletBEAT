using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rigid;
    private Vector2 Movedirection;
    public Camera cam;

    Vector2 mousePos;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Processinput();

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        Move();

        Vector2 lookDir = mousePos - rigid.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rigid.rotation = angle;
    }

    void Processinput()
    {
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");

        Movedirection = new Vector2(movex, movey);
    }
    void Move()
    {
        rigid.MovePosition(rigid.position + Movedirection * speed * Time.fixedDeltaTime);
    }
}
