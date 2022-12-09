using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class jsonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveToJSON()
    {   
        //creates new instance of saveData
        saveData data = new saveData();
        //sets the instances values to the current games xp and shop contents
        data.shopContentsData = ShopManager.shopContents;
        data.xpData = Experience_Script.xpValue;

        //JsonUtility converts our instance to json
        string json = JsonUtility.ToJson(data, true);
        //writes the new json to the file specified
        File.WriteAllText(Application.dataPath + "/saveData.json", json);
    }

    public int[] loadFromJSON()
    {
        //reads in the json from file specified
        string json = File.ReadAllText(Application.dataPath + "/saveData.json");
        //new saveData instance using JsonUtility to convert from Json to our saveData
        saveData data = JsonUtility.FromJson<saveData>(json);
        Experience_Script.xpValue = data.xpData;
        return data.shopContentsData;
    }
}
