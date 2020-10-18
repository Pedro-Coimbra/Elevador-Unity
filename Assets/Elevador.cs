using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public GameObject plataforma;
    public GameObject botao_subir;
    public GameObject botao_descer;
    public GameObject panelSubir;
    public GameObject panelDescer;
    private bool subindo = false;
    private bool descendo = false;

    void Start()
    {
        panelSubir.SetActive(false);
        panelDescer.SetActive(false);
    }

    void Update()
    {
        Subir();
        Descer();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "botao_subir")
        {
            panelSubir.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                subindo = true;
            }

        }
        if (other.gameObject.tag == "botao_descer")
        {
            panelDescer.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                descendo = true;
            }

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "botao_subir")
        {
            panelSubir.SetActive(false);
        }
        if (other.gameObject.tag == "botao_descer")
        {
            panelDescer.SetActive(false);
        }
    }
    private void Subir()
    {
        if (subindo == true && plataforma.transform.position.y < 5)
        {
            plataforma.transform.position += plataforma.transform.up * Time.deltaTime;
        }   else {
            subindo = false;
        }
    }
    private void Descer()
    {
        if (descendo == true && plataforma.transform.position.y > 0)
        {
            subindo = false;
            plataforma.transform.position += plataforma.transform.up * -Time.deltaTime;
        } else {
            descendo = false;
        }
    }

}
