using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCubes : MonoBehaviour
{
    public GameObject Player;
    public GameObject blueCube, redCube;
    int whichCubeIsOn = 1;
    // Start is called before the first frame update
    void Start()
    {
        blueCube.gameObject.SetActive(true);
        redCube.gameObject.SetActive(false);
        Player.layer = 9;
    }

    // Update is called once per frame
    void Update()
    {

         if(Input.GetKeyDown(KeyCode.X)) {
              SwitchCube();
         }

    }

    public void SwitchCube()
    {
        switch (whichCubeIsOn)
        {
            // if blue is on
            case 1:

                // then red is on now
                whichCubeIsOn = 2;

                // disable blue one and enable red
                blueCube.gameObject.SetActive(false);
                redCube.gameObject.SetActive(true);
                Player.layer = 8;
                break;

            // if red is on
            case 2:
                whichCubeIsOn = 1;

                // disable blue one and enable red
                blueCube.gameObject.SetActive(true);
                redCube.gameObject.SetActive(false);
                Player.layer = 9;
                break;
        }

    }
}
