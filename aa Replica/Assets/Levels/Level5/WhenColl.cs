using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenColl : MonoBehaviour
{
    public bool isTouched;
    public int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
        score += 100;
        isTouched = true;
    }



}
