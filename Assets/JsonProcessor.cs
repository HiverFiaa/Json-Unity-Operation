using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonProcessor : MonoBehaviour {

	public EnvironmentalMonitoring envirdata;
    private float time;

	// Use this for initialization
	void Start () {
		envirdata = new EnvironmentalMonitoring ();
        time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > 10)
        {
            updateEnvirData();
            Debug.Log(JsonUtility.ToJson(envirdata)+"\n______________________\n"+JsonUtility.FromJson<EnvironmentalMonitoring>(JsonUtility.ToJson(envirdata)).dataType);

        }
	}

	void updateEnvirData(){
        envirdata.dataType = true ? "initial" : null;

	}


}

[System.Serializable]
public class EnvironmentalMonitoring
{
	public string dataType;
	public float temperature, humidity, PM25, CO, PM10, NO2, SO2, O3, waterLevel, rainfallIntensity;


}