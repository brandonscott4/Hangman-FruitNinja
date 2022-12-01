using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_items : MonoBehaviour
{

    public float spawnTime = 1; //Spawn Time
    public GameObject apple; //Apple prefab
    public GameObject bomb; //Bomb prefab
    public float upForce = -750; //Up force
    public float leftRightForce = 200; //Left and right force
    public float maxX = -10; //Max x spawn position
    public float minX = 3; //Min x spawn position
    private GameObject rngObject;
    private GameObject[] letterPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        letterPrefabs = Resources.LoadAll<GameObject>("LetterPrefabs");
        rngObject = GameObject.Find("rngWordObject");
        //Start the spawn update
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        //Wait spawnTime
        yield return new WaitForSeconds(spawnTime);
        //Spawn prefab is apple
        //GameObject prefab = apple;
        char letter = rngObject.GetComponent<RandomWordGeneratorScript>().getRandomOtherLetter();
        int indexOfLetter = -1;
        for(int i=0; i<letterPrefabs.Length; i++)
        {
            if (letterPrefabs[i].name == letter.ToString()){
                indexOfLetter = i;
                //Debug.Log(indexOfLetter);
            }
        }
        GameObject letterPrefab = letterPrefabs[indexOfLetter];

        //If random is over 30
        if (Random.Range(0, 100) < 30)
        {
            //Spawn prefab is bomb
            //you code here later in task 4
            //prefab = bomb;
            letter = rngObject.GetComponent<RandomWordGeneratorScript>().getRandomRemainingLetter();
            for (int i = 0; i < letterPrefabs.Length; i++)
            {
                if (letterPrefabs[i].name == letter.ToString())
                {
                    indexOfLetter = i;
                }
            }
            letterPrefab = letterPrefabs[indexOfLetter];
        }

        //Spawn prefab add randomc position
        GameObject go = Instantiate(letterPrefab, new Vector3(Random.Range(minX
        , maxX + 1), transform.position.y+14,  0f), Quaternion.Euler(0, 0, Random.Range(-90F, 90F))) as GameObject;
        go.GetComponent<Fruit2D>().setLetter(letter);

       transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90f);

        bool isAppleGravity = go.name == "AppleGravity(Clone)";
        //If x position is over 0 go left
        //if (go.transform.position.x > 0)
        //{   
            //if(isAppleGravity)
            //{
            //    go.GetComponent<gravity>().applyForce(new Vector3( upForce, 0));

            //} else
            //{
        //        go.GetComponent<Rigidbody2D>().AddForce(new Vector2( upForce,0));
            //}
        //}
        //Else go right
        //else
        //{
        //    if (isAppleGravity)
        //    {
        //        go.GetComponent<gravity>().applyForce(new Vector3(upForce, 0));
        //    } else
        //    {
        //        go.GetComponent<Rigidbody2D>().AddForce(new Vector2(upForce,0));
        //    }
            
        //}
        //Start the spawn again
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
