using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class logiclight : MonoBehaviour
{
    public GameObject LightFlash;
    public Slider battery;
    public float batteryLevel = 100f;
    private bool isFlashOn;
    [SerializeField] private float drainRate = 1f;
 
    void Start()
    {
        LightFlash.SetActive(false);
        isFlashOn = false;
        battery.maxValue = 100f;
        battery.value = batteryLevel;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && batteryLevel > 0){
            LightFlash.SetActive(true);
            isFlashOn = true;            
        }
        if(Input.GetKeyDown(KeyCode.V)){
            LightFlash.SetActive(false);
            isFlashOn = false;
        }
        if(isFlashOn && batteryLevel > 0){
            batteryLevel -= drainRate * Time.deltaTime;
            if(batteryLevel <= 0){
              batteryLevel = 0;
                LightFlash.SetActive(false);
                isFlashOn = false;
            }
        }
        battery.value = batteryLevel; 
    }
    

}
