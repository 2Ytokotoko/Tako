using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaitenNumber : MonoBehaviour
{
    //���[�h�`�F���W�i0�F��ޓ����@1�F��ނ�߂��j
    private int modechange;

    //�E�B���i�[�I���i�I��O�A�I�𒆁A�^�R������ꂽ�j
    private int winner;

    /*�I��������ޕ����i1�F�u���b�R���[
     *                           2�F�G�r�t���C
     *                           3�F�n���o�[�O
     *                           4�F���g��
     *                           5�F�~�[�g�{�[��
     *                           6�F�i�|���^��
     *                           7�F�p�X�^
     *                           8�F�|�b�v�R�[���V�������v
     *                           9�F�Ĕ�
     *                           10�F���Ă�
     *                           11�F�g�}�g
     *                           12�F�^�R����E�B���i�[
     *                           */
    private int select;

    public int ModeChange
    {
        get { return modechange; }
        set { modechange = value; }
    }
    
    public int Winner
    {
        get { return winner;}
        set { winner = value; }
    }

    public int Select
    {
        get { return select; }
        set { select = value; }
    }

    //�����`��]�p
    private int tyouhoukei;

    //L���ȂǓ���Ȍ`��]�p
    private int unique;

    public int Tyouhoukei
    {
        get { return tyouhoukei; }
        set { tyouhoukei = value; }
    }

    public int Unique
    {
        get { return unique; }
        set { unique = value; }
    }

    public int tamagoyaki;
    public int karaage;
    public int ebihurai;
    public int hanbaagu;
    public int syuumai;
    public int naporitan;
    public int tomato;
    public int burokkorii;
    public int miitobouru;

    public int Tamagoyaki
    {
        get { return tamagoyaki; }
        set { tamagoyaki = value; }
    }

    public int Karaage
    {
        get { return karaage; }
        set { karaage = value; }
    }

    public int Ebihurai
    {
        get { return ebihurai; }
        set { ebihurai = value; }
    }

    public int Hanbaagu
    {
        get { return hanbaagu; }
        set { hanbaagu = value; }
    }

    public int Syuumai
    {
        get { return syuumai; }
        set { syuumai = value; }
    }

    public int Naporitan
    {
        get { return naporitan; }
        set { naporitan = value; }
    }

    public int Tomato
    {
        get { return tomato; }
        set { tomato = value; }
    }

    public int Burokkorii
    {
        get { return burokkorii; }
        set { burokkorii = value; }
    }

    public int Miitobouru
    {
        get { return miitobouru; }
        set { miitobouru = value; }
    }
}
