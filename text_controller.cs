using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_controller : MonoBehaviour
{
    PlayerMovement PM;
    event_controller EC;
    [SerializeField]GameObject playerTalk1, trashPanel,gotHammer,coffeeMug,officeDrawer, gotCoffee, coffeeRushedPanel,dizzy,talkingBird
        ,paper1,npcTalkStore,npcHatMan,npcOM,globePanel, chestPanel,npcWoman,paper2, hotsaucePanel,hotdogButton,npcTalkStore2,npcHatMan2,npcHatMan3,
        pocketWatch,npcOM2,fedBird,npcWoman2;
    
    void Start()
    {
        EC = FindObjectOfType<event_controller>();
        PM = FindObjectOfType<PlayerMovement>();
       dizzy.SetActive(false);
       playerTalk1.SetActive(false);
       trashPanel.SetActive(false);
       gotHammer.SetActive(false);
       coffeeMug.SetActive(false);
       officeDrawer.SetActive(false);
       gotCoffee.SetActive(false);
       coffeeRushedPanel.SetActive(false);
       talkingBird.SetActive(false);
       paper1.SetActive(false);
       npcTalkStore.SetActive(false);
       npcHatMan.SetActive(false);
       npcOM.SetActive(false);
       globePanel.SetActive(false);
       chestPanel.SetActive(false);
       npcWoman.SetActive(false);
       paper2.SetActive(false);
       hotsaucePanel.SetActive(false);
       hotdogButton.SetActive(false);
       npcTalkStore2.SetActive(false);
       npcHatMan2.SetActive(false);
       npcHatMan3.SetActive(false);
       pocketWatch.SetActive(false);
       npcOM2.SetActive(false);
       fedBird.SetActive(false);
       npcWoman2.SetActive(false);
    }


    public void activatePlayerTalk1()
    {
        
        playerTalk1.SetActive(true);
    }
    public void deactivatePlayerTalk1()
    {
        PM.nowMove();
        playerTalk1.SetActive(false);
    }

    public void activateTrashPanel()
    {
        PM.dontMove();
        trashPanel.SetActive(true);
    }
    public void deactivateTrashPanel()
    {
        PM.nowMove();
        trashPanel.SetActive(false);
    }

    public void activateGotHammer()
    {
        trashPanel.SetActive(false);
        gotHammer.SetActive(true);
    }
    public void deactivateGotHammer()
    {
        gotHammer.SetActive(false);
        PM.nowMove();
    }

    public void activateCoffeeMug() 
    {
        coffeeMug.SetActive(true);
    }

    public void deactivateCoffeeMug()
    {
        coffeeMug.SetActive(false);
        PM.nowMove();
    }

    public void activateOfficeDrawer() 
    {
        officeDrawer.SetActive(true);
    }

    public void deactivateOfficeDrawer()
    {
        officeDrawer.SetActive(false);
        PM.nowMove();
    }

    public void activateGotCoffee()
    {
        deactivateOfficeDrawer();
        PM.dontMove();
        gotCoffee.SetActive(true);
    }
    public void deactivateGotCoffee()
    {
        gotCoffee.SetActive(false);
        PM.nowMove();
    }

    public void activateCoffeRushedPanel()
    {
        PM.dontMove();
        coffeeRushedPanel.SetActive(true);
    }
    public void deactivateCoffeRushedPanel()
    {
        coffeeRushedPanel.SetActive(false);
        PM.nowMove();
    }


    public void activateDizzy() 
    {
        dizzy.SetActive(true);
    }
    public void deactivateDizzy()
    {
        dizzy.SetActive(false);
        PM.nowMove();
    }
    public void activateTalkingBird() 
    {
        talkingBird.SetActive(true);
    }

    public void deactivateTalkingBird()
    {
        talkingBird.SetActive(false);
        PM.nowMove();
    }

    public void activatePaper1Panel() 
    {
        paper1.SetActive(true);
    }
    public void deactivatePaper1Panel()
    {
        paper1.SetActive(false);
        PM.nowMove();
    }

    public void activateNPCTalkStore() 
    {
        npcTalkStore.SetActive(true);
    }
    public void deactivateNPCTalkStore()
    {
        npcTalkStore.SetActive(false);
        PM.nowMove();
    }

    public void activateNPCHatMan() 
    {
        npcHatMan.SetActive(true);
    }
    public void deactivateNPCHatMan()
    {
        npcHatMan.SetActive(false);
        PM.nowMove();
    }

    public void activateNPCOld() 
    {
        npcOM.SetActive(true);
    }
    public void deactivateNPCOld()
    {
        npcOM.SetActive(false);
        PM.nowMove();
    }
    public void activateGlobe() 
    {
        globePanel.SetActive(true);
    }

    public void deactivateGlobe()
    {
        globePanel.SetActive(false);
        PM.nowMove();
    }

    public void activateChestPanel() 
    {
        chestPanel.SetActive(true);
    }
    public void deactivateChestPanel()
    {
        chestPanel.SetActive(false);
        PM.nowMove();
    }

    public void activateWomanPanel() 
    {
        npcWoman.SetActive(true);
    }
    public void deactivateWomanPanel()
    {
        npcWoman.SetActive(false);
        PM.nowMove();
    }

    public void activatePaper2() 
    {
        paper2.SetActive(true);
    }
    public void deactivatePaper2()
    {
        paper2.SetActive(false);
        PM.nowMove();
    }


    public void activateHotSaucePanel()
    {
        hotsaucePanel.SetActive(true);
    
    }
    public void deactivateHotSaucePanel()
    {
        hotsaucePanel.SetActive(false);
        PM.nowMove();
    }
    public void activateFindHotDog() 
    {
        hotdogButton.SetActive(true);
    
    }

    public void deactivateFindHotDog()
    {

        hotdogButton.SetActive(false);
        PM.nowMove();
    }

    public void activateNPCTalkStore2()
    {
        PM.dontMove();
        deactivateNPCTalkStore();
        npcTalkStore2.SetActive(true);
    }
    public void deactivateNPCTalkStore2()
    {
        npcTalkStore2.SetActive(false);
       
        npcTalkStore2.SetActive(false);
        PM.nowMove();
    }

    public void activateNPCHatMan2()
    {
        npcHatMan.SetActive(false);
        npcHatMan2.SetActive(true);
    }
    public void activateNPCHatMan3()
    {
        npcHatMan2.SetActive(false);
        npcHatMan3.SetActive(true);
    }
    public void deactivateNPCHatMan3()
    {
        EC.activateHotDogChoice();
        npcHatMan2.SetActive(false);
        npcHatMan3.SetActive(false);
        PM.nowMove();
    }

    public void activatePocketWatchPanel() 
    {
        pocketWatch.SetActive(true);
    }
    public void deactivatePocketWatchPanel()
    {
        pocketWatch.SetActive(false);
        PM.nowMove();
    }

    public void activateNPCOM2() 
    {

        npcOM2.SetActive(true);
    }

    public void deactivateNPCOM2()
    {
        npcOM2.SetActive(false);
        PM.nowMove();

    }

    public void activateFedBird() 
    {
        fedBird.SetActive(true);
    }

    public void deactivateFedBird()
    {
        fedBird.SetActive(false);
        PM.nowMove();
    }

    public void activateNPCWoman2() 
    {
        npcWoman2.SetActive(true);
    } 

    public void deactivateNPCWoman2()
    {

        npcWoman2.SetActive(false);
        PM.nowMove();
    }


}





