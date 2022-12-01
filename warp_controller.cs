using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp_controller : MonoBehaviour
{
    [SerializeField]
    Transform warpTarget;
    CameraMovement CM;

    void Start()
    {
        CM = FindObjectOfType<CameraMovement>();
    }




    public void moveArea1()
    {
        CM.moveToArea1();

    }

    public void moveBackArea()
    {
        CM.moveToArea0();

    }

    public void moveToArea2()
    {
        CM.moveToArea2();
    }

    public void moveToArea3() 
    {
        CM.moveToArea3();
    }

    public void moveToArea4() 
    {
        CM.moveToArea4();
    }
    public void moveToArea5() 
    {
        CM.moveToArea5();
    }
    public void moveToArea6()
    {
        CM.moveToArea6();
    }
    public void moveToArea7()
    {
       CM.moveToArea7();
    }
}




