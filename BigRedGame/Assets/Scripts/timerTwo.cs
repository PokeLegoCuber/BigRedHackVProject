using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class timerTwo : MonoBehaviour {
    Image fillImg;
    public float timeAmt = 10;
    float time;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0) {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
            timeText.text = "Time : " + time.ToString("F");
        }
    }
}
