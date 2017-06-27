using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {


    public static bool dead = false;




    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            dead = true;
            Debug.Log("You ded");
        }
    }

}
