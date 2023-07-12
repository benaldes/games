using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletForce = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))    
        {
            Shot();
        }
       
    }
    private void Shot()
    {
        GameObject bullet = Instantiate(Bullet, gameObject.transform.position,gameObject.transform.rotation);
        Rigidbody2D bulletrig = bullet.GetComponent<Rigidbody2D>();
        bulletrig.AddForce(gameObject.transform.right * BulletForce, ForceMode2D.Impulse);

    }
}
