using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public void ReproducirSonidos()
    {
        GetComponent<AudioSource>().Play();
    }
}
