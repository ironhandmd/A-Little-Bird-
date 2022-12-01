using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe_controller : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite newsprite;
    [SerializeField]
    GameObject firstChoices,safeCrackPanel,firstDig, secondDig,thirdDig, lastDig,safeFail;
    public int unlock = 0;
    public int attempts = 0;
    item_collision IC;
    PlayerMovement PM;
    item_controller ItemController;
    void Start()

    {
        
        PM =FindObjectOfType<PlayerMovement>();
        ItemController = FindObjectOfType<item_controller>();
        IC = FindObjectOfType<item_collision>();
        firstChoices.SetActive(false);
        safeCrackPanel.SetActive(false);
        firstDig.SetActive(false);
        secondDig.SetActive(false);
        thirdDig.SetActive(false);
        lastDig.SetActive(false);
        safeFail.SetActive(false);
    }

    public void activateFail()
    {
        PM.nowMove();
        firstChoices.SetActive(false);
        safeCrackPanel.SetActive(false);
        safeFail.SetActive(true);
        firstDig.SetActive(false);
        secondDig.SetActive(false);
        thirdDig.SetActive(false);
        lastDig.SetActive(false);
        PM.nowMove();
    }

    public void deactivateFail() 
    {
        safeFail.SetActive(false);
    }
    public void activateFirst() 
    {
        firstChoices.SetActive(true);
    
    }
    public void deactivateFirst() 
    {
        firstChoices.SetActive(false);
    }

    public void activatChoices()
    {
       
        safeCrackPanel.SetActive(true);
    }
    public void correctChoice1()
    {
        safeCrackPanel.SetActive(false);
        //firstChoices.SetActive(false);
        unlock++;
        Debug.Log(unlock);
        firstDig.SetActive(false);
        secondDig.SetActive(true);
    }
    public void correctChoice2()
    {
        unlock++;
        Debug.Log(unlock);
       
        secondDig.SetActive(false);
        thirdDig.SetActive(true);
     //   lastDig.SetActive(true);



    }
    public void correctChoice3()
    {
        unlock++;
        Debug.Log(unlock);
        thirdDig.SetActive(false);
        lastDig.SetActive(true);



    }

    public void correctChoice4()
    {
        Debug.Log(unlock);
        unlock++;
        lastDig.SetActive(false);
        if (unlock == 4)
        {
            spriteRenderer.sprite = newsprite;

            ItemController.getKey();
            PM.nowMove();
            IC.disableSafe();
            firstChoices.SetActive(false);
        }
    }
    public void incorrectChoice1()
    {
        Debug.Log(attempts);
        attempts++;
        firstChoices.SetActive(false);
        Debug.Log("incorrect");
        firstDig.SetActive(false);
        secondDig.SetActive(true);
        if (attempts == 3)
        {

            activateFail();
        }

    }

    public void incorrectChoice2()
    {
        Debug.Log(attempts);
        Debug.Log("incorrect");
        attempts++;
        secondDig.SetActive(false);
        thirdDig.SetActive(true);
        if (attempts == 3)
        {

            activateFail();
        }
    }
    public void incorrectChoice3()
    {
        Debug.Log("incorrect");
        Debug.Log(attempts);
        attempts++;
        thirdDig.SetActive(false);
        lastDig.SetActive(true);
        if (attempts==3) 
        {
          
            activateFail();
        }
    }
   
  
   }
