using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MyFps
{
    public class BFirstTrigger : MonoBehaviour
    {
        #region Variables
        //게임오브젝트
        public GameObject thePlayer;
        public GameObject arrow;

        //sequence UI
        public TextMeshProUGUI textBox;
        [SerializeField]
        private string sequence = "Looks like a weapon on that table.";
        #endregion

        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(PlaySequence());
        }

        //트리거 작동시 플레이
        IEnumerator PlaySequence()
        {
            //플레이 캐릭터 비활성화
            thePlayer.SetActive(false);

            //대사출력
            textBox.gameObject.SetActive(true);
            textBox.text = sequence;

            //1초 딜레이 후 화살표 활성화
            yield return new WaitForSeconds(1f);
            arrow.SetActive(true);

            //1초 딜레이 후 플레이어 활성화
            yield return new WaitForSeconds(1f);
            thePlayer.SetActive(true);


            //초기화
            textBox.text = "";
            textBox.gameObject.SetActive(false);

            //플레이캐릭터 다시 플레이
            thePlayer.SetActive(true);

            //충돌체 비활성화
            transform.GetComponent<BoxCollider>().enabled = false;

        }
    }
}