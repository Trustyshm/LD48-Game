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

    public bool isCreeper;

    public AudioSource audioSource;
    public AudioClip meleeSound;

    private AudioSource myAudio;
    public AudioClip moanOne;
    public AudioClip moanTwo;
    public AudioClip moanThree;

    public bool isSlime;
    public AudioClip slimeVoice;

    private bool doOnce;

    private float timerVoice;


    // Start is called before the first frame update
    void Start()
    {
        myAudio = this.gameObject.GetComponent<AudioSource>();
        notDead = true;
        enemyHealth = GetComponent<EnemyHealth>();
        thisNavAgent = GetComponent<NavMeshAgent>();
        playerTarget = GameObject.FindGameObjectWithTag("thePlayer").transform;
        timerVoice = Random.Range(6, 20);
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
            this.GetComponent<CapsuleCollider>().enabled = false;
            thisNavAgent.isStopped = true;
            corruptedAnimator.SetTrigger("Die");
            notDead = false;
        }

        /*
        if (enemyHealth.enemyHealth > 0)
        {
            timerVoice -= Time.deltaTime;
            if(timerVoice <= 0)
            {
                float line = Random.value;

                if (line < 0.33)
                {
                    myAudio.PlayOneShot(moanOne);
                }
                if(line >= 0.33 && line < 0.66)
                {
                    myAudio.PlayOneShot(moanTwo);
                }
                if(line >= 0.66)
                {
                    myAudio.PlayOneShot(moanThree);
                }
                Random.InitState(System.DateTime.Now.Millisecond);
                timerVoice = Random.Range(6, 20);

            }

     
        }*/

        if (notDead)
        {
            corruptedAnimator.SetFloat("Speed", thisNavAgent.speed);

            if (!doingMelee)
            {
                if (Vector2.Distance(new Vector2(playerTarget.position.x, playerTarget.position.z), new Vector2(transform.position.x, transform.position.z)) > attackRadius && !activePatrol)
                {
                    patrolingArea = true;
                    activePatrol = true;
                    PatrolArea();
                }

                if (Vector2.Distance(new Vector2(playerTarget.position.x, playerTarget.position.z), new Vector2(transform.position.x, transform.position.z)) <= attackRadius)
                {
                    patrolingArea = false;
                    attackRadius = 50;
                    thisNavAgent.destination = playerTarget.transform.position;
                    if (Vector3.Distance(playerTarget.position, transform.position) <= meleeRadius)
                    {
                        AttackPlayer();
                        if (isSlime && !doOnce)
                        {
                            audioSource.PlayOneShot(slimeVoice);
                            doOnce = true;
                        }
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
        if (isCreeper)
        {
            int attackType = Random.Range(1, 2);
            if (attackType == 1)
            {
                corruptedAnimator.SetTrigger("Attack");
                //audioSource.PlayOneShot(meleeSound);
            }
            if (attackType == 2)
            {
                corruptedAnimator.SetTrigger("Attack2");
                //audioSource.PlayOneShot(meleeSound);
            }
        }
        else {
            corruptedAnimator.SetTrigger("Attack");
            //audioSource.PlayOneShot(meleeSound);
        }

        
        doingMelee = true;
        //StartCoroutine(MeleeDelay());
 
    }

    public void MeleePassthrough()
    {
        StartCoroutine(MeleeDelay());
    }

    IEnumerator MeleeDelay()
    {
        //yield return new WaitForSeconds(1.8f);



        RaycastHit hit;
        if (Physics.Raycast(this.transform.position, transform.forward, out hit, 5f))
        {
            
            //Debug.Log("Damage from: " + transform.name) ;
            Debug.Log(hit.transform.name);
            PlayerHealthController playerHealth = hit.transform.GetComponent<PlayerHealthController>();
            if (playerHealth != null)
            {
                Debug.Log("Passing");
                playerHealth.TakeDamage(enemyDamage);

                Instantiate(bloodImpact, hit.point, Quaternion.LookRotation(hit.normal));

                
            }

        }

        yield return new WaitForSeconds(0.2f);
        doingMelee = false;



    }

}
