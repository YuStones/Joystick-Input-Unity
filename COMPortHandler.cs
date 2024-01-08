using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class COMPortHandler : MonoBehaviour
{
    public GameObject Prefab;
    public TMP_InputField Port;
    // public TMP_InputField BaudRate;
    private SerialController ArdityInstance;
    private int parser;

    // Start is called before the first frame update
    void Start(){
        ArdityInstance = Prefab.GetComponent<SerialController>();
        Port.text = ArdityInstance.portName;
        // BaudRate.text = ArdityInstance.baudRate.ToString();
        LoadObject();
    }

    // Update is called once per frame
    void Update(){
    }

    public void LoadObject(){
        GameObject.Destroy(GameObject.FindGameObjectWithTag("Controlled"));
        GameObject.Instantiate(Prefab);
        Debug.Log(ArdityInstance.portName);
        Debug.Log(ArdityInstance.baudRate.ToString());
    }

    public void Reload(){
        try{
            ArdityInstance.portName = Port.text;
            // if(int.TryParse(BaudRate.text, out parser)){
            //     ArdityInstance.baudRate = int.Parse(BaudRate.text);
            // }   
            LoadObject(); 
        }catch(Exception){
            Debug.Log("Error");
        }
    }
}
