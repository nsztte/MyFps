using TMPro;
using UnityEngine;

namespace MyFps
{
    //인터렉티브 액션 구현하는 클래스
    public abstract class Interactive : MonoBehaviour
    {
        protected abstract void DoAction();

        #region Variables
        private float theDistance;

        //action UI
        public GameObject actionUI;
        public TextMeshProUGUI actionText;
        [SerializeField] private string action = "Action Text";
        public GameObject extraCross;
        #endregion

        protected void Update()
        {
            theDistance = PlayerCasting.distanceFromTarget;
        }

        protected void OnMouseOver()
        {
            //거리가 2이하일 때 UI 활성화
            if (theDistance <= 2f)
            {
                ShowActionUI();

                if (Input.GetButtonDown("Action"))
                {
                    HideActionUI();

                    //실행
                    DoAction();
                }
            }
            else
            {
                HideActionUI();
            }
        }

        //마우스가 벗어나면 액션 UI를 감춘다
        private void OnMouseExit()
        {
            HideActionUI();
        }

        //UI 활성화
        protected void ShowActionUI()
        {
            actionUI.SetActive(true);
            actionText.text = action;
            extraCross.SetActive(true);
        }
        //UI 비활성화
        protected void HideActionUI()
        {
            actionUI.SetActive(false);
            actionText.text = "";
            extraCross.SetActive(false);
        }
    }
}