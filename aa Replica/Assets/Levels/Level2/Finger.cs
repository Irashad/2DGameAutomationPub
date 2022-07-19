using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        #region MobileInput
        /* if (Input.touchCount > 0)
         {
             if (Input.GetTouch(0).phase == TouchPhase.Began)
             {
                 Debug.LogWarning("Touch basladi)");
                 GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
             }
         }
 */
        #endregion MobileInput

        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    } 
}
