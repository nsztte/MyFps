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
            //1�ʸ��� 1���� ������ ����Ʈ �ִϸ��̼� ���
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

        //�ݺ��Լ�
        void LightAnimation()
        {
            lightMode = Random.Range(1, 4);
            animator.SetInteger("LightMode", lightMode);
        }
    }
}