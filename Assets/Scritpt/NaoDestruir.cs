using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaoDestruir : MonoBehaviour
{
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
}
