using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoChange : MonoBehaviour
{
    Color myStartColor, sColor;//Variaveis que guardam a cor padrao do objeto e a cor para alterar
    private void Start()
    {
        myStartColor = GetComponent<MeshRenderer>().material.color;//pega a cor original
        sColor = Color.blue;//define a cor de quando estiver "colidindo"
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            GetComponent<MeshRenderer>().material.color = sColor;//entrou no trigger
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            GetComponent<MeshRenderer>().material.color = myStartColor;//saiu do trigger
        }
    }
}
