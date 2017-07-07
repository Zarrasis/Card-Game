using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;
    // Use this for initialization
   void Awake(){
        DontDestroyOnLoad(gameObject);
        Debug.Log("Didn't Destroy: " + name);

    }
	
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {

        

       /* float audioVolume = audioSource.volume;
        if (audioVolume < 1)
        {
            audioVolume += 0.1f * Time.deltaTime;
            audioSource.volume = audioVolume;
        }*/
    }

    void OnLevelWasLoaded(int level) {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];

        if (thisLevelMusic) {
            if (audioSource.clip != thisLevelMusic){
                audioSource.clip = thisLevelMusic;
                Debug.Log(thisLevelMusic.ToString());
                if (string.Compare(thisLevelMusic.ToString(), "win") == 0)
                {
                    audioSource.loop = false;
                }
                else {
                    audioSource.loop = true;
                }
                audioSource.Play();
               
            }

        }
    }

   public void ChangeVolume(float volume) {
        audioSource.volume = volume;
    }



    }
