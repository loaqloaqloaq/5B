using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickButton : MonoBehaviour
{
    //�|�[�Y���ɕ\������e�L�X�g
    public GameObject PauseText;
    //�^�C�g���ɖ߂邩�ŏI�m�F����e�L�X�g
    public GameObject ConfirmationText;   

    //�^�C�g���ɖ߂�{�^���������ꂽ�Ƃ�
    public void OnClick_BacktoTitle_Button()
    {
        //�|�[�Y�e�L�X�g���\��
        PauseText.SetActive(false);        
        //�ŏI�m�F����e�L�X�g��\��
        ConfirmationText.SetActive(true);          
    }  
   
    //�͂��������ꂽ�ꍇ
    public void OnClick_Yes_Button()
    {
        //�^�C�g���V�[���ɐ؂�ւ�
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Title");
    }

    //Cancel�������ꂽ�ꍇ
    public void OnClick_Cancel_Button()
    {
        //�ŏI�m�F����e�L�X�g���\��
        ConfirmationText.SetActive(false);
        //�|�[�Y�e�L�X�g��\��
        PauseText.SetActive(true);
    }
}
