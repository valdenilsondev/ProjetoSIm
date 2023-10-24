using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.AI;

public class comandosBasicos : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;

    public Transform posicaoDestino;

    public Transform posicaoDois;

    private Animator anim;

    public bool animacao;

    public Transform caixote;

    
    

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == posicaoDestino.position.x)
        {
            agent.SetDestination(posicaoDois.position);
        }else
        {
            agent.SetDestination(posicaoDestino.position);
        }

       


        
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "posicaoInicial")
        {
            anim.SetBool("iniciouMovimento", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "carga")
        {
            anim.SetBool("push", true);

            agent.speed = 1;

            caixote.parent = this.transform;
        }
    }

}
