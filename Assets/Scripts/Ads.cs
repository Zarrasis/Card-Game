using UnityEngine;
using System.Collections;

public class Ads : MonoBehaviour {

    private float height = Screen.height / 25;
    private float width = Screen.width;
    private float y = Screen.height - Screen.height / 25;

    private string adString = "This is an Ad. You should pay to get rid of me.";
    public GUIStyle myStyle;
    public Texture2D adImage;

    private bool paid = false;

    void Awake()
    {
        DontDestroyOnLoad(this);

        // Do not load duplicate objects
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

    }

    void OnGUI()
    {
        GUI.contentColor = Color.black;
        myStyle.normal.background = adImage;

        GUI.Box(new Rect(0, y, width, height), "", myStyle);
        GUI.Label(new Rect(Screen.width / 3, y, width, height), adString);
    }

    // Use this for initialization
    void Start () {   
    }
	
	// Update is called once per frame
	void Update () {

        // !!!!!! Just to test destroying - Delete Input.GetKeyDown("space")
        if (Input.GetKeyDown("space") || paid)
        {
            Destroy(gameObject);
        }
    }
}
