using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    [SerializeField] private Camera MainCam;
    // Start is called before the first frame update
    void Start()
    {
        if(MainCam == null)
        {
            MainCam = Camera.main;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        

        

    }

    private void TouchProcess()
    {
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            if (finger.phase == TouchPhase.Began)
            {


                Ray ray = MainCam.ScreenPointToRay(finger.position);
                if (Physics.Raycast(ray, out RaycastHit hitInfo))
                {

                    if (hitInfo.collider.tag == "Arrow")
                    {
                        hitInfo.collider.transform.parent.gameObject.GetComponent<NodeClass>().LookAtNewTrueWay();
                    }

                }

            }

        }
    }



}
