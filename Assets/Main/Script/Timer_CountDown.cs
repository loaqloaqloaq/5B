using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���̓ǂݍ���

public class Timer_CountDown : MonoBehaviour
{
    //Inspector��Ō����Ȃ��悤�ɂ���
   [HideInInspector]
    //�������� (�J�E���g�_�E������)
    public float CountDown;

    private void Start()
    {
        //���Ԃ̏����ݒ�
        CountDown = 60.0f;
    }
    private void Update()
    {
        //�������Ԃ�\������
        UIManager.Instance.UpdateTimerText((int)CountDown);

        //�������Ԃ�0���߂̂Ƃ�
        if (CountDown > 0.0f)
        {
            //�J�E���g�_�E��
            CountDown -= Time.deltaTime;
        }
        //�������Ԃ�0�ȉ��ɂȂ����Ƃ�
        else if (CountDown <= 0.0f)
        {
            //TimeUpText��\��
            UIManager.Instance.SetActiveTimeUpText();
        }
    }
}