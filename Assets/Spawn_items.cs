using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_items : MonoBehaviour
{

    public float spawnTime = 1; //Spawn Time
    public GameObject apple; //Apple prefab
    public GameObject bomb; //Bomb prefab
    public float upForce = 750; //Up force
    public float leftRightForce = 200; //Left and right force
    public float maxX = -7; //Max x spawn position
    public float minX = 7; //Min x spawn position


    // Start is called before the first frame update
    void Start()
    {
        //Start the spawn update
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        //Wait spawnTime
        yield return new WaitForSeconds(spawnTime);
        //Spawn prefab is apple
        GameObject prefab = apple;
        //If random is over 30
        if (Random.Range(0, 100) < 30)
        {
            //Spawn prefab is bomb
            //you code here later in task 4
            prefab = bomb;
        }
        //Spawn prefab add randomc position
        GameObject go = Instantiate(prefab, new Vector3(Random.Range(minX
        , maxX + 1), transform.position.y, 0f), Quaternion.Euler(0, 0, Random.Range(-
        90F, 90F))) as GameObject;

        bool isAppleGravity = go.name == "AppleGravity(Clone)";
        //If x position is over 0 go left
        if (go.transform.position.x > 0)
        {   
            if(isAppleGravity)
            {
                go.GetComponent<gravity>().applyForce(new Vector3(-leftRightForce, upForce, 0));

            } else
            {
                go.GetComponent<Rigidbody2D>().AddForce(new Vector2(-
                leftRightForce, upForce));
            }
        }
        //Else go right
        else
        {
            if (isAppleGravity)
            {
                go.GetComponent<gravity>().applyForce(new Vector3(leftRightForce, upForce, 0));
            } else
            {
                go.GetComponent<Rigidbody2D>().AddForce(new Vector2(leftRightForce, upForce));
            }
            
        }
        //Start the spawn again
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
