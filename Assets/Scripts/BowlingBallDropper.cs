using UnityEngine;
using System.Collections;

public class BowlingBallDropper : MonoBehaviour {
	public GameObject projectile;
	public float rate;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("dropBall", 1, rate);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void dropBall() {
		GameObject go = Instantiate(projectile, gameObject.transform.position, Quaternion.identity) as GameObject;
	}
}
