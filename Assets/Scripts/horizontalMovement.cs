using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovement : MonoBehaviour
{

    void Update()
    {

      bool left = false;

      float movespeed = 0.0f;

      if (left) {
        movespeed -= .01f;
      } else {
        movespeed += .01f;
      }

      if (movespeed > 10) {
        left = true;
      } else if (movespeed < -10) {
        left = false;
        //test
      }

      transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);

    }
}
