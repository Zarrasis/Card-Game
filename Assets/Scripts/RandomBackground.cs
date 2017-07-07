using UnityEngine;
using System.Collections;

public class RandomBackground : MonoBehaviour {

    public SpriteRenderer backgroundSR;
    public Sprite[] backgroundSprites;


	// Use this for initialization
	void Start () {
        backgroundSR.sprite = backgroundSprites[Random.Range(0, backgroundSprites.Length)];
	}
	
	
}
