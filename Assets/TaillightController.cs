using UnityEngine;
using System.Collections;

public class TaillightController : MonoBehaviour {

	// Use this for initialization
	LevelController levelController;

	void Start () {
		levelController = Camera.main.GetComponent<LevelController>();
	
	}
	
	// Update is called once per frame
	void Update () {
		Color oldColor = renderer.material.GetColor("_TintColor");
		print (oldColor);
		Color newColor = oldColor;
		float speed = levelController.GetSpeed();
		newColor.a = Mathf.Clamp(speed / 32, 0, 1);

		renderer.material.SetColor("_TintColor", newColor);
	
	}
}
