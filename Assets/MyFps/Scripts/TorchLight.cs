using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace MySample
{
    public class TorchLight : MonoBehaviour
    {
        #region Variables
        public Transform torchLight;
        private Animator animator;

        private int lightMode = 0;
        #endregion

        private void Start()
        {
            animator = torchLight.GetComponent<Animator>();
            lightMode = 0;

            InvokeRepeating("LightAnimation", 0f, 1f);
        }

        private void Update()
        {
            //1초마다 1번씩 랜덤한 라이트 애니메이션 재생
            //if(lightMode == 0)
            //StartCoroutine(FlameAnimation());
        }

        IEnumerator FlameAnimation()
        {
            lightMode = Random.Range(1, 4);
            animator.SetInteger("LightMode", lightMode);

            yield return new WaitForSeconds(1.0f);
            lightMode = 0;
        }

        //반복함수
        void LightAnimation()
        {
            lightMode = Random.Range(1, 4);
            animator.SetInteger("LightMode", lightMode);
        }
    }
}