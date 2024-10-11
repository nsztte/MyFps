using UnityEngine;

namespace Sample
{
    public class MoveObject : MonoBehaviour
    {
        #region Variables
        private Rigidbody rb;

        //좌우로 힘을 주어 이동
        [SerializeField] private float movePower = 5f;
        private float moveX;

        //색 변경
        private Renderer m_renderer;
        private Color originalColor;
        #endregion

        // Start is called before the first frame update
        void Start()
        {
            //참조
            rb = GetComponent<Rigidbody>();
            m_renderer = GetComponent<Renderer>();

            //초기화
            originalColor = m_renderer.material.color;
            MoveRightByForce();
        }

        // Update is called once per frame
        void Update()
        {
            //입력 처리
            moveX = Input.GetAxis("Horizontal");
        }

        private void FixedUpdate()
        {
            //좌우로 힘을 주어 이동
            //rb.AddForce(Vector3.right * moveX * movePower, ForceMode.Force);    //Force는 계속적인 힘
        }

        public void MoveRightByForce()
        {
            rb.AddForce(Vector3.right * movePower, ForceMode.Impulse);
        }

        public void MoveLeftByForce()
        {
            rb.AddForce(Vector3.left * movePower, ForceMode.Impulse);
        }

        public void ChangeRedColor()
        {
            m_renderer.material.color = Color.red;
        }

        public void ResetColor()
        {
            m_renderer.material.color = originalColor;
        }
    }
}