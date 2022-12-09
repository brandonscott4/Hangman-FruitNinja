using System.Collections;
//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_items : MonoBehaviour
{

    public float spawnTime = 1; //Spawn Time
    public GameObject apple; //Apple prefab
    public GameObject bomb; //Bomb prefab
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
        char letter = rngObject.GetComponent<RandomWordGeneratorScript>().GetRandomOtherLetter();
        int indexOfLetter = -1;
        for(int i=0; i<letterPrefabs.Length; i++)
        {
            if (letterPrefabs[i].name == letter.ToString()){
                indexOfLetter = i;
            }
        }
        GameObject letterPrefab = letterPrefabs[indexOfLetter];

        //If random number is less than 30
        if (Random.Range(0, 100) < 30)
        {
            letter = rngObject.GetComponent<RandomWordGeneratorScript>().GetRandomRemainingLetter();
            for (int i = 0; i < letterPrefabs.Length; i++)
            {
                if (letterPrefabs[i].name == letter.ToString())
                {
                    indexOfLetter = i;
                }
            }
            letterPrefab = letterPrefabs[indexOfLetter];
        }

        //Spawn prefab add random position
        GameObject go = Instantiate(letterPrefab, new Vector3(Random.Range(minX
        , maxX + 1), transform.position.y+14,  0f), Quaternion.Euler(0, 0, Random.Range(-90F, 90F))) as GameObject;
        go.GetComponent<Letter2D>().Letter = letter;

        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90f);


        //Start the spawn again
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
