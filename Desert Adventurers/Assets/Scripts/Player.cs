using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    
    public GameObject bow;
    public Transform firepoint;
    private bool isfire;
    
    private bool isjuping;

    private Rigidbody2D rig;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        Shot();
    }

    void Move()
    {
        float movement = Input.GetAxis("Horizontal");

        rig.velocity = new Vector2(movement * speed, rig.velocity.y);

        if (movement > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (movement < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if (!isjuping)
            {
                rig.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
                isjuping = true;
            }
            
        }
    }

    void Shot()
    {
        StartCoroutine("Fire");
    }

    IEnumerator Fire()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isfire = true;
            GameObject Bow = Instantiate(bow, firepoint.position, firepoint.rotation);

            Bow.GetComponent<Bow>().isRigth = transform.rotation.y == 0;
            
            yield return new WaitForSeconds(0.2f);
            isfire = false;
        }
       
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 8)
        {
            isjuping = false;
        }
    }
}
