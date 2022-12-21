using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeUp : MonoBehaviour
{
    private float timeGauge;
    public Slider slider;
    public bool isAdd;
    private float ramPo;
    public bool[] ivent;
    public GameObject[] popups;
 
    void Start()
    {
        slider.GetComponent<Slider>();
        isAdd = true;
        popups[0].SetActive(false);
        popups[1].SetActive(false);
        popups[2].SetActive(false);
        popups[3].SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        ramPo = Random.Range(1, 5) * 10f;//ゲージ上昇乱数
        if(isAdd == true)//ゲージが進行する
        {
            timeGauge += Time.deltaTime * ramPo;
        }
        
        slider.value = timeGauge;
        if( timeGauge  > 95f && ivent[3] == true)//イベント発生時isADDをfalseにしてゲージを止める。ミッション終わったらtrueに変更すべし
        {
            Debug.Log("イベント4/4");
            isAdd = false;
            popups[3].SetActive(true);
        }
        else if(timeGauge >50f && ivent[2] == true)
        {
            Debug.Log("イベント3/4");
            isAdd = false;
            popups[2].SetActive(true);
        }
        else if(timeGauge > 25f && ivent[1] == true)
        {
            Debug.Log("イベント2/4");
            isAdd = false;
            popups[1].SetActive(true);
        }
        else if(timeGauge > 10f && ivent[0] == true)
        {
            Debug.Log("イベント1/4");
            isAdd = false;
            popups[0].SetActive(true);
        }
    }
}
