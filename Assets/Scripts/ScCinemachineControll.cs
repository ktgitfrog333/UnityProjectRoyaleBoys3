using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

/// <summary>
/// Cinemachineカメラを制御するスクリプトクラス
/// </summary>
public class ScCinemachineControll : MonoBehaviour
{
    //[SerializeField] private Animator _animator;
    /// <summary>マウス操作の補正値</summary>
    private float moveSpeed = 7f;

    //private CharacterController _characterController;
    #pragma warning disable 649
    /// <summary>エディタでVirtual Cameraをアタッチ</summary>
    [SerializeField] private CinemachineVirtualCamera _camera;
    /// <summary>CinemachineOrbitalTransposerをスクリプト制御</summary>
    private CinemachineOrbitalTransposer _transposer;
    /// <summary>座標</summary>
    private Transform _transform;

    /// <summary>移動座標補正</summary>
    private Vector3 _moveVelocity;
    /// <summary>全体座標補正</summary>
    private Vector3 world_moveVelocity;
    /// <summary>カメラ座標補正</summary>
    private Vector3 _cameraRotation;

    // Start is called before the first frame update
    void Start()
    {
        //_characterController = GetComponent<CharacterController>();
        _transposer = _camera.GetCinemachineComponent<CinemachineOrbitalTransposer>();
        _transform = transform;

        _moveVelocity = Vector3.zero;
        world_moveVelocity = Vector3.zero;
        _cameraRotation = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        world_moveVelocity = Vector3.zero;
        _moveVelocity = Vector3.zero;

        _cameraRotation.x = Input.GetAxisRaw(CsNormalLevelDesignOfCommon.RIGHT_HORIZONTAL);
        _cameraRotation.z = Input.GetAxisRaw(CsNormalLevelDesignOfCommon.RIGHT_VERTICAL);

        if (_cameraRotation.magnitude >= 0.1)
        {
            _transposer.m_Heading.m_Bias += _cameraRotation.x * 3f; //Biasを操作
            _transposer.m_FollowOffset.y -= _cameraRotation.z / 8f; //Follow Offsetを操作

        }

        _moveVelocity.x = Input.GetAxisRaw(CsNormalLevelDesignOfCommon.LEFT_HORIZONTAL) * moveSpeed;
        _moveVelocity.z = Input.GetAxisRaw(CsNormalLevelDesignOfCommon.LEFT_VERTICAL) * moveSpeed;

        if (_moveVelocity.magnitude >= 0.01)
        {
            //座標系の補正
            world_moveVelocity = Quaternion.AngleAxis(_transposer.m_Heading.m_Bias, Vector3.up) * _moveVelocity;

            Vector3 targetPositon = _transform.position + world_moveVelocity;
            //向かせたい方向
            Quaternion targetRotation = Quaternion.LookRotation(targetPositon - _transform.position);

            _transform.rotation = Quaternion.Slerp(_transform.rotation, targetRotation, 0.2f);
        }

        //_characterController.Move(world_moveVelocity * Time.deltaTime);

        //_animator.SetFloat("Speed", new Vector3(_moveVelocity.x, 0, _moveVelocity.z).magnitude);
    }
}
