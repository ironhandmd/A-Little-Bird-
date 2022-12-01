using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event_controller : MonoBehaviour
{
    [SerializeField]
    GameObject alleyBlocker;
    [SerializeField]
    GameObject watch;
    [SerializeField]
    GameObject deliBlock;
    [SerializeField]
    GameObject hotSauceBottle;
    [SerializeField]
    GameObject globe;
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite newsprite;
    text_controller TC;
    PlayerMovement PM;
    [SerializeField]
    GameObject intro;
    CameraMovement CM;
    scene_manager SceneManager;

    void Start()
    {
        SceneManager = FindObjectOfType<scene_manager>();
        alleyBlocker.SetActive(true);
        deliBlock.SetActive(true);
        globe.SetActive(true);
        watch.SetActive(true);
        CM = FindObjectOfType<CameraMovement>();
        TC = FindObjectOfType<text_controller>();
        PM = FindObjectOfType<PlayerMovement>();
        PM.dontMove();
        intro.SetActive(true);
        hotSauceBottle.SetActive(true);
        StartCoroutine(deactivateIntro());
    }

    IEnumerator deactivateIntro() 
    {
        yield return new WaitForSeconds(3f);
       
        intro.SetActive(false);
       TC.activatePlayerTalk1();
      
    
    
    }

    public void goBackToScene() 
    {
        TC.deactivatePaper2();
        CM.moveToArea4();
        PM.nowMove();
    }

    public void openTheChest() 
    {
        
        spriteRenderer.sprite = newsprite;
    }

    public void removeGlobe() 
    {
        globe.SetActive(false);
       
    }

    public void getHotSauceBottle() 
    {
        hotSauceBottle.SetActive(false);
        TC.deactivateHotSaucePanel();
    }

    public void activateHotDogChoice() 
    {
        TC.activateFindHotDog();
    }

    public void removeDeliBlock() 
    {
        deliBlock.SetActive(false);
    }

    public void removeWatch() 
    {
        watch.SetActive(false);
    }

    public void removeAlleyBlocker() 
    {
        alleyBlocker.SetActive(false);
    }


    public void WinCondition() 
    {
        StartCoroutine(itemRecovered());
    }

    IEnumerator itemRecovered() 
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadNextScene();
    
    }





}
