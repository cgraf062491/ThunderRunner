using UnityEngine;
using System.Collections;

public class PlatformTrigger : MonoBehaviour {

	void OnTriggerStay(Collider hit){
		if(hit.gameObject.tag == "TopTrigger"){
			GetComponent<Rigidbody>().GetComponent<Collider>().isTrigger = true;
			GetComponent<Rigidbody>().isKinematic = true;
		}
	}

	void OnTriggerExit(Collider hit){
		if(hit.gameObject.tag == "BottomTrigger"){
			GetComponent<Rigidbody>().GetComponent<Collider>().isTrigger = false;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
