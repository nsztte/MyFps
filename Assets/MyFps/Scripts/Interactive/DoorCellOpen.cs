using TMPro;
using UnityEngine;

namespace MyFps
{
    public class DoorCellOpen : Interactive
    {
        #region Variables
        //action
        private Animator animator;
        private BoxCollider boxCollider;
        public AudioSource audioSource;
        #endregion

        private void Start()
        {
            animator = GetComponent<Animator>();
            boxCollider = GetComponent<BoxCollider>();
        }

        protected override void DoAction()
        {
            //문이 열린다
            animator.SetBool("IsOpen", true);
            boxCollider.enabled = false;
            audioSource.Play(); 
        }
    }
}