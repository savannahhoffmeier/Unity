using System;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
  private Rigidbody PlayerRb;
  public float jumpForce;
  public float gravityMod;
  public bool isOnGround;
  public BoolData gameOver;

  private void Start()
  {
    PlayerRb = GetComponent < Rigidbody();
    Physics.gravity *= gravityMod;
    gameOver.value = false;
  }

   void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space)&& isOnGround)
    {
      PlayerRb.AddForce(Vector3.up*8,ForceMode.Impulse);
      isOnGround = false;
    }
  }

   private void OnCollisionEnter(Collision collision)
   {
     if (collision.gameObject.CompareTag("Ground"))
     {
       isOnGround = true;
     }else if (collision.other.CompareTag("Obstacle"))
     {
       gameOver.value = true;
       Debug.Log("Game Over");
     }
   }
}
