using UnityEngine;
using UnityEngine.InputSystem;

public class PlayCharacter : MonoBehaviour
{
    private void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(0, 0, moveSpeed);
        }
        if (Keyboard.current.aKey.isPressed && transform.position.x > -10)
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(0, 0, -moveSpeed);
        }
        if (Keyboard.current.dKey.isPressed && transform.position.x < 10)
        {
            transform.Translate(moveSpeed, 0, 0);
        }
    }
    [SerializeField] private float moveSpeed = 5.0f;

    //private Rigidbody rb;
    //private MyControls controls;

    //private Vector2 moveInput;

    //private void Awake()
    //{
    //    Rigidbodyコンポーネントを取得
    //   rb = GetComponent<Rigidbody>();

    //    MyControlsのインスタンスを作成
    //   controls = new MyControls();


    //    Moveアクションにリスナーを追加
    //    controls.Player.Move.performed += OnMovePerformed;
    //    controls.Player.Move.canceled += OnMoveCanceled;
    //}

    //private void OnEnable()
    //{
    //    Inputアクションを有効化
    //    controls.Enable();
    //}

    //private void OnDisable()
    //{
    //    Inputアクションを無効化
    //    controls.Disable();
    //}

    //Moveの入力を受け取り、Rigidbodyを使ってボールを動かす
    //private void FixedUpdate()
    //{
    //    前後左右への移動を処理
    //    if (rb != null)
    //    {
    //        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y) * moveSpeed * Time.fixedDeltaTime;
    //        rb.MovePosition(rb.position + move);
    //    }
    //}

    //private void OnMovePerformed(InputAction.CallbackContext context)
    //{
    //    Moveアクションの値を取得
    //   moveInput = context.ReadValue<Vector2>();
    //}

    //private void OnMoveCanceled(InputAction.CallbackContext context)
    //{
    //    Moveの入力が無くなったら移動を止める
    //   moveInput = Vector2.zero;
    //}
}
