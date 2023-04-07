using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public static LevelController levelController;
    public Text zoomText;
    public Slider zoomSlider;
    public Text timerText;
    private float ZoomY;
    private int sec = 0;
    private int min = 0;
    //private int delta = 0;

    void Start()
    {
        levelController = this;
        StartCoroutine(TimeFlow());
    }

    public void SetZoomText(float ZoomX)
    {
        zoomText.text = ZoomX.ToString() + "X";
        zoomSlider.value = ZoomX;
    }

    IEnumerator TimeFlow()
    {
        while (true)
        {
            if(sec == 59)
            {
                min++;
                sec = -1;
            }
            sec++;
            //sec += delta;
            timerText.text = min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
}
