using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lostgame : MonoBehaviour
{
    [SerializeField] private GameObject lostP;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            lostP.SetActive(true);
        }
    }
}
