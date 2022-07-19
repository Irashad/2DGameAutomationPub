using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    GameObject player;

 
   
    public void right()
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);

    }
    public void left()
    {
        Debug.LogWarning("Vallah cagr");
        // player.GetComponent<Rigidbody2D>().MovePosition(new Vector2(-1, 0));
       // player.GetComponent<Rigidbody2D>().velocity += new Vector2(2, 0);
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);

    }
    public void up()
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);

    }
    public void down()
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1);

    }
}
