using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //SINGELTON
    public static GameManager Instance;

    private int m_score = 0;

    WaitForSeconds m_trainWaitDuration;
    public float trainWaitDuration;
    [SerializeField]private GameObject TrainsParent;

    private SplineFollower[] splineFollowers;

    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
        }
        
        
    }
    private void Start()
    {
        splineFollowers = TrainsParent.GetComponentsInChildren<SplineFollower>();
        m_trainWaitDuration = new WaitForSeconds(trainWaitDuration);
        StartCoroutine(SendTrains());
    }

    private IEnumerator SendTrains()
    {

        for(int i = 0;i < splineFollowers.Length;i++)
        {
            splineFollowers[i].follow = true;

            yield return m_trainWaitDuration;
           
        }
        yield return null;

    }

    public int Score
    {
        get {  return m_score; }
        set { m_score = value; }
    }


    public void ScoreUp()
    {
        Score++;

        ScoreUpdater.Instance.ScoreUpdate(Score);

    }
    

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
