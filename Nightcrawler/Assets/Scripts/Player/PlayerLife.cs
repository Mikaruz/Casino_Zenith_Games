using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private int initialLife;
    private int actualLife;


    // Start is called before the first frame update
    void Start()
    {
        initialLife = 3;
        initialLife = actualLife;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
    private void TakeDamage(int damage)
    {
        actualLife -= damage;
        if (actualLife <= 0) 
        {
          Destroy(gameObject);
        }
        //Destroy momentaneo hasta la animacion de muerte
    }
}
