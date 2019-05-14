using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparecerYDesaparecer : MonoBehaviour
{

    public void Aparecer_Desaparecer(GameObject OnjetoADesaparecer)
    {
        if (OnjetoADesaparecer.activeSelf == true)
        {
            OnjetoADesaparecer.SetActive(false);
        }
        else
        {
            OnjetoADesaparecer.SetActive(true);
        }
    }
}
