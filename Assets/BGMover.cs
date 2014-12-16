using UnityEngine;
using System.Collections;

public class BGMover : MonoBehaviour {

	public float speedFactor = 1.0f;
	LevelController levelController;


	// Use this for initialization
	void Start () {
		levelController = Camera.main.GetComponent<LevelController>();
	}
	
	// Update is called once per frame
	void Update () {
		float globalSpeed = levelController.GetSpeed();
		float speedToMove = globalSpeed * speedFactor;

		Vector2 newOffset = gameObject.renderer.material.mainTextureOffset;
		newOffset.x -= speedToMove;
		gameObject.renderer.material.mainTextureOffset = newOffset;
	}
}
