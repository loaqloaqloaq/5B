using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���̓ǂݍ���

public class Timer_CountDown : MonoBehaviour
{
    //�������� (�J�E���g�_�E������)
    float CountDown_;
    //�������ԏI������̌o�ߎ���
    float FinishTime_;

    private void Start()
    {
        //���Ԃ̏����ݒ�
        CountDown_ = 60.0f;
        FinishTime_ = 0.0f;
    }
    private void Update()
    {
        //�������Ԃ�\������
        UIManager.Instance.UpdateTimerText((int)CountDown_);

        //�������Ԃ�0���߂̂Ƃ�
        if (CountDown_ > 0.0f)
        {
            //�J�E���g�_�E��
            CountDown_ -= Time.deltaTime;
        }
        //�������Ԃ�0�ȉ��ɂȂ����Ƃ�
        else if (CountDown_ <= 0.0f)
        {
            //TimeUpText��\��
            UIManager.Instance.SetActiveTimeUpText();
            FinishTime_ += Time.deltaTime;
        }

        //�������ԏI������3�b�o��
        if (FinishTime_ >= 3.0f)
        {
            //���U���g�V�[���ɐ؂�ւ�
            SceneManager.LoadScene("Result");
        }
    }
}