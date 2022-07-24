using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WhenSlideFull : MonoBehaviour
{
    [SerializeField]
    GameObject image;
   
    // Update is called once per frame
    void Update()
    {
     if(GetComponent<Slider>().value == 100)
        {
           image.SetActive(true);
        }
    }
}
