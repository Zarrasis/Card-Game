using UnityEngine;
using System.Collections;

public class DelayMusic : MonoBehaviour {

    public AudioSource song;

	// Use this for initialization
	void Start () {

        song.PlayDelayed(5);
           
	}
	
}
