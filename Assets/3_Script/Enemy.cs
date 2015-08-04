using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float _speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (_speed * Time.deltaTime, 0, 0);
	}
}
