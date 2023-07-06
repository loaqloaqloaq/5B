using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleManager : MonoBehaviour
{
    //�^�C�g���̕\�� (�e�L�X�g�A�{�^��)
    public GameObject Title_Display;
    //��������e�L�X�g
    public GameObject Explanation;
    //    // Start is called before the first frame update
    //    void Start()
    //    {

    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {

    //    }

    //PVP�{�^�����������Ƃ�
    public void OnClickButton_PVP()
    {
        SceneManager.LoadScene("main");
    }

    //��������{�^�����������Ƃ�
    public void OnClickButton_Explanation()
    {
        Title_Display.SetActive(false);
        Explanation.SetActive(true);
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
