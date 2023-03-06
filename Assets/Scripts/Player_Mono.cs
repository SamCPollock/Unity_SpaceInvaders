using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Player_Mono : MonoBehaviour
{
    [SerializeField] private float moveSpeed; 
    [SerializeField] private float shotCooldown;

    private float timeSinceLastShot = 0;
    private void Update()
    {
        HandleInput();
        timeSinceLastShot += Time.deltaTime;
    }


    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void MoveLeft()
    {
        gameObject.transform.position += new Vector3(-moveSpeed, 0, 0);
    }

    private void MoveRight()
    {
        gameObject.transform.position += new Vector3(moveSpeed, 0, 0);
    }

    private void Shoot()
    {
        if (timeSinceLastShot > shotCooldown)
        {
            Debug.Log("FIRING!");
            GameObject bullet = gameObject.GetComponent<ObjectPool_Mono>().GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = gameObject.transform.position;
                bullet.SetActive(true);
            }
            timeSinceLastShot = 0;
        }
    }
    
}
