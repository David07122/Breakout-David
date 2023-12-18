using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    int hp = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void TakeDamage()
    {
        hp -= 1;
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }
}
