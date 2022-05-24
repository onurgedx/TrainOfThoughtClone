using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : StationAndTrainBaseScript
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Train")
        {
            if (collision.gameObject.GetComponent<Train>().selfStationColor == selfStationColor)
            {

                GameManager.Instance.ScoreUp();


            }

        }

    }





}
