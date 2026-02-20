using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class ChangeFace : MonoBehaviour
{
    private ARFaceManager faceManager;
    public GameObject prefabEye;
    private GameObject goEyeL;
    private GameObject goEyeR;
    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }
    void OnEnable()
    {
        faceManager.facesChanged += OnFacesChanged;
    }
    void OnDisable()
    {
        faceManager.facesChanged -= OnFacesChanged;
    }
    void OnFacesChanged(ARFacesChangedEventArgs args)
    {
        foreach (ARFace face in args.added)
        {
            // Cuando detectamos la cara creamos los prefabs
            // en la posición de los ojosç
            goEyeL = Instantiate(prefabEye);
            goEyeR = Instantiate(prefabEye);


            #if UNITY_IOS
                goEyeL.transform.localPosition = face.leftEye.position;
                goEyeR.transform.localPosition = face.rightEye.position;
            #elif UNITY_ANDROID
                Vector3 leftEye = face.vertices[159]; // Ojo izquierdo(las posiciones son relativas a la face)
                Vector3 rightEye = face.vertices[386]; // Ojo derecho (las posiciones son relativas a la face)
                goEyeL.transform.localPosition = face.transform.TransformPoint(leftEye);
                goEyeR.transform.localPosition = face.transform.TransformPoint(rightEye);
            #endif
        }
        foreach (ARFace face in args.updated)
        {
            // Cuando detectamos que la posición de la cara cambia
            // modificamos la posición de los objetos
            if (face.trackingState == TrackingState.Tracking)
            {
            #if UNITY_IOS
                goEyeL.transform.localPosition = face.leftEye.position;
                goEyeR.transform.localPosition = face.rightEye.position;
            #elif UNITY_ANDROID
                Vector3 leftEye = face.vertices[159]; // Ojo izquierdo (las posiciones son relativas a la face)
                Vector3 rightEye = face.vertices[386]; // Ojo derecho (las posiciones son relativas a la face)
                goEyeL.transform.localPosition = face.transform.TransformPoint(leftEye);
                goEyeR.transform.localPosition = face.transform.TransformPoint(rightEye);
            #endif
            }
        }
        foreach (ARFace face in args.removed)
        { // Algo aqui


        }
    }
}
