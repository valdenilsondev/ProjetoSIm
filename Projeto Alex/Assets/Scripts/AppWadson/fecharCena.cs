using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fecharCena : MonoBehaviour
{
    public void CasaCoberta()
    {
        SceneManager.LoadScene("ArqCasaExterno");
    }
    
    public void CasaDescoberta()
    {
        SceneManager.LoadScene("ArqCasaInterno");
    }

    public void SairAplicativo()
    {
        Application.Quit();
    }

     public void Processo01()
    {
        SceneManager.LoadScene("Cena Sami - Pacheco 1");
    }

     public void Processo02()
    {
        SceneManager.LoadScene("Cena Sami - Pacheco 2");
    }

    public void Retornar()
    {
        SceneManager.LoadScene("Menu");
    }


}
