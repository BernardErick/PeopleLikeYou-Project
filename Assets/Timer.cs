using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    private int hours;
    private int days;

    public TMP_Text timerText; 
    void Start()
    {
        this.hours = 7;
        this.days = 1;
        timerText.text = hours + ":00";
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator timer() {
        while (true)
        {
            yield return new WaitForSeconds(10.0f);
            this.hours++;
            if (this.hours == 25)
            {
                this.hours = 1;
                this.days++;
            }
            this.timerText.text = hours + ":00";
        }
    }
    public int getHours() {
        return this.hours;
    }
    public int getDays() {
        return this.days;
    }
    public void addHours(int hours) {
        this.hours += hours;
    }
}
