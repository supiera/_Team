using UnityEngine;
using System.Collections;

public class DeleteEnemy : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Destroy (col.gameObject);
	}
}
