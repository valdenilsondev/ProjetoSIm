using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class GA : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject cubeAni;
    public bool ativarAcao;
    public float velocidade;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("GA");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        
    }

    private void Update()
    {
        if(ativarAcao == true)
        {
            cubeAni.transform.Rotate(new Vector3(0, -1, 0) * 50 * Time.deltaTime);

        }
        if(ativarAcao == false)
        {
            cubeAni.transform.Rotate(new Vector3(0, 0, 0) * 0 * Time.deltaTime);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ativarAcao = true;


       
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ativarAcao = false;
        
    }
}