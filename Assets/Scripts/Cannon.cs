using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;    
    public GameObject DoubleBullet;
    public GameObject TripleBullet;
    public GameObject QuadBullet;
    public bool canShoot = true;
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
                    }

        if (Input.GetKeyDown(KeyCode.J))
        {
            DoubleShoot();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            TripleShoot();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            QuadShoot();
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void DoubleShoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(DoubleBullet, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void TripleShoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(TripleBullet, transform);
            Invoke("ResetShoot", 1f);
        }
    }

    private void QuadShoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(QuadBullet, transform);
            Invoke("ResetShoot", 1f);
        }
    }



    private void ResetShoot()
    {
        canShoot = true;
    }
}
