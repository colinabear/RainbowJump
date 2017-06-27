using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour {

    private float startTime;
    private int screenWidth;
    private int screenHeight;
    private Vector3 realScreenSize;
    public GameObject ball;
    private int numberOfBallsExisting = 0;
    private GameObject[] Enemy;
    public int timeBetweenBalls;
    public float ballSpeed;

	void Start () {
        Camera cam = Camera.main;
        startTime = Time.time;
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        realScreenSize = cam.ScreenToWorldPoint(new Vector3(screenWidth, screenHeight));
	}
	
	
	void Update () {
		if(Time.time - startTime >= timeBetweenBalls)
        {
            startTime = Time.time;
            Instantiate(ball, new Vector3(realScreenSize.x + 1, Random.Range((-realScreenSize.y)+0.5f, realScreenSize.y-0.5f)), Quaternion.identity);
            numberOfBallsExisting += 1;
        }
        if (Death.dead == false)
        {
            Enemy = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject e in Enemy)
            {
                e.transform.position = new Vector3(e.transform.position.x - ballSpeed/100, e.transform.position.y);
            }
        }
    }
}
