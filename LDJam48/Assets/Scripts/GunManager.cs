using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{

    public PlayerAmmo gunStats;
    public Camera fpsCamera;
    public ParticleSystem muzzleFlash;
    public ParticleSystem bloodImpact;
    public float impactForce = 30f;
    public int startingAmmo;

    public Animator gunRecoil;
    public Animator gunSlide;

    public bool isAR;

    private float nextFireTime = 0f;
    private float nextMeleeTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        gunStats.currentAmmo = startingAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAR)
        {
            if (gunStats.currentAmmo > 0)
            {
                if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
                {
                    nextFireTime = Time.time + gunStats.gunROF;
                    ShootGun();
                }
            }
        }
        else
        {
            if (gunStats.currentAmmo > 0)
            {
                if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime && Time.time >= nextMeleeTime)
                {
                    nextFireTime = Time.time + gunStats.gunROF;
                    ShootGun();
                }
            }
            if (Input.GetButtonDown("Fire2") && Time.time >= nextMeleeTime && Time.time >= nextMeleeTime)
            {
                nextMeleeTime = Time.time + gunStats.meleeRate;
                MeleeGun();
            }
        }
        
    }

    void ShootGun()
    {
        if (!isAR)
        {
            gunRecoil.SetTrigger("Activate");
            gunSlide.SetTrigger("Activate");
        }
        muzzleFlash.Play();
        gunStats.currentAmmo--;
        RaycastHit hit;
        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, gunStats.gunRange))
        {
            EnemyHealth enemy = hit.transform.GetComponent < EnemyHealth > ();
            if (enemy != null)
            {
                enemy.TakeDamage(gunStats.gunDamage);
                
                Instantiate(bloodImpact, hit.point, Quaternion.LookRotation(hit.normal));
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * impactForce);
                }
            }

            
        }
    }

    void MeleeGun()
    {
        if (!isAR)
        {
            gunRecoil.SetTrigger("Melee");
        }
        StartCoroutine(MeleeDelay());
       
    }

    IEnumerator MeleeDelay()
    {
        yield return new WaitForSeconds(0.2f);
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, 3f))
        {
            EnemyHealth enemy = hit.transform.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(gunStats.gunDamage);

                Instantiate(bloodImpact, hit.point, Quaternion.LookRotation(hit.normal));
                if (hit.rigidbody != null)
                {
                  //  hit.rigidbody.AddForce(-hit.normal * impactForce);
                }
            }

        }
        
    }
}
