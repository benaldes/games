using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int BulletDamage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "enemy")
        {
            collision.collider.GetComponent<Enemy>().takeDamage(BulletDamage);
            
        }
        if(collision.collider.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
