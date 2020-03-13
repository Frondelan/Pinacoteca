using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Change : MonoBehaviour
{
    public void cambiarEscena(string nombre)
    {
        //Debug.Log(nombre);
        SceneManager.LoadScene(nombre);
    }
}
