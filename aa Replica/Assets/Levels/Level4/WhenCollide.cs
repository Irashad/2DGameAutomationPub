using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenCollide : MonoBehaviour
{

    public bool crash;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().mass = 100;
        crash = true;
    }

}
