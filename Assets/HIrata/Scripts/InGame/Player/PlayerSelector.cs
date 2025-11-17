using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    public static PlayerSelector Instance;
    public Player selectedPlayer;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Player player = hit.collider.GetComponent<Player>();
                if (player != null)
                {
                    selectedPlayer = player;

                    // 修正：Select()/Unselect() を呼ぶ
                    Player[] allPlayers = UnityEngine.Object.FindObjectsByType<Player>(
      FindObjectsSortMode.None
  );

                    foreach (var p in allPlayers)
                    {
                        if (p == selectedPlayer)
                            p.Select();
                        else
                            p.Unselect();
                    }

                    Debug.Log($"選択中プレイヤー: {player.name}");
                }
            }
        }
    }
}
