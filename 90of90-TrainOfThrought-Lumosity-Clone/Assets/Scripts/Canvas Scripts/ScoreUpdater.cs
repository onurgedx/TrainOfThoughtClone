using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUpdater : MonoBehaviour
{

    public static ScoreUpdater Instance;
    [SerializeField]private Text text;

    private void Awake()
    {
        if(Instance==null){Instance = this;}

        if (text == null){  text = GetComponent<Text>(); }


        ScoreUpdate(0);

    }


    public void ScoreUpdate(int score)
    {
        text.text = score.ToString() ;
    }



}
