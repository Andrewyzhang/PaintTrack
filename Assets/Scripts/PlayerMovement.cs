using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  public CharacterController2D controller;
  public Animator animator;

  public float runSpeed = 40f;

  bool jump = false;

  float horizontalM = 0f;



  // Start is called before the first frame update
  void Start()
  {

  }



  // Update is called once per frame
  void Update()
  {

    horizontalM = Input.GetAxisRaw("Horizontal") * runSpeed;

    animator.SetFloat("speed", Mathf.Abs(horizontalM));

    if (Input.GetButtonDown("Jump"))
    {
      jump = true;
      animator.SetBool("jumping", true);
    }



  }


  void FixedUpdate()
  {
    controller.Move(horizontalM * Time.fixedDeltaTime, false, jump);
    jump = false;
    animator.SetBool("jumping", false);
  }
}
