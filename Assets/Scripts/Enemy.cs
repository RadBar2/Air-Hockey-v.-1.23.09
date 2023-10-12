using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform DefencePoint;
    public Transform Pin;
    public float DefenceSpeed = 15;
    public float speed = 30;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    Vector2 targetPos;
    // Update is called once per frame
    void Update()
    {
        if (Pin.position.x < 0)
        {
            targetPos = Vector2.MoveTowards(transform.position, Pin.position, speed * Time.deltaTime);
        } 
        else
        {
            targetPos = Vector2.MoveTowards(transform.position, DefencePoint.position, DefenceSpeed * Time.deltaTime);
        }
        rb.MovePosition(targetPos);
    }
   
    
}
