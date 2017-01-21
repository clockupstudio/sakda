using UnityEngine;
public class CameraControl : MonoBehaviour
{
	public static CameraControl instance;
	public Camera mainCamera;
    private Transform cameraTransform;
    public float shakeDuration = 0f;
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;
    Vector3 originalPos;
    void Awake()
    {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

        if (cameraTransform == null)
        {
            cameraTransform = mainCamera.GetComponent<Transform>();
        }
    }
    void OnEnable()
    {
        originalPos = cameraTransform.localPosition;
    }
    void Update()
    {
		if(shakeDuration > 0) {
			cameraTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else {
			shakeDuration = 0f;
			cameraTransform.localPosition = originalPos;
		}
    }

}
