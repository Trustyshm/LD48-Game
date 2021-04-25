using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class AIMovement : MonoBehaviour
{

    public List<Transform> patrolSpots = new List<Transform>();
    private Transform playerTarget;
    private NavMeshAgent thisNavAgent;
    private bool patrolingArea;
    private bool activePatrol;
    public float attackRadius;
    public float meleeRadius;
    public int enemyDamage;
    public ParticleSystem bloodImpact;

    private bool doingMelee;
    private EnemyHealth enemyHealth;

    public Animator corruptedAnimator;

    private bool notDead;


    // Start is called before the first frame update
    void Start()
    {
        notDead = true;
        enemyHealth = GetComponent<EnemyHealth>();
        thisNavAgent = GetComponent<NavMeshAgent>();
        playerTarget = GameObject.FindGameObjectWithTag("thePlayer").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth.enemyHealth <= 0)
        {
            enemyHealth.enemyHealth = 0;
            doingMelee = true;
            thisNavAgent.speed = 0;
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            thisNavAgent.isStopped = true;
            corruptedAnimator.SetTrigger("Die");
            notDead = false;
        }

        if (notDead)
        {
            corruptedAnimator.SetFloat("Speed", thisNavAgent.speed);

            if (!doingMelee)
            {
                if (Vector3.Distance(playerTarget.position, transform.position) > attackRadius && !activePatrol)
                {
                    patrolingArea = true;
                    activePatrol = true;
                    PatrolArea();
                }

                if (Vector3.Distance(playerTarget.position, transform.position) <= attackRadius)
                {
                    patrolingArea = false;
                    attackRadius = 50;
                    thisNavAgent.destination = playerTarget.transform.position;
                    if (Vector3.Distance(playerTarget.position, transform.position) <= meleeRadius)
                    {
                        AttackPlayer();
                    }
                }



                if (patrolingArea)
                {
                    if (!thisNavAgent.pathPending)
                    {
                        if (!thisNavAgent.hasPath || thisNavAgent.velocity.sqrMagnitude == 0f)
                        {

                            PatrolArea();
                        }
                    }
                }
            }
        }

        
       
    }

    private void PatrolArea()
    {

        int patrolSelected = Random.Range(1, patrolSpots.Count + 1);
        thisNavAgent.SetDestination(patrolSpots[patrolSelected - 1].position);
    }

    private void AttackPlayer()
    {
        //Debug.Log("Attacking Player");
        //Melee Animation
        corruptedAnimator.SetTrigger("Attack");
        doingMelee = true;
        StartCoroutine(MeleeDelay());
 
    }

    IEnumerator MeleeDelay()
    {
        yield return new WaitForSeconds(0.5f);



        RaycastHit hit;
        if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit, 5f))
        {
            Debug.Log("Damage!");
            PlayerHealthController playerHealth = hit.transform.GetComponent<PlayerHealthController>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(enemyDamage);

                Instantiate(bloodImpact, hit.point, Quaternion.LookRotation(hit.normal));

                
            }

        }

        yield return new WaitForSeconds(0.2f);
        doingMelee = false;



    }

}
