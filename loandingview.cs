using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class loandingview 
{
    public static string signivel;

    public static void nivelCarga(string Nombre)
    {
        signivel = Nombre;
        SceneManager.LoadScene("LoadView");
    }
}
