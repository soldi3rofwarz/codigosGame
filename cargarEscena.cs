using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cargarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string CargarNivel = loandingview.signivel;
        StartCoroutine(IniciarCarga(CargarNivel));
    }

    IEnumerator IniciarCarga(string nivel)
    {
        AsyncOperation operacion = SceneManager.LoadSceneAsync(nivel);
        operacion.allowSceneActivation = true;
        yield return null;
    }
}
