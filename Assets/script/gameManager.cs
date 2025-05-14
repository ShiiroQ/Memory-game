using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour

{
    private float timer;
    public Camera Camera;
    public Vector3 newpos;
    public GameObject QuestionsUI;
    public GameObject TrueUI;
    public GameObject FalseUI;
    private bool OneTime = true;
    public bool rotatation = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
        Time.timeScale = 1;
        QuestionsUI.SetActive(false);
        TrueUI.SetActive(false);
        FalseUI.SetActive(false);
        rotatation = true;

    }

    // Update is called once per frame
    void Update()
    {

            Timer();
    }

    public void True()
    {
        
        TrueUI.SetActive(true);
        QuestionsUI.SetActive(false);
    }

    public void False()
    {
        
        FalseUI.SetActive(true);
        QuestionsUI.SetActive(false);

    }

    public void Timer()
    {
        
        if (timer < 30)
        {
            timer = timer + 1 * Time.deltaTime;
            
            
        }
        else
        {
            
            Camera.transform.position = newpos;
            if (OneTime)
            {
                OneTime = false;
                rotatation = false;
                QuestionsUI.SetActive(true);
            }


        }
    }
}
