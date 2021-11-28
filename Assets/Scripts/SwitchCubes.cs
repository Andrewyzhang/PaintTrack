using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCubes : MonoBehaviour
{
    public GameObject Player;
    public GameObject blueCube, redCube;
    public ParticleSystem redParticles, blueParticles;

    int whichCubeIsOn = 1;
    public static string playerColor;
    // Start is called before the first frame update
    void Start()
    {
        blueCube.gameObject.SetActive(true);
        redCube.gameObject.SetActive(false);
        playerColor = "blue";
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

                //Particles
                blueParticles.Play();

                // the red is on
                whichCubeIsOn = 2;

                // disable blue one and enable red
                blueCube.gameObject.SetActive(false);
                redCube.gameObject.SetActive(true);
                playerColor = "red";
                Player.layer = 8;
                break;

            // if red is on
            case 2:
				// the blue is on

                //Particles
                redParticles.Play();

                whichCubeIsOn = 1;

                // disable red one and enable blue
                blueCube.gameObject.SetActive(true);
                redCube.gameObject.SetActive(false);
                playerColor = "blue";
                Player.layer = 9;
                break;
        }

    }
}
