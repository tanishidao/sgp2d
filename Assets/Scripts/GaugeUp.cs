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
        ramPo = Random.Range(1, 5) * 10f;//�Q�[�W�㏸����
        if(isAdd == true)//�Q�[�W���i�s����
        {
            timeGauge += Time.deltaTime * ramPo;
        }
        
        slider.value = timeGauge;
        if( timeGauge  > 95f && ivent[3] == true)//�C�x���g������isADD��false�ɂ��ăQ�[�W���~�߂�B�~�b�V�����I�������true�ɕύX���ׂ�
        {
            Debug.Log("�C�x���g4/4");
            isAdd = false;
            popups[3].SetActive(true);
        }
        else if(timeGauge >50f && ivent[2] == true)
        {
            Debug.Log("�C�x���g3/4");
            isAdd = false;
            popups[2].SetActive(true);
        }
        else if(timeGauge > 25f && ivent[1] == true)
        {
            Debug.Log("�C�x���g2/4");
            isAdd = false;
            popups[1].SetActive(true);
        }
        else if(timeGauge > 10f && ivent[0] == true)
        {
            Debug.Log("�C�x���g1/4");
            isAdd = false;
            popups[0].SetActive(true);
        }
    }
}
