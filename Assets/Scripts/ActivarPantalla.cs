using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarPantalla : MonoBehaviour
{

    public float TiempoDeVideo;
    public GameObject Pantalla;


    void Update ()
    {
        TiempoDeVideo -= Time.deltaTime * 1;
        if (TiempoDeVideo <= 0)
        {
            Pantalla.SetActive(true);
        }
	}
}
