using System;
using System.Collections;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int health = 100;
    public float damage = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       void OnDamage()
       {
           health--;
           if ((health<=0))
           {
               Destroy(gameObject);
           }
       }
    }

    private void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.gameObject.CompareTag("Finish"))
        {
            Enemy.gameObject.SendMessage("OnDamage",damage);
        }
    }
}
