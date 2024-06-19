using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
   [SerializeField] private GameObject startPanel;
   [SerializeField] private GameObject winPanel;
   [SerializeField] private GameObject lostPanel;
   
   private void Start()
   {
      startPanel.SetActive(true);
      winPanel.SetActive(false);
      lostPanel.SetActive(false);
   }

   public void LoadGame()
   {
     
      startPanel.SetActive(false);
     
   }

   public void Try()
   {
       SceneManager.LoadScene(0);
   }
}
