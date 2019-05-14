using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class QuitarVideo : MonoBehaviour
{

    public float TiempoParaQuitarVideo;
    public GameObject _Canvas;
    public GameObject VideoControlerObj;
    public VideoClip[] Video;
    public VideoPlayer VideoControler;
    private string EscenaSiguiente;
    private bool IniciarTiempo = false;

    void OnStart()
    {
        VideoControler.GetComponent<VideoPlayer>();
    }

    void Update ()
    {
        if (IniciarTiempo == true)
        {
            TiempoParaQuitarVideo -= Time.deltaTime * 1;
            Debug.Log(TiempoParaQuitarVideo);
            if (TiempoParaQuitarVideo <= 0)
            {
                SceneManager.LoadScene(EscenaSiguiente);
            }
        }
    }

    public void ReproducirVideo(int VideoNum)
    {
        VideoControlerObj.SetActive(true);
        VideoControler.clip = Video[VideoNum];
        VideoControler.Play();
        IniciarTiempo = true;
        _Canvas.SetActive(false);
    }

    public void NombreDeProxEscena(string NomProxEscena)
    {
        EscenaSiguiente = NomProxEscena;
    }

}
