using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class Timer_CountDown : MonoBehaviour
{
    //�������Ԃ�\������Text
    [SerializeField] private TextMeshProUGUI Timer_Text;
    [SerializeField] private TextMeshProUGUI CountDown_Text;
    //�^�C���A�b�v�e�L�X�g
    //�J�E���g�_�E�� (60sec)    
    
    [field: SerializeField]
    public float CountDown_
    {
        get;
        private set;
    }

    private Animator animator;

    [SerializeField] private float CountDownTime = 5.0f;
    [SerializeField] GameObject Time_BackGround;
    [SerializeField] GameObject TimeUp_Text;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Start()
    {
        Timer_Text.text = CountDown_.ToString("00");

        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (CountDown_ > CountDownTime) 
        {
            yield return new WaitForSeconds(1.0f);
            CountDown_ -= 1.0f;
            Timer_Text.text = CountDown_.ToString("00");
        }

        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        Time_BackGround.SetActive(false);
        CountDown_Text.gameObject.SetActive(true);

        while (CountDown_ > 0f) 
        {
            animator.SetTrigger("count");
            yield return new WaitForSeconds(1.0f);
            CountDown_ -= 1.0f; 
            CountDown_Text.text = CountDown_.ToString("0");
            //string.Format("0", CountDown_);
        }

        CountDown_Text.gameObject.SetActive(false);

        TimeUp_Text.SetActive(true);
        animator.SetTrigger("timeUp");
    }

    void Update()
    {
        Debug.Log(CountDown_);
        /*
        //�������Ԃ�\������+   
        Timer_Text.text = CountDown_.ToString("00");
        
        //Count_Down_��0���߂̂Ƃ�
        if(CountDown_ > 0.0f)
        {
            //�J�E���g�_�E��
            CountDown_ -= Time.deltaTime;
        }               
    
    */
    }
}
