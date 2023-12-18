using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballM : MonoBehaviour
{
    Rigidbody2D rigi;
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();

        rigi.AddForce(new Vector2(0, -500),ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 9;
      rigi.velocity = rigi.velocity.normalized * speed;

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, -3.8f, 0);
        }

    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGameObject = collision.gameObject;

        ENEMY hitEnemy = otherGameObject.GetComponent<ENEMY>();

        if(hitEnemy != null)
        {
            hitEnemy.TakeDamage();
        }
       
    }

}
