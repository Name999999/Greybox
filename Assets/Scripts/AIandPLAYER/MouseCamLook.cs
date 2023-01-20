using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamLook : MonoBehaviour
{
    /* OLD MOUSE STUFF
    [SerializeField]
    public float sensitivity = 5.0f;
    [SerializeField]
    public float smoothing = 2.0f;
    // the chacter is the capsule
    public GameObject character;
    // get the incremental value of mouse moving
    private Vector2 mouseLook;
    // smooth the mouse moving
    private Vector2 smoothV;

    float initialAngle;

    public bool camActive;

    // Use this for initialization
    void Start()
    {
        character = this.transform.parent.gameObject;
        initialAngle = character.transform.localEulerAngles.y;
        camActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        // md is mosue delta

        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        // the interpolated float result between the two float values
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        // incrementally add to the camera look
        mouseLook += smoothV;

        if (camActive)
        {
            // vector3.right means the x-axis
            transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
            character.transform.localRotation = Quaternion.AngleAxis(initialAngle + mouseLook.x, Vector3.up);
        }

        //Debug.Log(mouseLook.x);

    */

        public float m_sensivity = 50f; // mouse sensitivity
        public float m_clampAngle = 90f; // This limits our look up rotation
        public Transform m_playerObject; // Sotre the player controller
        public Transform m_camera;

        private Vector2 m_mousePos; // Store mouse position
        private float m_xRotation = 0f; // Final loop up rotation value

        public bool camActive;
        // Start is called before the first frame update
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked; // Lock our cursor to the center of screen
            camActive = true;
        }

        // Update is called once per frame
        void Update()
        {
            GetMousePos(); // get the mouse position
            ClampUpRotatation(); // clamp the loop up
            LookAt(); // look at mouse position
        }

        // Get mouse position
        private void GetMousePos()
        {
            m_mousePos.x = Input.GetAxis("Mouse X") * m_sensivity * Time.deltaTime;
            m_mousePos.y = Input.GetAxis("Mouse Y") * m_sensivity * Time.deltaTime;
        }

        // FixRotation - means we can clamp our look function
        private void ClampUpRotatation()
        {

            m_xRotation -= m_mousePos.y;
            m_xRotation = Mathf.Clamp(m_xRotation, -m_clampAngle, m_clampAngle);
        }

        // Look at the mouse Position
        private void LookAt()
        {
            if (camActive)
            {
                m_camera.transform.localRotation = Quaternion.Euler(m_xRotation, 0f, 0f);
                m_playerObject.Rotate(Vector3.up * m_mousePos.x);
            }

        }

}
