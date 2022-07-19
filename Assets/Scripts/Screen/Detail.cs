using UnityEngine;

namespace GlobalOutline
{
    public class Detail : MonoBehaviour
    {
        public GameObject TOMATO;
        public GameObject BUROKKORII;
        public GameObject KARAAGE;
        public GameObject EBIHURAI;
        public GameObject TAMAGOYAKI;
        public GameObject TAKO;
        public GameObject GOHAN;
        public GameObject SYUUMAI;
        public GameObject NAPORITANN;
        public GameObject PASUTA;
        public GameObject MIITOBOURU;
        public GameObject HANNBAAGU;
        public GameObject POPPUCONSHURINPU;
        private OutlineEffect outlineEffect;
        void Start()
        {
            outlineEffect = GetComponent<OutlineEffect>();
            outlineEffect.enabled = false;
            TOMATO.SetActive(false);
            BUROKKORII.SetActive(false);
            KARAAGE.SetActive(false);
            EBIHURAI.SetActive(false);
            TAMAGOYAKI.SetActive(false);
            TAKO.SetActive(false);
            GOHAN.SetActive(false);
            NAPORITANN.SetActive(false);
            PASUTA.SetActive(false);
            MIITOBOURU.SetActive(false);
            HANNBAAGU.SetActive(false);
        }
        void OnMouseEnter()
        {
            if (Time.timeScale == 0f)
            {
                outlineEffect.enabled = false;
                TOMATO.SetActive(false);
                BUROKKORII.SetActive(false);
                KARAAGE.SetActive(false);
                EBIHURAI.SetActive(false);
                TAMAGOYAKI.SetActive(false);
                TAKO.SetActive(false);
                GOHAN.SetActive(false);
                SYUUMAI.SetActive(false);
                NAPORITANN.SetActive(false);
                PASUTA.SetActive(false);
                MIITOBOURU.SetActive(false);
                HANNBAAGU.SetActive(false);
            }
            else if (this.gameObject.CompareTag("TOMATO"))
            {
                outlineEffect.enabled = true;
                TOMATO.SetActive(true);
            }
            else if (this.gameObject.CompareTag("BUROKKORII"))
            {
                outlineEffect.enabled = true;
                BUROKKORII.SetActive(true);
            }
            else if (this.gameObject.CompareTag("KARAAGE"))
            {
                outlineEffect.enabled = true;
                KARAAGE.SetActive(true);
            }
            else if (this.gameObject.CompareTag("EBIHURAI"))
            {
                outlineEffect.enabled = true;
                EBIHURAI.SetActive(true);
            }
            else if (this.gameObject.CompareTag("TAMAGOYAKI"))
            {
                outlineEffect.enabled = true;
                TAMAGOYAKI.SetActive(true);
            }
            else if (this.gameObject.CompareTag("TAKO") || this.gameObject.CompareTag("Player"))
            {
                outlineEffect.enabled = true;
                TAKO.SetActive(true);
            }
            else if (this.gameObject.CompareTag("Bento"))
            {
                outlineEffect.enabled = true;
                GOHAN.SetActive(true);
            }
            else if (this.gameObject.CompareTag("SYUUMAI"))
            {
                outlineEffect.enabled = true;
                SYUUMAI.SetActive(true);
            }
            else if (this.gameObject.CompareTag("NAPORITANN"))
            {
                outlineEffect.enabled = true;
                NAPORITANN.SetActive(true);
            }
            else if (this.gameObject.CompareTag("PASUTA"))
            {
                outlineEffect.enabled = true;
                PASUTA.SetActive(true);
            }
            else if (this.gameObject.CompareTag("MIITOBOURU"))
            {
                outlineEffect.enabled = true;
                MIITOBOURU.SetActive(true);
            }
            else if (this.gameObject.CompareTag("HANNBAAGU"))
            {
                outlineEffect.enabled = true;
                HANNBAAGU.SetActive(true);
            }
            else if (this.gameObject.CompareTag("POPPUCONSHURINPU"))
            {
                outlineEffect.enabled = true;
                POPPUCONSHURINPU.SetActive(true);
            }
        }
        void OnMouseExit()
        {
            outlineEffect.enabled = false;
            if (this.gameObject.CompareTag("TOMATO"))
            {
                TOMATO.SetActive(false);
            }
            if (this.gameObject.CompareTag("BUROKKORII"))
            {
                BUROKKORII.SetActive(false);
            }
            if (this.gameObject.CompareTag("KARAAGE"))
            {
                KARAAGE.SetActive(false);
            }
            if (this.gameObject.CompareTag("EBIHURAI"))
            {
                EBIHURAI.SetActive(false);
            }
            if (this.gameObject.CompareTag("TAMAGOYAKI"))
            {
                TAMAGOYAKI.SetActive(false);
            }
            if (this.gameObject.CompareTag("TAKO") || this.gameObject.CompareTag("Player"))
            {
                TAKO.SetActive(false);
            }
            if (this.gameObject.CompareTag("Bento"))
            {
                GOHAN.SetActive(false);
            }
            if (this.gameObject.CompareTag("SYUUMAI"))
            {
                SYUUMAI.SetActive(false);
            }
            if (this.gameObject.CompareTag("NAPORITANN"))
            {
                NAPORITANN.SetActive(false);
            }
            if (this.gameObject.CompareTag("PASUTA"))
            {
                PASUTA.SetActive(false);
            }
            if (this.gameObject.CompareTag("MIITOBOURU"))
            {
                MIITOBOURU.SetActive(false);
            }
            if (this.gameObject.CompareTag("HANNBAAGU"))
            {
                HANNBAAGU.SetActive(false);
            }
            if (this.gameObject.CompareTag("POPPUCONSHURINPU"))
            {
                POPPUCONSHURINPU.SetActive(false);
            }
        }
    }
}