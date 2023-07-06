using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //�^�C�}�[(UI)�\���Ɏg��
using UnityEngine.SceneManagement;
using TMPro;

public class Timer_CountDown : MonoBehaviour
{
    //�������Ԃ�\������Text
    public TextMeshProUGUI Timer_Text;
    //�^�C���A�b�v�e�L�X�g
    // public Text TimeUp_Text;
    //�J�E���g�_�E�� (60sec)    
    [HideInInspector]
    public float CountDown_;

    private void Start()
    {
        CountDown_ = 60f;
        Timer_Text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        //�������Ԃ�\������+   
        Timer_Text.text = CountDown_.ToString("00");
        
        //Count_Down_��0���߂̂Ƃ�
        if(CountDown_ > 0.0f)
        {
            //�J�E���g�_�E��
            CountDown_ -= Time.deltaTime;
        }               
    }
}
