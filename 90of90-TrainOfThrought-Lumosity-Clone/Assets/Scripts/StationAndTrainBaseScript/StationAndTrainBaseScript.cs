using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationAndTrainBaseScript : MonoBehaviour
{


    public StationColor selfStationColor;
    public SpriteRenderer spriteRenderer;


    public enum StationColor
    {
        
        Red,
        Yellow,
        Magenta,
        Black,
        White,
        Blue

    }



  
    


    private void Awake()
    {
        SetComponent();
        SettingStationFeature();
    }
    private void SetComponent()
    {
        if (spriteRenderer == null) spriteRenderer = GetComponent<SpriteRenderer>();

    }

    public void SettingStationFeature()
    {

        if (isColorThis(StationColor.Black)) { SetSpriteColor(Color.black); }
        else if (isColorThis(StationColor.Blue)) { SetSpriteColor(Color.blue); }
        else if (isColorThis(StationColor.White)) { SetSpriteColor(Color.white); }
        else if (isColorThis(StationColor.Red)) { SetSpriteColor(Color.red); }
        else if (isColorThis(StationColor.Yellow)) { SetSpriteColor(Color.yellow); }
        else if (isColorThis(StationColor.Magenta)) { SetSpriteColor(Color.magenta); }


    }


    private bool isColorThis(StationColor sc)
    {
        return selfStationColor == sc;
    }
    private void SetSpriteColor(Color clr)
    {
        spriteRenderer.color = clr;

    }

}
