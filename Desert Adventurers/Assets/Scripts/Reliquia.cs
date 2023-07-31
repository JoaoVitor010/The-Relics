using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reliquia : MonoBehaviour
{
    public int RlqValue;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            GameController.instance.UpdateRlq(RlqValue);
            Destroy(gameObject);
        }
    }
}
