/*
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TimeChronometer : MonoBehaviour
{
{
    public Text Tempo;
    public float tiempo = 0.0f;

    void Update()
    {
        tiempo -= Time.deltaTime;
        Tempo.text = "Tiempo:" + " " + tiempo.ToString("f0");

    }
}
//-------------------------------------------------------------------------------------------
public class TimeChronometer : MonoBehaviour
{
    public Text Tempo;
    public float Tiempo = 0.0f;
    public bool Aumento = false;

    void Update()
    {
        if (Aumento)
            Tiempo += Time.deltaTime;

        else
        {
            if (Tiempo <= 0.0f)  
            { Aumento = true; } 
            else
            { Tiempo -= Time.deltaTime; } 

        }
    }
    //-------------------------------------------------------------------------------------------
    public class TimeChronometer : MonoBehaviour
    {
        public Text Tempo;
        public float Tiempo = 0.0f;
        public bool Aumento = false;

        void Update()
        {
            
            Aumento = (Tiempo <= 0.0f) ? true : false;

            if (Aumento) Tiempo += Time.deltaTime;
            else Tiempo -= Time.deltaTime;

            Tempo.text = "Tiempo:" + " " + Tiempo.ToString("f0");
        }
    }
    //-------------------------------------------------------------------------------------------
    public class Countdown : MonoBehaviour
    {
        public int duration = 60;
        public int timeRemaining;
        public bool isCountingDown = false;
        public void Begin()
        {
            if (!isCountingDown)
            {
                isCountingDown = true;
                timeRemaining = duration;
                Invoke("_tick", 1f);
            }
        }
        //-------------------------------------------------------------------------------------------
        private void _tick()
        {
            timeRemaining--;
            if (timeRemaining > 0)
            {
                Invoke("_tick", 1f);
            }
            else
            {
                isCountingDown = false;
            }
        }
    }
}
*/