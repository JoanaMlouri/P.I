using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour
{
    [SerializeField] private string NomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMeniInicial;
    public void Play()
    {
        SceneManager.LoadScene(NomeDoLevelDeJogo);
    }
}
