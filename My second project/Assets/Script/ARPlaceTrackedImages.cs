using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System;


[System.Serializable]
public struct ARObjectPrefab
{
    public string name;
    public GameObject prefab;
}
public class ARPlaceTrackedImages : MonoBehaviour
{
    // Lista de prefabs AR, cada uno con el nombre de la imagen a aumentar
    public List<ARObjectPrefab> objectPrefabs = new List<ARObjectPrefab>();


    // Diccionario de nombres de imágenes e instancias de prefabs AR asignadas
    private Dictionary<string, GameObject> instantiatedObjects;


    private ARTrackedImageManager trackedImagesManager;


    void Awake()
    {
        trackedImagesManager = GetComponent<ARTrackedImageManager>();
        instantiatedObjects = new Dictionary<string, GameObject>();
    }
    void OnEnable()
    {
        trackedImagesManager.trackedImagesChanged += OnTrackedImagesChanged;
    }


    void OnDisable()
    {
        trackedImagesManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }
    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        throw new NotImplementedException();
    }
}
