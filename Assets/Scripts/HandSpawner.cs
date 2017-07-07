using UnityEngine;
using System.Collections;

public class HandSpawner : MonoBehaviour
{

    public GameObject cardPrefab;


    //public float width = 10f;
    //public float height = 5f;

    //public float spawnDelay = 1.0f;


    float xmin;
    float xmax;

    // Use this for initialization
    void Start()
    {
        foreach (Transform child in transform)
        {
            GameObject card = Instantiate(cardPrefab, child.transform.position, Quaternion.identity) as GameObject;
            card.transform.parent = child;
        }
        //float distance = transform.position.z - Camera.main.transform.position.z;
        //Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        //Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));

        //xmin = leftmost.x + width/2;
        //xmax = rightmost.x - width/2;

        //SpawnUntilFull();

    }




    // Update is called once per frame
    void Update()
    {



    }

    //Transform NextFreePosition(){
    //    foreach (Transform childPositionGameObject in transform){
    //        if (childPositionGameObject.childCount == 0){
    //            return childPositionGameObject;
    //        }
    //    }
    //    return null;
    //} 



    //public void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));

    //}

    //void Respawn() {
    //  foreach (Transform child in transform){
    //        GameObject enemy = Instantiate(cardPrefab, child.transform.position, Quaternion.identity) as GameObject;
    //        enemy.transform.parent = child;
    //    }
    //}
    //void SpawnUntilFull() {
    //    Transform freePosition = NextFreePosition();
    //    if (freePosition) {
    //        GameObject enemy = Instantiate(cardPrefab, freePosition.position, Quaternion.identity) as GameObject;
    //        enemy.transform.parent = freePosition;
    //    }
    //    if (NextFreePosition()) {
    //        Invoke("SpawnUntilFull", spawnDelay);

    //    }
    //}
}

