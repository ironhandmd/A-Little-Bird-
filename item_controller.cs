using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_controller : MonoBehaviour
{
 
    item_collision ItemCollision;
    inventory Inventory;
    public GameObject itemButton,itemButton2,itemButton3,itemButton4,itemButton5,itemButton6,itemButton7,itemButton8,itemButton9;
    event_controller EC;
    text_controller TC;
   
    void Start()
    {
        EC = FindObjectOfType<event_controller>();
        ItemCollision = FindObjectOfType<item_collision>();
 
        TC = FindObjectOfType<text_controller>();
    
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
 
        
    }

 
    public void getItem()
    {
        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton, Inventory.slots[i].transform, false);
              
                break;
               

            }
        }
       
        TC.activateGotHammer();
        ItemCollision.disableTrash();
  
    }

  

    public void getItem2()
    {
        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton2, Inventory.slots[i].transform, false);

                break;


            }
        }
        TC.activateGotCoffee();
  
        ItemCollision.disableDrawer();
    
    }

    public void getItem3() 
    {

        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton3, Inventory.slots[i].transform, false);

                break;


            }
        }
    
    
    
    
    }
    public void getItem4()
    {

        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton4, Inventory.slots[i].transform, false);

                break;


            }
        }
    }
         public void getHotSauce()
    {

        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton5, Inventory.slots[i].transform, false);

                break;


            }
        }

        EC.getHotSauceBottle();


    }
         public void getHotDog()
         {

             for (int i = 0; i < Inventory.slots.Length; i++)
             {
                 if (Inventory.isFull[i] == false)
                 {
                     Inventory.isFull[i] = true;
                     Instantiate(itemButton6, Inventory.slots[i].transform, false);

                     break;


                 }
             }

            // EC.getHotSauceBottle();


         }
         public void getBirdFeed()
         {

             for (int i = 0; i < Inventory.slots.Length; i++)
             {
                 if (Inventory.isFull[i] == false)
                 {
                     Inventory.isFull[i] = true;
                     Instantiate(itemButton7, Inventory.slots[i].transform, false);

                     break;


                 }
             }

          //   EC.getHotSauceBottle();


         }

         public void getPocketWatch()
         {

             for (int i = 0; i < Inventory.slots.Length; i++)
             {
                 if (Inventory.isFull[i] == false)
                 {
                     Inventory.isFull[i] = true;
                     Instantiate(itemButton8, Inventory.slots[i].transform, false);

                     break;


                 }
             }
             TC.deactivatePocketWatchPanel();
             EC.removeWatch();


         }
         public void getKey()
         {

             for (int i = 0; i < Inventory.slots.Length; i++)
             {
                 if (Inventory.isFull[i] == false)
                 {
                     Inventory.isFull[i] = true;
                     Instantiate(itemButton9, Inventory.slots[i].transform, false);

                     break;


                 }
             }
         //    TC.deactivatePocketWatchPanel();
         //    EC.removeWatch();


         }
}
