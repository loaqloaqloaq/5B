using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultDirector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI winnerText;
    [SerializeField] private TextMeshProUGUI[] text_victory;
    [SerializeField] private TextMeshProUGUI[] text_weapon;
    [SerializeField] private TextMeshProUGUI[] text_score;
    [SerializeField] private GameObject[] playerImages;

    GameObject nowButton;
    float defaultOpacity = 0.8f;

    void Start()
    {
        SetActiveWinnerSprite();
        SetWinnerText();
        SetInformText();
    }

    private void Update()
    {
        nowButton = EventSystem.current.currentSelectedGameObject;
        ChangeButtonEffect();
    }

    private void ChangeButtonEffect()
    {
        nowButton.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        foreach (Button button in FindObjectsOfType<Button>())
        {
            if (button.gameObject != nowButton)
            {
                Image image = button.GetComponent<Image>();
                if (image != null)
                {
                    image.color = new Color(1, 1, 1, defaultOpacity);
                }
            }
        }
    }
    private void SetInformText()
    {
        text_victory[0].text = GameData.p1.victoryCount.ToString();
        text_victory[1].text = GameData.p2.victoryCount.ToString();

        text_weapon[0].text = GameData.p1.weaponCount.ToString();
        text_weapon[1].text = GameData.p2.weaponCount.ToString();

        int score = GameData.p1.victoryCount * 500 + GameData.p1.weaponCount * 50;
        text_score[0].text = score.ToString();
        score = GameData.p2.victoryCount * 500 + GameData.p2.weaponCount * 50;
        text_score[1].text = score.ToString();
    }

    private void SetWinnerText()
    {
        if (!winnerText)
        {
            Debug.Log("Null reference");
            return;
        }

        if (GameData.winnerId == 1)
        { winnerText.text = "Player1" + " Win"; }
        else if (GameData.winnerId == 2) 
        { winnerText.text = "Player2" + " Win"; }
        else { winnerText.text = "DRAW!!"; }
    }

    private void SetActiveWinnerSprite()
    {
        int winner = GameData.winnerId;
        if (!(winner == 1 || winner == 2) || playerImages.Length < 2)
        {
           return;
        }

        if (winner == 1)
        {
            playerImages[0].SetActive(true);
        }
        else
        {
            playerImages[1].SetActive(true);
        }
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("player1HP", 0);
        PlayerPrefs.SetFloat("player2HP", 0);
    }

    public void Button_Restart()
    {
        LoadingSceneController.LoadScene("main");
    }
    public void Button_Title()
    {
        //�Q�[���f�[�^��������
        GameData.Initialize();
        LoadingSceneController.LoadScene("Title");
    }
    public void Button_MapSelect()
    {
        TitleManager.mapselect = true;
        LoadingSceneController.LoadScene("Title");
    }
}
