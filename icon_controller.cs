using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_controller : MonoBehaviour
{

    [SerializeField]
    GameObject icon1, icon2, icon3, dizzy, dizzy3, dizzy4, icon4, papericon1, safeIcon,globeIcon,chestIcon,papericon2,hotSauceIcon,pocketWatchIcon,
    fedBirdIcon;

    // Start is called before the first frame update
    void Start()
    {
        dizzy.SetActive(false);
        //  dizzy2.SetActive(false);
        dizzy3.SetActive(false);
        dizzy4.SetActive(false);
        icon1.SetActive(false);
        icon2.SetActive(false);
        icon3.SetActive(false);
        icon4.SetActive(false);
        papericon1.SetActive(false);
        safeIcon.SetActive(false);
        globeIcon.SetActive(false);
        chestIcon.SetActive(false);
        papericon2.SetActive(false);
        hotSauceIcon.SetActive(false);
        pocketWatchIcon.SetActive(false);
        fedBirdIcon.SetActive(false);
    }

    public void activateIcon1()
    {

        icon1.SetActive(true);
    }

    public void deactivateIcon1()
    {

        icon1.SetActive(false);
    }

    public void activateIcon2()
    {
        icon2.SetActive(true);
    }
    public void deactivateIcon2()
    {
        icon2.SetActive(false);
    }

    public void activateIcon3()
    {
        icon3.SetActive(true);
    }
    public void deactivateIcon3()
    {
        icon3.SetActive(false);
    }

    public void activateDizzyIcon()
    {
        dizzy.SetActive(true);
    }
    public void deactivateDizzyIcon()
    {
        dizzy.SetActive(false);
    }


    public void activateIcon4()
    {
        icon4.SetActive(true);
    }
    public void deactivateIcon4()
    {
        icon4.SetActive(false);
    }

    public void activateDizzyIcon3()
    {
        dizzy3.SetActive(true);
    }

    public void deactivateDizzyIcon3()
    {
        dizzy3.SetActive(false);
    }
    public void activateDizzyIcon4()
    {
        dizzy4.SetActive(true);
    }

    public void deactivateDizzyIcon4()
    {
        dizzy4.SetActive(false);
    }

    public void activatePaperIcon1()
    {
        papericon1.SetActive(true);
    }
    public void deactivatePaperIcon1()
    {
        papericon1.SetActive(false);
    }

    public void activateSafeIcon()
    {
        safeIcon.SetActive(true);
    }

    public void deactivateSafeIcon()
    {
        safeIcon.SetActive(false);
    }
    public void activateGlobeIcon() 
    {
        globeIcon.SetActive(true);
    }
    public void deactivateGlobeIcon()
    {
        globeIcon.SetActive(false);
    }

    public void activateChestIcon() 
    {
        chestIcon.SetActive(true);
    }
    public void deactivateChestIcon()
    {
        chestIcon.SetActive(false);
    }

    public void activatePaperIcon2() 
    {
        papericon2.SetActive(true);
    }

    public void deactivatePaperIcon2()
    {
        papericon2.SetActive(false);
    }

    public void activateHotSauceIcon() 
    {
        hotSauceIcon.SetActive(true); ;
    }

    public void deactivateHotSauceIcon()
    {
        hotSauceIcon.SetActive(false);
    }

    public void activatePocketWatchIcon() 
    {
        pocketWatchIcon.SetActive(true);
    }
    public void deactivatePocketWatchIcon()
    {
        pocketWatchIcon.SetActive(false);
    }
    public void activateFedBirdIcon() 
    {
        fedBirdIcon.SetActive(true);
    }
    public void deactivateFedBirdIcon()
    {
        fedBirdIcon.SetActive(false);
    }

}
