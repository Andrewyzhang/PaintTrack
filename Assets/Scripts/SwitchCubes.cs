using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCubes : MonoBehaviour
{
    public GameObject blueCube, redCube;
    int whichCubeIsOn = 1;
    // Start is called before the first frame update
    void Start()
    {
        blueCube.gameObject.SetActive(true);
        redCube.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchCube()
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
                break;

            // if red is on
            case 2:
                whichCubeIsOn = 1;

                // disable blue one and enable red
                blueCube.gameObject.SetActive(true);
                redCube.gameObject.SetActive(false);
                break;
        }

    }
}
