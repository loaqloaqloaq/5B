using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //�|�[�Y���ɕ\������UI�v���n�u
    public GameObject PauseUI;
    
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
            }
            //�|�[�YUI��\����
            else
            {
                //�ĊJ
                Time.timeScale = 1.0f;
            }
        }
        
    }
}
