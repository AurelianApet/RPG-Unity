using UnityEngine;

public class CustomDataTracker : MonoBehaviour
{
    #region Editor references

    //[SerializeField] private 

    #endregion

    public static CustomDataTracker instance;

    private StatusC _statusC;
    public int mouseClicks { get; private set; }
    public int keyboardClicks { get; private set; }
    public int mosntersKilled { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.anyKeyDown) {
            if (Input.GetMouseButtonDown(0)) {
                mouseClicks++;
            }
            else {
                keyboardClicks++;
            }
        }
    }

    public static void onMosterKilled()
    {
        ++instance.mosntersKilled;
    }
}