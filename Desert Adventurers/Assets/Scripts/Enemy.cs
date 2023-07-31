using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
public float Speed;
private Rigidbody2D rig;
public float WalkTime;
private float timer;
public bool Walkrigth = true;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer >= WalkTime)
        {
            Walkrigth = !Walkrigth;
            timer = 0f;
        }

        if (Walkrigth)
        {
            transform.eulerAngles = new Vector2(0,180);
            rig.velocity = Vector2.right * Speed;
        }
        else
        {
            transform.eulerAngles = new Vector2(0,0);
            rig.velocity = Vector2.left * Speed;
            
        }
    }
}
