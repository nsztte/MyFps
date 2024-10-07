using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MyFps
{

    public class SceneFader : MonoBehaviour
    {
        #region Variables
        //Fader 이미지
        public Image image;
        public AnimationCurve curve;
        #endregion

        private void Start()
        {
            //씬 시작시 페이드인 효과
            StartCoroutine(FadeIn());

            //씬 시작시 페이드아웃 효과
            //StartCoroutine(FadeOut());
        }

        public void FadeTo(string sceneName)
        {
            StartCoroutine(FadeOut(sceneName));
        }

        IEnumerator FadeIn()
        {
            //1초 동안 이미지 알파값 1에서 0
            float t = 1;

            while(t > 0)
            {
                t -= Time.deltaTime;
                float a = curve.Evaluate(t);
                image.color = new Color(0f, 0f, 0f, a);     //시작할때는 알파값 1
                yield return 0f;    //null
            }
        }

        IEnumerator FadeOut(string sceneName)
        {
            //1초 동안 이미지 알파값 0에서 1
            float t = 0;

            while (t < 1)
            {
                t += Time.deltaTime;
                float a = curve.Evaluate(t);
                image.color = new Color(0, 0, 0, a);
                yield return null;
            }

            //다음씬 로드
            SceneManager.LoadScene(sceneName);
        }
    }
}