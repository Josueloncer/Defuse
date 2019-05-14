using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaTiempo : MonoBehaviour
{

    public float TiempoDeVideo;
    public string EscenaSiguiente;


    void Update ()
    {
        TiempoDeVideo -= Time.deltaTime * 1;
        if (TiempoDeVideo <= 0)
        {
            SceneManager.LoadScene(EscenaSiguiente);
        }
	}
}
