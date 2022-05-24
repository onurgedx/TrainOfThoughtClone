using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;
public class Train : StationAndTrainBaseScript
{

    [SerializeField]private SplineFollower splineFollower;
    
    private SplineComputer BaseSpline;

    private void Start()
    {
        if(splineFollower == null) { splineFollower = GetComponent<SplineFollower>(); }
        

        BaseSpline = splineFollower.spline;
        splineFollower.onNode += OnNodePassed;
    }


    private void OnNodePassed(List<SplineTracer.NodeConnection> passed)
    {
       
       

        NodeClass tempNode = passed[0].node.GetComponent<NodeClass>();
        
        splineFollower.spline = tempNode.GetmainSplineComputer();
        if( BaseSpline != splineFollower.spline)
        {
            splineFollower.SetPercent(0);
            BaseSpline = splineFollower.spline;


        }
        
   
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Station")
        {
            Destroy(gameObject);

        }

    }





}
