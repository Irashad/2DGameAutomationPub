using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

    }

}
