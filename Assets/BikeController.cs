using UnityEngine;
using System.Collections;

public class BikeController : MonoBehaviour {

	// Use this for initialization
	LevelController levelController;
	public float maxSpeed = 60.0f;
	public float acceleration = 1.0f;
	public float brakePower = 2.0f;

	float resistance;

	float currentSpeed = 0f;

	void Start () {
		levelController = Camera.main.GetComponent<LevelController>();
		resistance = levelController.GetResistance();
	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxis ("Horizontal");
		bool accel = Input.GetButton("Acceleration");
		bool brake = Input.GetButton("Brake");
		if(accel)
		{
			currentSpeed = Mathf.Clamp(currentSpeed + acceleration, 0, maxSpeed);
		}
		if(brake)
		{
			currentSpeed = Mathf.Clamp(currentSpeed - brakePower, 0, maxSpeed);
		}

	}

	void FixedUpdate()
	{
		currentSpeed = Mathf.Clamp(currentSpeed - resistance, 0, maxSpeed);
		levelController.SetSpeed(currentSpeed);
	}
}
