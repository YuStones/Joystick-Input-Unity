using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int ratioX = 100;
    public int ratioZ = 100;
    private int data;
    private int positionX;
    private int positionZ;
    private int parser;
    // Start is called before the first frame update
    void Start()
    {
        data = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }

    void OnMessageArrived(string msg)
    {
        if (msg != ""){
            // Debug.Log(msg);
            if(int.TryParse(msg, out parser)){
                data = int.Parse(msg);
            }
            if(data >= 1210000 && data < 1220000){
                positionX = (data - 1210000) / ratioX;
            }
            if(data >= 1220000 && data < 1230000){
                positionZ = (data - 1220000) / ratioZ;
            }
            transform.position = new Vector3(positionX, 0, positionZ);
        }
    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        if(success){
            Debug.Log("Success");
        }else{
            Debug.Log("Failed");
        }
    }
}
