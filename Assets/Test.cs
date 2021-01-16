// データを格納する型を使うための宣言
using System.Collections;
using System.Collections.Generic;
// Unityに準備されている機能を使うための宣言
using UnityEngine;

public class Boss {
    private int hp = 100;
    private int mp = 53;
    private int power = 25;

    // 攻撃用の関数
    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    // 魔法攻撃の関数
    public void Magic() {
        if (this.mp < 5) {
            Debug.Log("MPが足りないため魔法が使えない");
        } else {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
    }

}

// Testクラス
// スクリプト名とクラス名は同じでなくてはならない
public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    // 最初に1度だけ実行する処理を記述
    void Start()
    {
        int[] array = {2, 3, 5, 7, 11};

        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--) {
            Debug.Log(array[i]);
        }

        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        for (int i = 0; i < 11; i++) {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    // 毎フレーム実行する処理を記述
    void Update()
    {
    }
}
