using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movicanvas : MonoBehaviour
{

    public MovieTexture movie;

	void Start ()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        
    }

    void Update()
    {
        movie.Play();
    }
}
