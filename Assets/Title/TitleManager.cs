using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    //�^�C�g���̕\�� (�e�L�X�g�A�{�^��)
    public GameObject Title_Display;
    //��������e�L�X�g
    public GameObject Explanation;

    [SerializeField]
    GameObject[] buttons;

    int selecting;

    private void Start()
    {
        GameData.Initialize();

        selecting = 0;
        ChangeButtonEffect();
    }

    private void Update()
    {
        if (Explanation.activeSelf && Input.GetButtonDown("Cancel")) {
            OnClickButton_CloseExplanation();
        }
        if (Input.GetButtonDown("Vertical") && Input.GetAxis("Vertical") < 0) {            
            selecting--;
            if (selecting < 0) selecting = 0;
            ChangeButtonEffect();
        }
        else if(Input.GetButtonDown("Vertical") && Input.GetAxis("Vertical") > 0) {            
            selecting++;
            if (selecting > (buttons.Length-1)) selecting = (buttons.Length - 1);
            ChangeButtonEffect();
        }
        if (Input.GetButtonDown("Submit")) {
            buttons[selecting].GetComponent<Button>().onClick.Invoke();
        }
        
    }

    //�I���G�t�F�N�g
    private void ChangeButtonEffect()
    {
        foreach (var button in buttons) {
            var img = button.GetComponent<Image>();
            if (button == buttons[selecting])
            {
                img.color = new Color(1, 1, 1, 1);
            }
            else {
                img.color = new Color(1, 1, 1, 0.8f);
            }
        }
    }

    //PVP�{�^�����������Ƃ�
    public void OnClickButton_PVP()
    {
        //SceneManager.LoadScene("main");
        LoadingSceneController.LoadScene("main");
        PlayerPrefs.SetString("mode", "PVP");
    }
    public void OnClickButton_PVE()
    {
        //SceneManager.LoadScene("main");
        LoadingSceneController.LoadScene("main");
        PlayerPrefs.SetString("mode", "PVE");
    }

    //��������{�^�����������Ƃ�
    public void OnClickButton_Explanation()
    {
        Title_Display.SetActive(false);
        Explanation.SetActive(true);
    }

    public void OnClickButton_CloseExplanation()
    {
        Title_Display.SetActive(true);
        Explanation.SetActive(false);
    }

    //�Q�[�����I���{�^�����������Ƃ�
    public void OnClickButton_GameEnd()
    {        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();
    }
}
