using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //�^�C�}�[(UI)�\���Ɏg��

public class Timer_CountDown : MonoBehaviour
{
    //�������Ԃ�\������Text
    public Text Timer_Text;
    //�^�C���A�b�v�e�L�X�g
    public Text TimeUp_Text;
    //�J�E���g�_�E�� (60sec)
    float CountDown_ = 60.0f;
    
    void Update()
    {
        //�������Ԃ�\������
        Timer_Text.text = CountDown_.ToString("00");
        
        //Count_Down_��0���߂̂Ƃ�
        if(CountDown_ > 0.0f)
        {
            //�J�E���g�_�E��
            CountDown_ -= Time.deltaTime;

        }
        //CountDown_��0�ȉ��ɂȂ����Ƃ�
        else if (CountDown_ <= 0.0f)
        {
            TimeUp_Text.text = "TIME UP";
        }
    }
}
