using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // create a public refrence to the player - we will assign this using the unity editor
   public GameObject player;
   

    // Update is called once per frame
    void Update()
    {
      // change our postition relative to the players postion
      transform .position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
