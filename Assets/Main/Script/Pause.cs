using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //�|�[�Y���ɕ\������UI (BackGround�܂�)
    public GameObject PauseUI;
    //�|�[�Y���ɕ\������e�L�X�g
    public GameObject PauseText;
    //�^�C�g���ɖ߂邩�ŏI�m�F����e�L�X�g
    public GameObject ConfirmationText;

    void Update()
    {
        //Escape�L�[�������ꂽ�u��
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //�|�[�YUI�̕\���A��\����؂�ւ�
            PauseUI.SetActive(!PauseUI.activeSelf);

            //�|�[�YUI�\����
            if (PauseUI.activeSelf == true)
            {
                //�ꎞ��~
                Time.timeScale = 0.0f;
                //�|�[�Y�e�L�X�g��\��
                PauseText.SetActive(true);
            }
            //�|�[�YUI��\����
            else
            {
                //�ĊJ
                Time.timeScale = 1.0f;
                //�ŏI�m�F����e�L�X�g���\��
                ConfirmationText.SetActive(false);
            }
        }
    }
}
