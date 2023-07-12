using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttackShow : MonoBehaviour
{
    public float disappear = 0.2f;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < disappear) 
        {
            timer += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
