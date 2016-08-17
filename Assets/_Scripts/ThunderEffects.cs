using UnityEngine;
using System.Collections;

public class ThunderEffects : MonoBehaviour {

	[SerializeField]
	public AudioClip[] thunderClip;


	// Use this for initialization
	void Start () {

		//thunderClip = new AudioClip[5];

		InvokeRepeating("PlayClips", 0.01f, 5.0f);
	
	}
	
	// Update is called once per frame
	void PlayClips() {

		GetComponent<AudioSource>().clip = thunderClip[Random.Range(0, 5)];
		GetComponent<AudioSource>().Play();
	
	}
}
