using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovement : MonoBehaviour
{

    void Update()
    {

      float movespeed = 0.0f;

      if (movespeed < 0) {
        movespeed -= .01f;
      } else {
        movespeed += .01f;
      }

      if (movespeed > .1 || movespeed < -.1) {
        movespeed = -1 * movespeed;
      }

      transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);

    }
}
