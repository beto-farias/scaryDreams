using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NivelManager : MonoBehaviour
{


    public GameObject[] startPoints;
    public GameObject[] enemies;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
        CreateEnemy();
        CreateEnemy();
        CreateEnemy();
        CreateEnemy();
        CreateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CreateEnemy() {
        Debug.Log("Creando enemigo .... ");

        //Seleccion del punto de creacion
        int ran = Random.Range(0, startPoints.Length);

        Debug.Log("Start point " + ran);
        Debug.Log("Start point lem " + startPoints.Length);
        GameObject startPoint = startPoints[ran];

        //Seleccion del enemigo
        ran = Random.Range(0, enemies.Length);
        GameObject enemy = enemies[ran];



        //Creacion del enemigo
        NavMeshAgent agent = (Instantiate(enemy, startPoint.transform.position, new Quaternion()) as GameObject).GetComponent<NavMeshAgent>();
       
        //Asigna el destino del agente creado
        agent.SetDestination(target.transform.position);

     }
}
