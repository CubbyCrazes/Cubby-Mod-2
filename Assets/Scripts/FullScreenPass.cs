using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FullscreenMaterialChanger : MonoBehaviour {

    //---Serialized Variables
    [SerializeField] private FullScreenPassRendererFeature feature;
    [SerializeField] private Material fullscreenMaterial;

    public void Start() {
        feature.passMaterial = fullscreenMaterial;
        feature.SetActive(fullscreenMaterial != null);
    }

    public void OnDestroy() {
        feature.SetActive(false);
    }
}