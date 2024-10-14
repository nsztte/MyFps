using TMPro;
using UnityEngine;

namespace MyFps
{
    public class PickUpPistol : Interactive
    {
        #region Variables
        //
        public GameObject realPistol;
        public GameObject arrow;

        public GameObject enemyTrigger;
        #endregion


        protected override void DoAction()
        {
            //피스톨
            realPistol.SetActive(true);
            arrow.SetActive(false);

            enemyTrigger.SetActive(true);

            Destroy(this.gameObject);
        }
    }
}