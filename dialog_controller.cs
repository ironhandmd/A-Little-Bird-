using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog_controller : MonoBehaviour
{
    [SerializeField]
    GameObject npcStore,npcHat,npcOldman,npcWoman,npcWoman2;

    void Start()
    {
        npcStore.SetActive(false);
        npcHat.SetActive(false);
        npcOldman.SetActive(false);
        npcWoman.SetActive(false);
        npcWoman2.SetActive(false);
    }

    public void activateNPCStoreIcon() 
    {
        npcStore.SetActive(true);
    }
    public void deactivateNPCStoreIcon()
    {
        npcStore.SetActive(false);
    }

    public void activateNPCHat() 
    {
        npcHat.SetActive(true);
    }
    public void deactivateNPCHat()
    {
        npcHat.SetActive(false);
    }
    public void activateNPCOldMan() 
    {
        npcOldman.SetActive(true);
    }
    public void deactivateNPCOldMan()
    {
        npcOldman.SetActive(false);
    }
    public void activateNPCW() 
    {
        npcWoman.SetActive(true);
    }
    public void deactivateNPCW()
    {
        npcWoman.SetActive(false);
    }
    public void activateNPCWoman2() 
    {
        npcWoman2.SetActive(true);
    }
    public void deactivateNPCWoman2()
    {
        npcWoman2.SetActive(false);
    }


}
