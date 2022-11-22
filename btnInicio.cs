using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnInicio : MonoBehaviour
{

    public void Escena()
    {
        loandingview.nivelCarga("Scene_A");
    }

    public void Salir()
    {
        Application.Quit();
    }
}

