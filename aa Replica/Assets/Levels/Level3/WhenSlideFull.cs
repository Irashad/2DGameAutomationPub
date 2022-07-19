using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WhenSlideFull : MonoBehaviour
{
    [SerializeField]
    GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(GetComponent<Slider>().value == 100)
        {
           image.SetActive(true);
        }
    }
}
