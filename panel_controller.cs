using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_controller : MonoBehaviour
{
    PlayerMovement PM;
    [SerializeField]
    GameObject panel1;
    void Start()
    {
        PM = FindObjectOfType<PlayerMovement>();
        panel1.SetActive(false);
    }

    public void activatePanel1() 
    {
        PM.dontMove();
        panel1.SetActive(true);
    }
    public void deactivatePanel1()
    {
        PM.nowMove();
        panel1.SetActive(false);
    }
}
