using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public float resistance = 0.1f;
	float currentSpeed = 0f;
	public float minSize = 3f;
	public float maxSize = 6f;
	public float maxForwardView = 1.0f;
	public float zoomFactor = 0.1f;

	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.camera.orthographicSize = Mathf.Clamp(minSize + (currentSpeed * zoomFactor), minSize, maxSize);

		Vector3 newPos = gameObject.transform.position;
		newPos.x = player.transform.position.y;
		newPos.x += Mathf.Clamp(currentSpeed * zoomFactor, 0, maxForwardView);
		gameObject.transform.position = newPos;

	}

	public float GetSpeed()
	{
		return currentSpeed;
	}

	public float  GetResistance()
	{
		return resistance;
	}

	public void SetSpeed(float speed)
	{
		currentSpeed = speed;
	}


}
