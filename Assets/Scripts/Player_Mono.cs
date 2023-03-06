using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Player_Mono : MonoBehaviour
{
    private void Update()
    {
        HandleInput();
    }


    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void MoveLeft()
    {
        
    }

    private void MoveRight()
    {
        
    }

    private void Shoot()
    {
        
    }
    
}
