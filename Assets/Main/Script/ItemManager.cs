using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemManager : MonoBehaviour
{
    public GameObject axePre, swordPre, spearPre;
    GameObject creatPre;

    public Transform rangeA;
    public Transform rangeB;

    public int maxWeapons;
    int nowWeapons;

    // Start is called before the first frame update
    void Start()
    {
        nowWeapons = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (nowWeapons >= maxWeapons)
        {
            return;
        }
        else
        {
            ApperWeapons();
        }
    }

    void ApperWeapons()
    {
        int n = Random.Range(0, 3);
        switch (n)
        {
            case 0:
                creatPre = swordPre;
                break;
            case 1:
                creatPre = spearPre;
                break;
            case 2:
                creatPre = axePre;
                break;
        }
        // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
        float y = Random.Range(rangeA.position.y, rangeB.position.y);

        Instantiate(creatPre, new Vector3(x, y, 0), creatPre.transform.rotation);
        nowWeapons++;
    }
}
