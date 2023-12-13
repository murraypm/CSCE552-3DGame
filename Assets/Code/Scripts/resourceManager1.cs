using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceManager1 : MonoBehaviour
{
    [SerializeField] private GameObject C0101;
    [SerializeField] private GameObject C0102;
    [SerializeField] private GameObject C0103;
    [SerializeField] private GameObject C0104;
    [SerializeField] private GameObject C0105;

    [SerializeField] private GameObject C0201;
    [SerializeField] private GameObject C0202;
    [SerializeField] private GameObject C0203;
    [SerializeField] private GameObject C0204;
    [SerializeField] private GameObject C0205;

    [SerializeField] private GameObject C0301;
    [SerializeField] private GameObject C0302;
    [SerializeField] private GameObject C0303;
    [SerializeField] private GameObject C0304;
    [SerializeField] private GameObject C0305;

    [SerializeField] private GameObject C0401;
    [SerializeField] private GameObject C0402;
    [SerializeField] private GameObject C0403;
    [SerializeField] private GameObject C0404;
    [SerializeField] private GameObject C0405;

    [SerializeField] private GameObject C0501;
    [SerializeField] private GameObject C0502;
    [SerializeField] private GameObject C0503;
    [SerializeField] private GameObject C0504;
    [SerializeField] private GameObject C0505;

    [SerializeField] private GameObject C0601;
    [SerializeField] private GameObject C0602;
    [SerializeField] private GameObject C0603;
    [SerializeField] private GameObject C0604;
    [SerializeField] private GameObject C0605;

    [SerializeField] private GameObject C0701;
    [SerializeField] private GameObject C0702;
    [SerializeField] private GameObject C0703;
    [SerializeField] private GameObject C0704;
    [SerializeField] private GameObject C0705;

    [SerializeField] private GameObject C0801;
    [SerializeField] private GameObject C0802;
    [SerializeField] private GameObject C0803;
    [SerializeField] private GameObject C0804;
    [SerializeField] private GameObject C0805;

    [SerializeField] private GameObject C0901;
    [SerializeField] private GameObject C0902;
    [SerializeField] private GameObject C0903;
    [SerializeField] private GameObject C0904;
    [SerializeField] private GameObject C0905;

    [SerializeField] private GameObject C1001;
    [SerializeField] private GameObject C1002;
    [SerializeField] private GameObject C1003;
    [SerializeField] private GameObject C1004;
    [SerializeField] private GameObject C1005;

    [SerializeField] private GameObject C1101;
    [SerializeField] private GameObject C1102;
    [SerializeField] private GameObject C1103;
    [SerializeField] private GameObject C1104;
    [SerializeField] private GameObject C1105;



    [SerializeField] private GameObject C01001;
    [SerializeField] private GameObject C01002;
    [SerializeField] private GameObject C01003;
    [SerializeField] private GameObject C01004;
    [SerializeField] private GameObject C01005;

    [SerializeField] private GameObject C02001;
    [SerializeField] private GameObject C02002;
    [SerializeField] private GameObject C02003;
    [SerializeField] private GameObject C02004;
    [SerializeField] private GameObject C02005;

    [SerializeField] private GameObject C03001;
    [SerializeField] private GameObject C03002;
    [SerializeField] private GameObject C03003;
    [SerializeField] private GameObject C03004;
    [SerializeField] private GameObject C03005;

    [SerializeField] private GameObject C04001;
    [SerializeField] private GameObject C04002;
    [SerializeField] private GameObject C04003;
    [SerializeField] private GameObject C04004;
    [SerializeField] private GameObject C04005;

    [SerializeField] private GameObject C05001;
    [SerializeField] private GameObject C05002;
    [SerializeField] private GameObject C05003;
    [SerializeField] private GameObject C05004;
    [SerializeField] private GameObject C05005;

    [SerializeField] private GameObject C06001;
    [SerializeField] private GameObject C06002;
    [SerializeField] private GameObject C06003;
    [SerializeField] private GameObject C06004;
    [SerializeField] private GameObject C06005;

    [SerializeField] private GameObject C07001;
    [SerializeField] private GameObject C07002;
    [SerializeField] private GameObject C07003;
    [SerializeField] private GameObject C07004;
    [SerializeField] private GameObject C07005;

    [SerializeField] private GameObject C08001;
    [SerializeField] private GameObject C08002;
    [SerializeField] private GameObject C08003;
    [SerializeField] private GameObject C08004;
    [SerializeField] private GameObject C08005;

    [SerializeField] private GameObject C09001;
    [SerializeField] private GameObject C09002;
    [SerializeField] private GameObject C09003;
    [SerializeField] private GameObject C09004;
    [SerializeField] private GameObject C09005;

    [SerializeField] private GameObject C10001;
    [SerializeField] private GameObject C10002;
    [SerializeField] private GameObject C10003;
    [SerializeField] private GameObject C10004;
    [SerializeField] private GameObject C10005;

    [SerializeField] private GameObject C11001;
    [SerializeField] private GameObject C11002;
    [SerializeField] private GameObject C11003;
    [SerializeField] private GameObject C11004;
    [SerializeField] private GameObject C11005;

    // Start is called before the first frame update
    void Start()
    {
        noReasources();

        spawnStone1(2, 2, 3);
        spawnStone2(1, 2, 3);
        spawnStone3(4, 4, 5);

        spawnWood1(4,4,4);
        spawnWood2(3,3,5);
        spawnWood3(2,3,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NoStone()
    {
        C0101.SetActive(false);
        C0102.SetActive(false);
        C0103.SetActive(false);
        C0104.SetActive(false);
        C0105.SetActive(false);

        C0201.SetActive(false);
        C0202.SetActive(false);
        C0203.SetActive(false);
        C0204.SetActive(false);
        C0205.SetActive(false);

        C0301.SetActive(false);
        C0302.SetActive(false);
        C0303.SetActive(false);
        C0304.SetActive(false);
        C0305.SetActive(false);

        C0401.SetActive(false);
        C0402.SetActive(false);
        C0403.SetActive(false);
        C0404.SetActive(false);
        C0405.SetActive(false);

        C0501.SetActive(false);
        C0502.SetActive(false);
        C0503.SetActive(false);
        C0504.SetActive(false);
        C0505.SetActive(false);

        C0601.SetActive(false);
        C0602.SetActive(false);
        C0603.SetActive(false);
        C0604.SetActive(false);
        C0605.SetActive(false);

        C0701.SetActive(false);
        C0702.SetActive(false);
        C0703.SetActive(false);
        C0704.SetActive(false);
        C0705.SetActive(false);

        C0801.SetActive(false);
        C0802.SetActive(false);
        C0803.SetActive(false);
        C0804.SetActive(false);
        C0805.SetActive(false);

        C0901.SetActive(false);
        C0902.SetActive(false);
        C0903.SetActive(false);
        C0904.SetActive(false);
        C0905.SetActive(false);

        C1001.SetActive(false);
        C1002.SetActive(false);
        C1003.SetActive(false);
        C1004.SetActive(false);
        C1005.SetActive(false);

        C1101.SetActive(false);
        C1102.SetActive(false);
        C1103.SetActive(false);
        C1104.SetActive(false);
        C1105.SetActive(false);
    }

    private void NoWood()
    {
        C01001.SetActive(false);
        C01002.SetActive(false);
        C01003.SetActive(false);
        C01004.SetActive(false);
        C01005.SetActive(false);

        C02001.SetActive(false);
        C02002.SetActive(false);
        C02003.SetActive(false);
        C02004.SetActive(false);
        C02005.SetActive(false);

        C03001.SetActive(false);
        C03002.SetActive(false);
        C03003.SetActive(false);
        C03004.SetActive(false);
        C03005.SetActive(false);

        C04001.SetActive(false);
        C04002.SetActive(false);
        C04003.SetActive(false);
        C04004.SetActive(false);
        C04005.SetActive(false);

        C05001.SetActive(false);
        C05002.SetActive(false);
        C05003.SetActive(false);
        C05004.SetActive(false);
        C05005.SetActive(false);

        C06001.SetActive(false);
        C06002.SetActive(false);
        C06003.SetActive(false);
        C06004.SetActive(false);
        C06005.SetActive(false);

        C07001.SetActive(false);
        C07002.SetActive(false);
        C07003.SetActive(false);
        C07004.SetActive(false);
        C07005.SetActive(false);

        C08001.SetActive(false);
        C08002.SetActive(false);
        C08003.SetActive(false);
        C08004.SetActive(false);
        C08005.SetActive(false);

        C09001.SetActive(false);
        C09002.SetActive(false);
        C09003.SetActive(false);
        C09004.SetActive(false);
        C09005.SetActive(false);

        C10001.SetActive(false);
        C10002.SetActive(false);
        C10003.SetActive(false);
        C10004.SetActive(false);
        C10005.SetActive(false);

        C11001.SetActive(false);
        C11002.SetActive(false);
        C11003.SetActive(false);
        C11004.SetActive(false);
        C11005.SetActive(false);
    }

    private void wood1(int roll, bool isOn)
    {
        if(roll == 1)
        {
            C02001.SetActive(isOn);
            C05001.SetActive(isOn);
            C08001.SetActive(isOn);
            C10001.SetActive(isOn);
        }
        if (roll == 2)
        {
            C02002.SetActive(isOn);
            C05002.SetActive(isOn);
            C08002.SetActive(isOn);
            C10002.SetActive(isOn);
        }
        if (roll == 3)
        {
            C02003.SetActive(isOn);
            C05003.SetActive(isOn);
            C08003.SetActive(isOn);
            C10003.SetActive(isOn);
        }
        if (roll == 4)
        {
            C02004.SetActive(isOn);
            C05004.SetActive(isOn);
            C08004.SetActive(isOn);
            C10004.SetActive(isOn);
        }
        if (roll == 5)
        {
            C02005.SetActive(isOn);
            C05005.SetActive(isOn);
            C08005.SetActive(isOn);
            C10005.SetActive(isOn);
        }
    }

    private void wood2(int roll, bool isOn)
    {
        if (roll == 1)
        {
            C03001.SetActive(isOn);
            C04001.SetActive(isOn);
            C11001.SetActive(isOn);
        }
        if (roll == 2)
        {
            C03002.SetActive(isOn);
            C04002.SetActive(isOn);
            C11002.SetActive(isOn);
        }
        if (roll == 3)
        {
            C03003.SetActive(isOn);
            C04003.SetActive(isOn);
            C11003.SetActive(isOn);
        }
        if (roll == 4)
        {
            C03004.SetActive(isOn);
            C04004.SetActive(isOn);
            C11004.SetActive(isOn);
        }
        if (roll == 5)
        {
            C03005.SetActive(isOn);
            C04005.SetActive(isOn);
            C11005.SetActive(isOn);
        }
    }

    private void wood3(int roll, bool isOn)
    {
        if (roll == 1)
        {
            C01001.SetActive(isOn);
            C06001.SetActive(isOn);
            C07001.SetActive(isOn);
            C09001.SetActive(isOn);
        }
        if (roll == 2)
        {
            C01002.SetActive(isOn);
            C06002.SetActive(isOn);
            C07002.SetActive(isOn);
            C09002.SetActive(isOn);
        }
        if (roll == 3)
        {
            C01003.SetActive(isOn);
            C06003.SetActive(isOn);
            C07003.SetActive(isOn);
            C09003.SetActive(isOn);
        }
        if (roll == 4)
        {
            C01004.SetActive(isOn);
            C06004.SetActive(isOn);
            C07004.SetActive(isOn);
            C09004.SetActive(isOn);
        }
        if (roll == 5)
        {
            C01005.SetActive(isOn);
            C06005.SetActive(isOn);
            C07005.SetActive(isOn);
            C09005.SetActive(isOn);
        }
    }

    private void stone1(int roll, bool isOn)
    {
        if (roll == 1)
        {
            C0201.SetActive(isOn);
            C0401.SetActive(isOn);
            C0701.SetActive(isOn);
            C1101.SetActive(isOn);
        }
        if (roll == 2)
        {
            C0202.SetActive(isOn);
            C0402.SetActive(isOn);
            C0702.SetActive(isOn);
            C1102.SetActive(isOn);
        }
        if (roll == 3)
        {
            C0203.SetActive(isOn);
            C0403.SetActive(isOn);
            C0703.SetActive(isOn);
            C1103.SetActive(isOn);
        }
        if (roll == 4)
        {
            C0204.SetActive(isOn);
            C0404.SetActive(isOn);
            C0704.SetActive(isOn);
            C1104.SetActive(isOn);
        }
        if (roll == 5)
        {
            C0205.SetActive(isOn);
            C0405.SetActive(isOn);
            C0705.SetActive(isOn);
            C1105.SetActive(isOn);
        }
    }

    private void stone2(int roll, bool isOn)
    {
        if (roll == 1)
        {
            C0301.SetActive(isOn);
            C0501.SetActive(isOn);
            C0901.SetActive(isOn);
        }
        if (roll == 2)
        {
            C0302.SetActive(isOn);
            C0502.SetActive(isOn);
            C0902.SetActive(isOn);
        }
        if (roll == 3)
        {
            C0303.SetActive(isOn);
            C0503.SetActive(isOn);
            C0903.SetActive(isOn);
        }
        if (roll == 4)
        {
            C0304.SetActive(isOn);
            C0504.SetActive(isOn);
            C0904.SetActive(isOn);
        }
        if (roll == 5)
        {
            C0305.SetActive(isOn);
            C0505.SetActive(isOn);
            C0905.SetActive(isOn);
        }
    }

    private void stone3(int roll, bool isOn)
    {
        if (roll == 1)
        {
            C0101.SetActive(isOn);
            C0601.SetActive(isOn);
            C0801.SetActive(isOn);
            C1001.SetActive(isOn);
        }
        if (roll == 2)
        {
            C0102.SetActive(isOn);
            C0602.SetActive(isOn);
            C0802.SetActive(isOn);
            C1002.SetActive(isOn);
        }
        if (roll == 3)
        {
            C0103.SetActive(isOn);
            C0603.SetActive(isOn);
            C0803.SetActive(isOn);
            C1003.SetActive(isOn);
        }
        if (roll == 4)
        {
            C0104.SetActive(isOn);
            C0604.SetActive(isOn);
            C0804.SetActive(isOn);
            C1004.SetActive(isOn);
        }
        if (roll == 5)
        {
            C0105.SetActive(isOn);
            C0605.SetActive(isOn);
            C0805.SetActive(isOn);
            C1005.SetActive(isOn);
        }
    }

    public void spawnStone1(int a, int b, int c)
    {
        stone1(a, true);
        stone1(b, true);
        stone1(c, true);
    }

    public void spawnStone2(int a, int b, int c)
    {
        stone2(a, true);
        stone2(b, true);
        stone2(c, true);
    }

    public void spawnStone3(int a, int b, int c)
    {
        stone3(a, true);
        stone3(b, true);
        stone3(c, true);
    }



    public void spawnWood1(int a, int b, int c)
    {
        wood1(a, true);
        wood1(b, true);
        wood1(c, true);
    }

    public void spawnWood2(int a, int b, int c)
    {
        wood2(a, true);
        wood2(b, true);
        wood2(c, true);
    }

    public void spawnWood3(int a, int b, int c)
    {
        wood3(a, true);
        wood3(b, true);
        wood3(c, true);
    }



    public void noReasources()
    {
        NoStone();
        NoWood();
    }
}
