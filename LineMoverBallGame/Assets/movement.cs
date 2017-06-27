using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float maxSpeed;
    private float speed;
    public float speedDrop;
    public GameObject player;
    public float positionToStopLines;
    public GameObject restartButton;

    void Update()
    {
        
        if (Death.dead == false)
        {
            restartButton.SetActive(false);
            if (Input.GetButtonDown("Fire1"))
            {
                speed = maxSpeed / 1000;
            }

            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speed);

            if (speed > -1)
            {
                speed -= speedDrop / 1000;
            }

            if(player.transform.position.y > positionToStopLines)
            {
                player.transform.position = new Vector3(player.transform.position.x, positionToStopLines);
            }
            if (player.transform.position.y < -positionToStopLines)
            {
                player.transform.position = new Vector3(player.transform.position.x, -positionToStopLines);
            }
        }
        else
        {
            restartButton.SetActive(true);
        }
    }
}
