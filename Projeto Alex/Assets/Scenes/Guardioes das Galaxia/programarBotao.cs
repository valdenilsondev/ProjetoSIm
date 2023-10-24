using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class programarBotao : MonoBehaviour
{

    public string nomeCena;

    public void iniciarAplicativo()
    {
        SceneManager.LoadScene(nomeCena);
    }

}
