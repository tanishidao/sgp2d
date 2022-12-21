using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottondayo : MonoBehaviour
{
    public GaugeUp gaugeUp;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void IsStart()
    {
        if (gaugeUp.ivent[0] == true)//イベント1が発生時、解除する
        {
            gaugeUp.ivent[0] = false;
            gaugeUp.isAdd = true;
            gaugeUp.popups[0].SetActive(false);
        }
                    }
    public void IsStartSecond()
    {
        if (gaugeUp.ivent[0] == false)//過去イベントがfalseのとき現在イベントクリアにする
        {
            gaugeUp.ivent[1] = false;
            gaugeUp.isAdd = true;
            gaugeUp.popups[1].SetActive(false);

        }
    }
    public void IsStartSan()
    {
        if (gaugeUp.ivent[1] == false)//過去イベントがfalseのとき現在イベントクリアにする
        {
            gaugeUp.ivent[2] = false;
            gaugeUp.isAdd = true;
            gaugeUp.popups[2].SetActive(false);
        }
    }
    public void IsstartYon()
    {
        if (gaugeUp.ivent[2] == false)//過去イベントがfalseのとき現在イベントクリアにする
        {
            gaugeUp.ivent[3] = false;
            gaugeUp.isAdd = true;
            gaugeUp.popups[3].SetActive(false);
        }
    }

}
