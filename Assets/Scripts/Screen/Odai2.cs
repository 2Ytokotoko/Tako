using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Odai2 : MonoBehaviour
{
    public GameObject Main1, Main2, Main3,Main4, Clear1, Clear2, Clear3,Clear4;
    public int G, Kal, En;
    public float Ime;
    public int wScore, NAPORITANNCOUNT, MIITOBOURUCOUNT,COUNT, Gcheck, Wcheck,Pcheck;
    public CountDown countDown;
    public Weight weight;
    private AudioSource audioSource;
    public AudioClip se1, se2;
    Kcal kal;
    Weight g;
    Price en;�@//�Δg���o�Ă邩�������ǖ��Ȃ����f����Ă�
    CountDown time;

    //�X�N���v�g�������Ă���I�u�W�F�N�g
    GameObject KS;
    GameObject TT;
    private GameObject Bentoname;

    void Start()
    {
        TT = GameObject.Find("Time");
        KS = GameObject.Find("Hantei");
        kal = KS.GetComponent<Kcal>();
        g = KS.GetComponent<Weight>();
        en = KS.GetComponent<Price>();
        time = TT.GetComponent<CountDown>();
        Main1.SetActive(true);
        Clear1.SetActive(false);
        Main2.SetActive(true);
        Clear2.SetActive(false);
        Main3.SetActive(true);
        Clear3.SetActive(false);
        Main4.SetActive(true);
        Clear4.SetActive(false);
        Check();
    }
    void Update()
    {
        Kal = kal.score;
        G = g.score;
        En = en.score;
        Ime = time.countdown;
        Bentoname = GameObject.Find("OdaiName");
        Check();
    }
    void OnTriggerEnter(Collider other)
    {
        //���J�E���g
        if (other.CompareTag("NAPORITANN"))
        {
            NAPORITANNCOUNT += 1;
        }
        Check();
        //���J�E���g
        if (other.CompareTag("MIITOBOURU"))
        {
            MIITOBOURUCOUNT += 1;
        }
        Check();
    }
    void OnTriggerExit(Collider other)
    {
        //���J�E���g
        if (other.CompareTag("datuNAPORITANN"))
        {
            NAPORITANNCOUNT -= 1;
        }
        Check();
        //���J�E���g
        if (other.CompareTag("datuMIITOBOURU"))
        {
            MIITOBOURUCOUNT -= 1;
        }
        Check();
    }

    void Check()
    {
        //����@�i�|���^������4�ȏ�&�~�[�g�{�[������6�ȏ�
        if ((NAPORITANNCOUNT >= 4) && (MIITOBOURUCOUNT >= 6))
        {
            Main1.SetActive(false);
            Clear1.SetActive(true);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se1;
            audioSource.Play();
            Gcheck = 1;
        }
        else if (Gcheck == 1)
        {
            Main1.SetActive(true);
            Clear1.SetActive(false);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se2;
            audioSource.Play();
        }
        else
        {
            Main1.SetActive(true);
            Clear1.SetActive(false);

        }

        //����A�J�����[500�ȏ�
        if (Kal >= 500)
        {
            Main2.SetActive(false);
            Clear2.SetActive(true);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se1;
            audioSource.Play();
            Wcheck = 1;
        }
        else if (Wcheck == 1)
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se2;
            audioSource.Play();
        }
        else
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);

        }

        //����B5���ȓ��ɃN���A
        if (Ime <= 300)
        {
            if (Bentoname != null)
            {
                Main3.SetActive(false);
                Clear3.SetActive(true);
                audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.clip = se1;
                audioSource.Play();
            }
            else
            {
                Main3.SetActive(true);
                Clear3.SetActive(false);
            }
        }
        //����C�l�i1000�ȉ�
        if (En <= 1000)
        {
            Main4.SetActive(true);
            Clear4.SetActive(false); audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se1;
            audioSource.Play();
            Pcheck = 1;
        }
        else if (Pcheck == 1)
        {
            Main4.SetActive(true);
            Clear4.SetActive(false);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se2;
            audioSource.Play();
        }
        else
        {
            Main4.SetActive(true);
            Clear4.SetActive(false);

        }
    }
}

/*

void Check()
{
    //����@�i�|���^��4�ȏ�A�~�[�g�{�[��6�ȏ�
    if ((NAPORITANNCOUNT >= 4) && (MIITOBOURUCOUNT >= 6))
    {
            Main1.SetActive(false);
            Clear1.SetActive(true);

    }
        //����A�J�����[500�ȏ�
        if (kScore >= 500)
        {
            Main2.SetActive(false);
            Clear2.SetActive(true);
        }

        //����B5���ȓ��ɃN���A
        if (Count <= 300)
        {
            if (Time.timeScale == 0f)
            {
                Main3.SetActive(false);
                Clear3.SetActive(true);
            }
            else
            {
                Main3.SetActive(true);
                Clear3.SetActive(false);
            }
        }

    }
}*/
