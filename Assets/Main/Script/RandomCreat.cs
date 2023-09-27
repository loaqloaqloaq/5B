using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreat : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] createPrefab;
    [SerializeField]
    private Transform rangeA;
    [SerializeField]
    private Transform rangeB;
    private int instant_weapon;

    
    private void Start()
    {
        WeaponManager.nowWeapons = 0;
        instant_weapon = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // ��1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
        if (WeaponManager.maxWeapons > WeaponManager.nowWeapons)
        {
            // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
            float y = Random.Range(rangeA.position.y, rangeB.position.y);

            Instantiate(createPrefab[instant_weapon % 3], new Vector3(x, y, 0), createPrefab[instant_weapon % 3].transform.rotation);

            instant_weapon++;
            WeaponManager.nowWeapons++;
        }
    }

}
