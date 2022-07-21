using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    public bool RightButtonTouched;
    public bool UpButtonTouched;
    public bool DownButtonTouched;
    public bool LeftButtonTouched;
 
   
    public void right()
    {
        player.GetComponent<Rigidbody>().velocity = new Vector3(2, 0,0);
        RightButtonTouched = true;

    }
    public void left()
    {
        Debug.LogWarning("Vallah cagr");
        // player.GetComponent<Rigidbody2D>().MovePosition(new Vector2(-1, 0));
       // player.GetComponent<Rigidbody2D>().velocity += new Vector2(2, 0);
        player.GetComponent<Rigidbody>().velocity = new Vector3(-2, 0,0);
        LeftButtonTouched = true;

    }
    public void up()
    {
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 1,0);
        UpButtonTouched = true;

    }
    public void down()
    {
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, -1,0);
        DownButtonTouched = true;

    }
}
