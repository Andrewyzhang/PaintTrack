using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPlayerDeath : MonoBehaviour
{

    public GameObject player;

    void Update ()
    {
    //check if character fell into the void
    if(player.transform.position.y < -10)
    {
        player.transform.position = new Vector2 (0, 0);
    }
}
}
