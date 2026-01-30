using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent agent;

    [SerializeField]
    Animator animator;

    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public float velocidadDelMovimiento = 0;

    



    void Start()
    {
        animator = GetComponent<Animator>();


    }

    void Update()
    {
        PersonajeMove();
    }

    public void PersonajeMove()
    {

        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadDelMovimiento;
        movimientoEjeX = Input.GetAxis("Vertical") * Time.deltaTime * velocidadDelMovimiento;


        transform.Translate(movimientoEjeZ, movimientoEjeY, movimientoEjeX);


        if (movimientoEjeZ != 0 || movimientoEjeX != 0)
        {
            animator.SetBool("RUN", true);
        }
        else
        {
            Debug.Log("Te paras");
            animator.SetBool("RUN", false);
        }
    }
}
