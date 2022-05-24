using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class NodeClass : MonoBehaviour
{
    public GameObject Arrow;
    public SplineComputer mainSpline;
    public Node nodeCon;
    private int counterConnect;
    private void Start()
    {
        if(Arrow == null)
        {
            Arrow = transform.GetChild(0).gameObject;

        }
        if(nodeCon==null)
        { nodeCon = GetComponent<Node>(); }

        counterConnect = Random.Range(0, 3);
        
        LookAtNewTrueWay();
    }



    public void LookAtNewTrueWay()
    {
       
        counterConnect= (1+counterConnect) % nodeCon.GetConnections().Length;
        mainSpline = nodeCon.GetConnections()[counterConnect].spline;

        int  pointindx = nodeCon.GetConnections()[counterConnect].pointIndex ;
        Vector3 targetPos = mainSpline.GetPointPosition(pointindx+1,SplineComputer.Space.World); //position;
        

        Arrow.transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPos - Arrow.transform.position);
        Arrow.transform.Rotate(new Vector3(0, 0, 90));

    }

   public SplineComputer GetmainSplineComputer()
    {
        return mainSpline;
    }





}
