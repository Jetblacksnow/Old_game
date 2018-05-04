using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

	public float moveSpeed;

	void MoveForward(){
		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	}

	void Turn(){
		int randomNum = Random.Range(0,360);
		transform.Rotate(0,randomNum,0);
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject.tag ==	"CheckPoint"){
			//transform.LookAt("CheckPoint");
			Turn();
		}
		else{
			MoveForward();
		}
	}

	//Trying to get the Checkpoint to move on it's own within a small area.
	//  void OnCollisionEnter(Collision other){
    //     if(other.gameObject.name == "Chicken"){
    //         transform.position = Random.Range(10,360);
    //     }
    // }
}
