using UnityEngine;

public class UILoader : MonoBehaviour
{
    [SerializeField] private UI _ui;

    private void Awake() =>
        _ui.gameObject.SetActive(false);

    private void Start() =>
        _ui.gameObject.SetActive(true);
}
