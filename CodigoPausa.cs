using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoPausa : MonoBehaviour
{
    public GameObject menupausa;
    private bool ismenu;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ismenu= !ismenu;
        }
        if(ismenu == true)
        {
            menupausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else
        {
            menupausa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }

    }
    public void Continuar()
    {
        menupausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        ismenu = false;
        Time.timeScale = 1;
    }
    public void Salir()
    {
        loandingview.nivelCarga("Inicio");
    }
}
