using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float CountDownTime = 30f;
    private float GameTime;
    private float timer = 0;
    public Text GameCountTimeText;
    public bool GameStart;

    public int S { get; private set; }

    private void Start()
    {
        GameTime = CountDownTime;
        GameStart = true;
    }


    private void Update()
    {
        int M = (int)(GameTime / 60);
        float S = GameTime % 60;

        if(GameStart==true)
        {
            timer += Time.deltaTime;
            if (timer >= 1f)
            {
                timer = 0;
                GameTime--;

                GameCountTimeText.text = M + ":" + string.Format("{0:00}", S);
                if (S <= 0)
                {
                    GameCountTimeText.text = string.Format("OVER");
                    GameStart = false;
                }
            }
        }
    }

    /*public void TimeOver()
    {
        if (S <= 0)
        {
            GameCountTimeText.text = string.Format("OVER");
            GameStart = false;
        }
    }
    */
}
