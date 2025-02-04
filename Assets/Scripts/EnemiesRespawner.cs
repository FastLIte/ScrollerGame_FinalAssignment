﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesRespawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            GameObject.FindObjectOfType<Enemy>().isInView = false;
            float originalX = collision.transform.position.x;
            Debug.Log("Enemy triggered" + collision.gameObject);
            if (collision.gameObject.transform.position.x > 14 || collision.gameObject.transform.position.x < -14)
            {
                collision.gameObject.transform.position = new Vector3(0 + Random.Range(-5f, 5f), transform.position.y + Random.Range(30f, 40f), 0);
            }
            else
            {
                collision.gameObject.transform.position = new Vector3(originalX + Random.Range(-3f, 3f), transform.position.y + Random.Range(20f, 40f), 0);
            }

        }
    }
    
    
}
