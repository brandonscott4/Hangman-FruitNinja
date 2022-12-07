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
        saveData data = new saveData();
        data.shopContentsData = ShopManager.shopContents;
        data.xpData = Experience_Script.xpValue;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/saveData.json", json);
    }

    public void loadFromJSON()
    {
        string json = File.ReadAllText(Application.dataPath + "/saveData.json");
        saveData data = JsonUtility.FromJson<saveData>(json);
       // Debug.Log(data.shopContentsData[1,1]);
        ShopManager.shopContents = data.shopContentsData;
        Experience_Script.xpValue = data.xpData;


    }
}
