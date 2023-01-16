using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoConnect : MonoBehaviour
{
    #region Instancing
    public static ArduinoConnect Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ArduinoConnect>();
                if (_instance == null)
                {
                    _instance = new GameObject("ArduinoConnect").AddComponent<ArduinoConnect>();
                }
            }
            return _instance;
        }
    }
    private static ArduinoConnect _instance;
    public string value;
    public SerialPort stream = new SerialPort("COM4", 9600);
    private void Awake()
    {
        // Destroy any duplicate instances that may have been created
        if (_instance != null && _instance != this)
        {
            Destroy(this);
            return;
        }

        _instance = this;
    }
    #endregion
    void Start()
    {
        stream.Open();
        stream.ReadTimeout = 1;
    }
    void FixedUpdate()
    {
        if (stream.IsOpen)
        {
            try
            {
                value = stream.ReadLine();
               // Debug.Log(value);

            }
            catch (System.Exception)
            {

            }
        }

    }
   public void Update()
   {
           }

    public void CloseCom()
    {
        stream.Close();
    }
}
