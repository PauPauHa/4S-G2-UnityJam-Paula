using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Win : MonoBehaviour
{
   [SerializeField] private GameObject winPanel;

  

   public void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player"))
      {
         winPanel.SetActive(true);
         Debug.Log("win");
      }
   }
   
}
