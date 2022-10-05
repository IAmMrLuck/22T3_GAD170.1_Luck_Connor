using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{
    [SerializeField] private float porridgeTemperature = 85f;

    private float hotLimitTemperature = 70.0f;
    private float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        porridgeTemperature -= Time.deltaTime * 5f;
    }

    // Update is called once per frame
    void TemperatureTest()
    {
        if (porridgeTemperature > hotLimitTemperature)
        {
            Debug.Log("The porridge is too hot. " + (int)porridgeTemperature +"`C.");
        }
        else if (porridgeTemperature < coldLimitTemperature)
        {
            Debug.Log("The porrodidge is too cold. " + (int)porridgeTemperature +"`C.");
        
        }
        else if (porridgeTemperature == 55f)
        {
            Debug.Log("The Porridge is Perfect. " + (int)porridgeTemperature +"`C.");
        }
        else
        {
            Debug.Log("This porridge is just right. "+ (int)porridgeTemperature +"`C.");
        }
    }
}
