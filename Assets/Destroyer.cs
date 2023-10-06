using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Much the Start () and Update() methods, onTrigerEnter2D is a special unity method that is called 
    //by Unity automaticaly at a specific piont# - in this case, when something enters
    // to this GameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if tthe GameObject that has collided with our trigger is tagged with a CleanUp
        if (collision.gameObject.tag == "CleanUp")
        {
            //Then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
}
