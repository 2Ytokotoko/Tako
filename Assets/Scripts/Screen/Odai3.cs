using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Odai3 : MonoBehaviour
{
    public GameObject Main1, Main2, Main3,Main4,Main5,Clear1, Clear2, Clear3,Clear4,Clear5;
    public int G, Kal, En;
    public float Ime;
    public int wScore, EBIHURAICOUNT,COUNT, Gcheck, Wcheck,Pcheck;
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
        Main5.SetActive(true);
        Clear5.SetActive(false);
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
        if (other.CompareTag("EBIHURAI"))
        {
            EBIHURAICOUNT += 1;

            Check();

        }
    }
    void OnTriggerExit(Collider other)
    {
        //���J�E���g
        if (other.CompareTag("datuEBIHURAI"))
        {
                EBIHURAICOUNT -= 1;
        }
        Check();
    }

    void Check()
    {





  
            
        //����@�G�r�t���C3�ȏ�
            if (EBIHURAICOUNT >= 3)
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

        //����A�d��400�ȏ�
        if (G >= 400)
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
        //����B�J�����[400�ȏ�
        if (Kal >= 400)
        {
            Main3.SetActive(true);
            Clear3.SetActive(false); audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se1;
            audioSource.Play();
            Pcheck = 1;
        }
        else if (Pcheck == 1)
        {
            Main3.SetActive(true);
            Clear3.SetActive(false);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se2;
            audioSource.Play();
        }
        else
        {
            Main3.SetActive(true);
            Clear3.SetActive(false);

        }


        //����D7���ȓ��ɃN���A
        if (Ime <= 420)
        {
            if (Bentoname != null)
            {
                Main5.SetActive(false);
                Clear5.SetActive(true);
                audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.clip = se1;
                audioSource.Play();
            }
            else
            {
                Main5.SetActive(true);
                Clear5.SetActive(false);
            }
        }
        //����C�l�i600�ȉ�
        if (En <= 600)
        {
            Main4.SetActive(true);
            Clear4.SetActive(false);
        }
        else
        {
            Main4.SetActive(true);
            Clear4.SetActive(false);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se2;
            audioSource.Play();

        }
    }
}

