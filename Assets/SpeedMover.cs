using UnityEngine;
using System.Collections;

public class SpeedMover : MonoBehaviour {

	public float speedFactor = 1.0f;
	LevelController levelController;
	public float leftBounds;
	public float rightBounds;
	// Use this for initialization
	void Start () {
		levelController = Camera.main.GetComponent<LevelController>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float globalSpeed = levelController.GetSpeed();
		float speedToMove = globalSpeed * speedFactor;
		foreach(Transform child in transform)
		{
			Vector2 newPos = child.transform.position;
			newPos.x -= speedToMove;
			if(newPos.x <= leftBounds)
			{
				newPos.x = rightBounds;
			}
			child.position = newPos;
		}
	}
}
