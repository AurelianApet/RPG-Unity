using UnityEngine;

public class DontDestroyOnloadC : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}