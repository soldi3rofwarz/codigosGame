using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoRandom : MonoBehaviour
{
    public float velMov, velRot;
    int  movimiento;
    float tiempoReaccion = 10.8f;
    bool espera, camina, gira;

    private void Start()
    {
        Accion();
    }

    private void Update()
    {
        if (espera)
        {

        }
        if (camina)
        {
            transform.position +=(transform.forward * velMov* Time.deltaTime);
        }
        if (gira)
        {
            transform.Rotate(Vector3.up * velRot * Time.deltaTime);
        }
    }
    void Accion()
    {
        movimiento = Random.Range(1, 4);

        if (movimiento== 1)
        {
            camina = true;
            espera= false;
        }
        if (movimiento==2)
        {
            espera = true;
            camina = false;
        }
        if (movimiento==3)
        {
            gira = true;
            StartCoroutine(TiempoGiro());
        }

        Invoke("Accion",tiempoReaccion);
    }
    IEnumerator TiempoGiro()
    {
        yield return new WaitForSeconds(2);
        gira = false;
    }
}
