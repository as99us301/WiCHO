using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class positiontest : MonoBehaviour
{
    public Transform target;    // 3D目標
    public Transform ui;        // 2D UI
    private Vector3 originOff;  // 當前UI系統(0,0)點 相對於屏幕左下角(0, 0)點的偏移量
        private void Start()
    {
        originOff = new Vector3(-Screen.width / 2, -Screen.height / 2);
        Reposition();
    }

    private void Update()
    {
        // 需要性能優化 僅在物體移動或相機移動後調用即可
        Reposition();
    }

    // 根據目標物體 重定位UI
    private void Reposition()
    {
        Vector3 position = Camera.main.WorldToScreenPoint(target.position) + originOff;
        position.z = 0;
        ui.localPosition = position;
    }

}
