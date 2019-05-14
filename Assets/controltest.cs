using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class controltest : MonoBehaviour {

    SerialPort serialPort =new SerialPort("COM6",9600);

	// Use this for initialization
	void Start () {
		serialPort.Open();
        serialPort.ReadTimeout = 1;
    }
	
	// Update is called once per frame
	void Update () {
		if (serialPort.IsOpen)
        {
            try
            {
                string value = serialPort.ReadLine();
                print(value);
              

            }
            catch
            {

            }
        }
	}
}
