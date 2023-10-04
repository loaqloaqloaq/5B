using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OnClickButton : MonoBehaviour
{
    //�|�[�Y���ɕ\������e�L�X�g
    public GameObject PauseText;
    //�^�C�g���ɖ߂邩�ŏI�m�F����e�L�X�g
    public GameObject ConfirmationText;

    //SE
    [SerializeField] private AudioClip UiSE;
    

    //�^�C�g���ɖ߂�{�^���������ꂽ�Ƃ�
    public void OnClick_BacktoTitle_Button()
    {
        //�|�[�Y�e�L�X�g���\��
        PauseText.SetActive(false);        
        //�ŏI�m�F����e�L�X�g��\��
        ConfirmationText.SetActive(true);
        EventSystem.current.SetSelectedGameObject(GameObject.Find("Yes"));
        PlayUISound();
    }  
   
    //�͂��������ꂽ�ꍇ
    public void OnClick_Yes_Button()
    {
        PlayUISound();
        //�^�C�g���V�[���ɐ؂�ւ�
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Title");
    }

    private void PlayUISound()
    {
        SoundManager.Instance.Play(UiSE, SoundManager.Sound.UI);
    }

    //Cancel�������ꂽ�ꍇ
    public void OnClick_Cancel_Button()
    {
        //�ŏI�m�F����e�L�X�g���\��
        ConfirmationText.SetActive(false);
        //�|�[�Y�e�L�X�g��\��
        PauseText.SetActive(true);
        EventSystem.current.SetSelectedGameObject(GameObject.Find("PauseUI/Continue"));
        PlayUISound();
    }
}
